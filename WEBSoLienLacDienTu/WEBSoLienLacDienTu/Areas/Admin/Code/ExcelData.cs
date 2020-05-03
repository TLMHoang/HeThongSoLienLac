using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using ExcelDataReader;

namespace WEBSoLienLacDienTu.Areas.Admin.Code
{
    public class ExcelData
    {
        string _path;
        public ExcelData(string path)
        {
            _path = path;
        }

        public IExcelDataReader getExcelReader()
        {
            // ExcelDataReader works with the binary Excel file, so it needs a FileStream
            // to get started. This is how we avoid dependencies on ACE or Interop:
            FileStream stream = File.Open(_path, FileMode.Open, FileAccess.Read);
            //
            // We return the interface, so that
            IExcelDataReader reader = null;
            try
            {
                if (_path.EndsWith(".xls"))
                {
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                if (_path.EndsWith(".xlsx"))
                {
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                if (_path.EndsWith(".ods"))
                {
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                return reader;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<string> getWorksheetNames()
        {
            var reader = this.getExcelReader();
            var workbook = reader.AsDataSet();
            var sheets = from DataTable sheet in workbook.Tables select sheet.TableName;
            return sheets;
        }
        public IEnumerable<DataRow> getData(string sheet)
        {
            var reader = this.getExcelReader();
            //string SheetName = getWorksheetNames().FirstOrDefault();
            var workSheet = reader.AsDataSet(
                new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true // To set First Row As Column Names  
                    }
                }
                ).Tables[sheet];
            var filteredRows = workSheet.Rows.Cast<DataRow>().Where(row => row.ItemArray.Any(field => !(field is System.DBNull)));
            //  TTliteUtil.Util.WriteToEventLog("Sheet read: "+workSheet.ToString());
            var rows = from DataRow a in filteredRows select a;
            return rows;
        }
    }
}
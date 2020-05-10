using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FunctionOrder
    {
        public int ID { get; set; }
        public string NameFunc { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public FunctionOrder()
        {
            ID = -1;
            NameFunc = "";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }

        public FunctionOrder(int id, string nameFunc, DateTime startDate, DateTime endDate)
        {
            ID = id;
            NameFunc = nameFunc;
            StartDate = startDate;
            EndDate = endDate;
        }

        public FunctionOrder(DataRow dr)
        {
            ID = Convert.IsDBNull(dr["ID"]) ? -1 : Convert.ToInt32(dr["ID"]);
            NameFunc = dr["NameFunc"].ToString();
            StartDate = Convert.ToDateTime(dr["StartDate"]);
            EndDate = Convert.ToDateTime(dr["EndDate"]);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BAL
{
    public class ThongTinHSBAL : CInterface<ThongTinHS>
    {
        ThongTinHSDAL hs = new ThongTinHSDAL();
        public async Task<int> CapNhap(ThongTinHS obj)
        {
            return await hs.CapNhap(obj);
        }

        public async Task<DataTable> LayDT()
        {
            return await hs.Lay();
        }

        public async Task<List<ThongTinHS>> LayLst()
        {
            List<ThongTinHS> lst = new List<ThongTinHS>();

            foreach (DataRow dr in (await LayDT()).Rows)
            {
                lst.Add(new ThongTinHS(dr));
            }

            return lst;
        }

        public async Task<int> Them(ThongTinHS obj)
        {
            return await hs.Them(obj);
        }

        public async Task<int> Xoa(int ID)
        {
            return await hs.Xoa(ID);
        }
    }
}

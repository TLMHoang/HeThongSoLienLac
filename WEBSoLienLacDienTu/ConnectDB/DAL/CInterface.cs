using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDB.DAL
{
    interface CInterface<T>
    {
        Task<DataTable> LayDT();
        Task<DataTable> LayDT(int ID);
        Task<List<T>> LayLst();
        Task<int> CapNhap(T obj);
        Task<int> Xoa(int ID);
        Task<int> Them(T obj);
    }

}

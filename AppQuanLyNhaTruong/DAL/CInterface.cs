using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface CInterface<T>
    {
        Task<DataTable> Lay();
        Task<DataTable> Lay(int ID);
        Task<int> CapNhap(T obj);
        Task<int> Xoa(int ID);
        Task<int> Them(T obj);
    }
}
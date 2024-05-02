using EBillApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBillApplication.Repositery
{
    interface IData
    {
        void SaveBillDetails(BillDetails details);

        void SaveBillItems(List<Items> items, SqlConnection con , int id);
        List<BillDetails> GetAllDetails();
        BillDetails GetDetail(int id);
    }
}

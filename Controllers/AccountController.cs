using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EBillApplication.Models;
using System.Data.SqlClient;

namespace EBillApplication.Controllers
{
    public class AccountController : Controller
    {
        //SqlConnection con = new SqlConnection();
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        //// GET: Account
        //[HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //void connectionString()
        //{
        //    con.ConnectionString = "data source = DESKTOP-1VFEJTJ\\SQLEXPRESS; database=EBillDB;";
        //}

        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]

        //public ActionResult Verify(Account acc)
        //{
        //    connectionString();
        //    con.Open();
        //    con.Close();
        //    cmd.Connection = con;
        //    cmd.CommandText = "select * from tbl_login where UserName='"+acc.UserName+"' and password='"+acc.password+"'";
        //    dr = cmd.ExecuteReader();
        //    if(dr.Read())
        //    {
        //        con.Close();
        //        return View("Index");
        //    }
        //    else
        //    {
        //        con.Close();
        //        return View("Error");
        //    }
       
        //}
    }
}
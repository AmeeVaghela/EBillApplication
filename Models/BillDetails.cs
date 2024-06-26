﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EBillApplication.Models;

namespace EBillApplication.Models
{
    public class BillDetails
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public string MobileNumber { get; set; }

        public string Address { get; set; }

        public int TotalAmount { get; set; }
        public List<Items> Items { get; set; }


        public BillDetails() 
        {
            Items = new List<Items>();
        }
    }
}
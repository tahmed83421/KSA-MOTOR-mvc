﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public  class Invoice
    {
        public int Invoice_ID { get; set; }
        public int Customer_ID { get; set; }
        public string To_Name { get; set; }
        public string To_Phone { get; set; }
        public string Ship_Name { get; set; }
        public string Ship_Company { get; set; }
        public string Ship_Adress { get; set; }
        public string Ship_City { get; set; }
        public string Ship_Contact { get; set; }
        public int Vehicle_Id { get; set; }
        
        public string Delivery_Date { get; set; }
        public string Payment_Terms { get; set; }
        public List<PartsInventory> Parts { get; set; }
        public List<Vehicle> vehicles { get; set; }
        public int Weight { get; set; }
        public int Total_Price { get; set; }






    }
}

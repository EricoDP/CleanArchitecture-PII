using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities.BD_Entities
{
    public class Product : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Buy_P { get; set; }
        public double Sell_P { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities.BD_Entities
{
    public class Client : BaseEntity
    {
        public string Cedula { get; set; }
        public string Name { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public string Type { get; set; }
    }
}

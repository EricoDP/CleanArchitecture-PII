using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entities.BD_Entities
{
    public class Category : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
    }
}

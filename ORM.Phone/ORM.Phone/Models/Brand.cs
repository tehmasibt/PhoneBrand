﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Phone.Models
{
    internal class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return Id + " " + Name + " " + PhoneNumber;
        }
    }
}

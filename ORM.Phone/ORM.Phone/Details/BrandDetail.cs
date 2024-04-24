using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Identity.Client;
using ORM.Phone.DAL;
using ORM.Phone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Phone.Details
{
    internal class BrandDetail
    {
        public List<Brand> Get()
        {
            var dataCon=new DataContext();
            return  dataCon.Brands.ToList();
        }
        public Brand GetOne(int id)
        {
            var dataCon = new DataContext();
            return dataCon.Brands.Find(id);
        }
        
    }
}

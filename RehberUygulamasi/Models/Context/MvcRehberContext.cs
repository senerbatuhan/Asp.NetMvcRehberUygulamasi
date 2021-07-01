using RehberUygulamasi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace RehberUygulamasi.Models.Context
{
    public class MvcRehberContext:DbContext
    {
        public MvcRehberContext():base("Server=.;Database=MvcRehberDB;Trusted_Connection=true")
        {

        }
        public DbSet<Kisi> Kisiler { get; set; }




    }
}

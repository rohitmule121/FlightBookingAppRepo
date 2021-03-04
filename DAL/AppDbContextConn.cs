using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Entities;

namespace DAL
{
   public class AppDbContextConn:DbContext
    {

        public AppDbContextConn(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { 
        
        }

        //protected override void Onconfigguring()
        public DbSet<FlightMaster> flightMasters { get; set; }
        public DbSet<FlightDetail> flightDetails { get; set; }
    }
}

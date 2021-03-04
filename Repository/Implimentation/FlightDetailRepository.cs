using DAL;
using DAL.Entities;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implimentation
{
   public class FlightDetailRepository:Repository<FlightDetail>, IFlightDetailRepository
    {
        public FlightDetailRepository(AppDbContextConn dbocontextconn) : base(dbocontextconn)
        { 
        }
    }
}

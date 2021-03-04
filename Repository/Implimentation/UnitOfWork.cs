using DAL;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implimentation
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContextConn _dbContextConn;

        private IFlightDetailRepository _flightDetailsRepository;
        private IFlightMasterRepository _flightMasterRepository;

        public UnitOfWork(AppDbContextConn dbContextConn)
        {
            _dbContextConn = dbContextConn;

        }

        public IFlightMasterRepository flightMasterRepository
        {

            get
            {
               return _flightMasterRepository = new FlightMasterRepository(_dbContextConn);
            }
        }

        public IFlightDetailRepository flightDetailsRepository
        {

            get
            {
                return _flightDetailsRepository = new FlightDetailRepository(_dbContextConn);
            }
        }
    }
}

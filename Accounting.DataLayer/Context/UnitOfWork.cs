using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repository;

namespace Accounting.DataLayer.Models
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        IAccountingRepository<Transaction> _transactionRepository;
        IAccountingRepository<Customer> _customerRepository;
        IAccountingRepository<Login> _loginRepository;
        public IAccountingRepository<Transaction> transactionRepository {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new AccountingRepository<Transaction>(db);
                }
                return _transactionRepository;
            }
        }
        public IAccountingRepository<Customer> customerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new AccountingRepository<Customer>(db);
                }
                return _customerRepository;
            }
        }
        public IAccountingRepository<Login> loginRepository
        {
            get
            {
                if(_loginRepository == null)
                {
                    _loginRepository = new AccountingRepository<Login>(db);
                }
                return _loginRepository;
            } 
        }
        public void Save()
        {
            db.SaveChanges();
        }
		

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
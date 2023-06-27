using Accounting.DataLayer.Models;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class CalculateAccountBalance
    {
        public static ReportViewModel calculatePerDay()
        {
            ReportViewModel reportViewModel = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {

                var date = DateTime.Now;
                var fromDate = new DateTime(date.Year, date.Month, date.Day, 00, 00, 01);
                reportViewModel.totalIncome = db.transactionRepository.GetAll(x => x.TypeID == 1 && x.Datetime > fromDate && x.Datetime < DateTime.Now).Sum(x => x.Amount);
                reportViewModel.totalCost = db.transactionRepository.GetAll(x => x.TypeID == 2 && x.Datetime > fromDate && x.Datetime < DateTime.Now).Sum(x => x.Amount);
                reportViewModel.totalBalance = reportViewModel.totalIncome - reportViewModel.totalCost;
            }
            return reportViewModel;
        }


        public static ReportViewModel calculatePerMonth()
        {
            ReportViewModel reportViewModel = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {

                var date = DateTime.Now;
                var fromDate = new DateTime(date.Year, date.Month, 1, 00, 00, 01);
                reportViewModel.totalCost = db.transactionRepository.GetAll(x => x.TypeID == 2 && x.Datetime > fromDate && x.Datetime < DateTime.Now).Sum(x => x.Amount);
                reportViewModel.totalIncome = db.transactionRepository.GetAll(x => x.TypeID == 1 && x.Datetime > fromDate && x.Datetime < DateTime.Now).Sum(x => x.Amount);
                reportViewModel.totalBalance = reportViewModel.totalIncome - reportViewModel.totalCost;
            }
            return reportViewModel;
        }

        public static ReportViewModel calculatePerYear()
        {
            ReportViewModel reportViewModel = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {

                var date = DateTime.Now;
                var fromDate = new DateTime(date.Year, 1, 1, 00, 00, 01);
                reportViewModel.totalCost = db.transactionRepository.GetAll(x => x.TypeID == 2 && x.Datetime > fromDate && x.Datetime < DateTime.Now).Sum(x => x.Amount);
                reportViewModel.totalIncome = db.transactionRepository.GetAll(x => x.TypeID == 1 && x.Datetime > fromDate && x.Datetime < DateTime.Now).Sum(x => x.Amount);
                reportViewModel.totalBalance = (reportViewModel.totalIncome - reportViewModel.totalCost);

            }
            return reportViewModel;
        }
    }
}

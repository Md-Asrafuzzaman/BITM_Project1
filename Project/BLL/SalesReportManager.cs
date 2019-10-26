using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Repository;
using Project.Model;
namespace Project.BLL
{
    class SalesReportManager
    {
        SalesReportRepository _salesReportRepository = new SalesReportRepository();
        public List<SalesItems> DisplayProfit(SalesReport salesReport)
        {
            return _salesReportRepository.DisplayProfit(salesReport);
        }
    }
}

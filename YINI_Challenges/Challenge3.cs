using System;
using System.Collections.Generic;
using System.Linq;

namespace YINI_Challenges
{
    public static class Challenge3
    {
        /// <summary>
        /// It has been a busy year at mountain warehouse, having made lots of sales.
        /// Management would like to know which branch made the most in revenue.
        /// For this challenge you will be given an array of sales broken down by Branch and Date.  
        /// You will need to sum all branch across multiple days and identify which branch had the highest sales overall
        /// Assume that there is only one branch with the highest total
        /// We have provided some starting code but if you know of a better method then go ahead with that
        /// </summary>
        /// <param name="sales">The array of sales items</param>
        /// <returns>The branch with the best performing sales</returns>
        public static string CalculateBestBranch(SalesItem[] sales) 
        {
            decimal max = decimal.MinValue;
            string bestBranch = string.Empty;

            foreach(var sale in sales)
                if(sale.TotalSales > max)
                {
                    max = sale.TotalSales;
                    bestBranch = sale.Branch;
                }

            return bestBranch;
        }
    }

    public class SalesItem
    {
        public string Branch { get; set; }
        public decimal TotalSales { get; set; }
        public DateTime Date { get; set; }
    }
}

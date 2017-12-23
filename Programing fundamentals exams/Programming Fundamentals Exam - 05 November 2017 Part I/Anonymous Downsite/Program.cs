using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace temp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfAffectedWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            decimal totalLoss = 0m;
            BigInteger securityToken = BigInteger.Pow(securityKey, countOfAffectedWebsites);
            List<string> websitesEfected = new List<string>();

            for (int i = 0; i < countOfAffectedWebsites; i++)
            {
                string[] websiteInfo = Console.ReadLine().Split();

                string websiteName = websiteInfo[0];
                long websiteVisits = long.Parse(websiteInfo[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websiteInfo[2]);

                websitesEfected.Add(websiteName);
                totalLoss += (siteCommercialPricePerVisit * websiteVisits);
            }

            foreach (var website in websitesEfected)
            {
                Console.WriteLine(website);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");

        }
    }
}

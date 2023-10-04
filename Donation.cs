using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOFundraising
{
    internal class Donation
    {
        public string donorName;
        public double amount;

        public double calculateTransFee()
        {
            return amount * 0.01;
        }

        public string getCategory()
        {
            switch (amount)
            {
                case >= 100:
                    return "****";
                case >= 75:
                    return "***";
                case >= 50:
                    return "**";
                case >= 25:
                    return "*";
                default:
                    return "";
            }
        }

    }
}

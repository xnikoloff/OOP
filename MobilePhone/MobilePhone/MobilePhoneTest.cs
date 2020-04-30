using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    class MobilePhoneTest
    {
        private MobilePhone mph;

        public MobilePhoneTest()
        {
        }

        public static MobilePhone CreatePhone(string brand, string model, double price, string owner)
        {
            return new MobilePhone(brand, model, price, owner);
        }

        public void DoTest()
        {
            this.mph.PrintInfo();
        }
    }
}

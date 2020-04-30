using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    class MobilePhone
    {
        private string model;
        private string brand;
        private double price;
        private string owner;
        private List<Call> callHistory = new List<Call>();

        public MobilePhone()
            : this(default(String), default(String), default(Double))
        {

        }

        public MobilePhone(string model, string brand, double price)
            : this(model, brand, price, default(String))
        {

        }

        public MobilePhone(string model, string brand, double price, string owner)
        {
            this.model = model;
            this.brand = brand;
            this.price = price;
            this.owner = owner;
        }

        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public override string ToString()
        {
            return $"{this.brand}";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {this.brand}\nModel: {this.model}\nPrice: {this.price}\nOwner: {this.owner}");
        }

        public void MakeCall(string contact, int callStarted, int duration)
        {
            DateTime callTime = DateTime.Now;
            DateTime callStart = callTime.AddSeconds(callStarted);

            callHistory.Add(new Call(contact, DateTime.Now, callStart, duration));
        }

        public void ViewCallHistory()
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                callHistory[i].PrintCallInfo();
            }
        }

        private decimal TaxConversation(decimal callPrice)
        {
            double totalDuration = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalDuration += callHistory[i].CallDuration;
            }

            double totalDurationSeconds = totalDuration / 60;

            decimal sum = callPrice * (decimal)totalDurationSeconds;

            return sum;
        }

        public void GetSum(decimal callPrice)
        {
            decimal sum = TaxConversation(callPrice);

            Console.WriteLine($"The sum of the convesation is {sum}");
        }

        public void DeleteCall(int callIndex)
        {
            callHistory.RemoveAt(callIndex);
        }

        public void DeleteLongestCall()
        {
            int longest = int.MinValue;
            int bestLongest = int.MinValue;
            int removeIndex = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].CallDuration > longest)
                {
                    longest = callHistory[i].CallDuration;
                }

                if (bestLongest < longest)
                {
                    bestLongest = longest;
                    removeIndex = i;
                }
            }

            callHistory.RemoveAt(removeIndex);
        }

        public void ClearCallHistory()
        {
            for (int i = callHistory.Count - 1; i >= 0; i--)
            {
                callHistory.RemoveAt(i);
            }
        }
    }
}

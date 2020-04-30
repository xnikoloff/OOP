using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    class Call
    {
        //Fields
        private const int DefaultCallEntriesCount = 10;

        private string contact;
        private DateTime callTime;
        private DateTime callStart;
        private int callDuration;


        //Constructor
        public Call(string contact, DateTime callTime, DateTime callStat, int callDuration)
        {
            this.contact = contact;
            this.callTime = callTime;
            this.callStart = callStat;
            this.callDuration = callDuration;
        }

        //Properties

        public string Contact
        {
            get { return this.contact; }
            set { this.contact = value; }
        }

        public DateTime CallTime
        {
            get { return this.callTime; }
            set { this.callTime = value; }
        }

        public DateTime CallStart
        {
            get { return this.callStart; }
            set { this.callStart = value; }
        }

        public int CallDuration
        {
            get { return this.callDuration; }
            set { this.callDuration = value; }
        }

        public void PrintCallInfo()
        {
            Console.WriteLine($"Contact: {this.contact}, Time: {this.callTime}, Start: {this.callStart}, Duration: {this.callDuration}");
        }
    }
}

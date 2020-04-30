using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    enum Batteries
    {
        LiOn,
        NiMH,
        NiCd

    }
    class Battery
    {
        private string batteryModel;
        private int idleTime;
        private int talkTime;
        
        public Battery()
            : this(default(String), default(Int32), default(Int32))
        {

        }

        public Battery(string batteryModel)
            : this(batteryModel, default(Int32), default(Int32))
        {
        }

        public Battery(string batteryModel, int idleTime, int talkTime)
        {
            this.batteryModel = batteryModel;
            this.idleTime = idleTime;
            this.talkTime = talkTime;
        }

        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int IdleTime
        {
            get { return this.idleTime; }
            set { this.idleTime = value; }
        }

        public int TalkTime
        {
            get { return this.talkTime; }
            set { this.talkTime = value; }
        }
    }
}

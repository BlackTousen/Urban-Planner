using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {
        private string _designer = "Jerry";
        private DateTime _dateConstructed;

        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public string Address
        {
            get
            {
                return this._address;
            }
        }
        public string Owner
        {
            get
            {
                return this._owner;
            }
        }
        public string Designer
        {
            get
            {
                return this._designer;
            }
        }
        public DateTime Date
        {
            get
            {
                return this._dateConstructed;
            }
        }
        public double Volume
        {
            get
            {

                return Width * Depth * (Stories * 3);
            }
        }
        public Building(string address)
        {
            _address = address;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microgroove.Models
{
    public class Report
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public List<Order> Orders { get; set; }

        public static Report ConvertCSV(string csv)
        {
            var report = new Report();
            var rows = new List<List<string>>();



            throw new NotImplementedException();
        }
    }

    public class Order
    {
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public Buyer Buyer { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Buyer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
    }

    public class Item
    {
        public int SKU { get; set; }
        public int Quantity { get; set; }
    }

    public class Timings
    {
        public int Start { get; set; }
        public int Stop { get; set; }
        public int Gap { get; set; }
        public int Offset { get; set; }
        public int Pause { get; set; }
    }

    public class Ender
    {
        public int Process { get; set; }
        public int Paid { get; set; }
        public int Created { get; set; }
    }
}

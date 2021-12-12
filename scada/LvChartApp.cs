using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scada
{
    public class LvChartApp
    {
        public int id { get; set; }

        public int  Year { get; set; }

        public int Month { get; set; }

        public double KhoiLuong { get; set; }

        public LvChartApp() {  }

        public LvChartApp(int id, int year, int month, double khoiLuong) {
            this.id = id;
            this.Year = year;
            this.Month = month;
            this.KhoiLuong = khoiLuong;
        }
    }
}

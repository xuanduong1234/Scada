using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LiveCharts;
using LiveCharts.Wpf;

namespace scada
{
    public partial class Chart : Form
    {

        public Chart()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-PQ44GPT\SQLEXPRESS;Initial Catalog=SCADA;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from TongKhoiLuong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void Chart_Load(object sender, EventArgs e)
        {
            
             connection = new SqlConnection(str);
             connection.Open();
             LoadData();     

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {                
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "TongKhoiLuong",
                LabelFormatter = value => value.ToString("0")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
            this.btnLoad_Click(sender, e);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            List<LvChartApp> items = new List<LvChartApp>();
            int index = 0;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                index++;
                if (index < dataGridView1.Rows.Count)
                {
                    items.Add(new LvChartApp(Convert.ToInt32(dr.Cells[0].Value),
                    Convert.ToInt32(dr.Cells[1].Value), Convert.ToInt32(dr.Cells[2].Value),
                    Convert.ToDouble(dr.Cells[3].Value)));                   
                }
            }

            var years = (from o in items
                         select new { Year = o.Year }).Distinct();
            foreach(var year in years)
            {
                List<double> values = new List<double>();
                for(int month = 1; month < 12; month++)
                {
                    double value = 0;
                    var data = from o in items
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.KhoiLuong, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().KhoiLuong;
                    values.Add(value);

                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;

           

        }
    }
    
}

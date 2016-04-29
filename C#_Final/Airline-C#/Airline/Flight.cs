using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Flight : Form
    {
        string fno;

        public Flight(string _fno)
        {
            InitializeComponent();
            fno = _fno;
        }

        // bind data for datagridview
        private void Flight_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“airlineDataSet.BookDetail”中。您可以根据需要移动或删除它。
            this.bookDetailTableAdapter.Fill(this.airlineDataSet.BookDetail);
            this.flightCarrierTableAdapter.Fill(this.airlineDataSet.FlightCarrier);
            this.crewTableAdapter.Fill(this.airlineDataSet.Crew);
            this.flightCarrierBindingSource.Filter = "FlightNo='" + fno + "'";
            this.bookDetailBindingSource.Filter = "FlightNo='" + fno + "'";
            this.crewBindingSource.Filter = "FlightNo='" + fno + "'";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime min = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime max = new DateTime(DateTime.Now.Year, 12, 31);
            if(vScrollBar2.Value > vScrollBar1.Value)
            {
                vScrollBar2.Value = vScrollBar1.Value;
            }
            min = min.AddYears(vScrollBar2.Value - vScrollBar2.Maximum);
            max = max.AddYears(vScrollBar1.Value - vScrollBar1.Maximum);
            dateTimePicker1.MinDate = min;
            dateTimePicker1.MaxDate = max;
            label6.Text = vScrollBar1.Value.ToString();
            label7.Text = vScrollBar2.Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            DateTime min = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime max = new DateTime(DateTime.Now.Year, 12, 31);
            if (vScrollBar2.Value > vScrollBar1.Value)
            {
                vScrollBar1.Value = vScrollBar2.Value;
            }
            min = min.AddYears(vScrollBar2.Value - vScrollBar2.Maximum);
            max = max.AddYears(vScrollBar1.Value - vScrollBar1.Maximum);
            dateTimePicker1.MaxDate = max;
            dateTimePicker1.MinDate = min;
            label6.Text = vScrollBar1.Value.ToString();
            label7.Text = vScrollBar2.Value.ToString();
        }
    }
}

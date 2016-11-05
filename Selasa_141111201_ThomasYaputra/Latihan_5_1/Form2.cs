using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;


namespace Latihan_5_1
{
    public partial class Form2 : Form
    {
        Form1 main = (Form1)Form1.ActiveForm;

        public Form2()
        {
            InitializeComponent();
            Color warna = new Color();
            PropertyInfo[] p = warna.GetType().GetProperties();

            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo c in p)
            {
                if (c.PropertyType == typeof(System.Drawing.Color))
                {
                    comboBox1.Items.Add(c.Name);
                }
            }

            this.comboBox1.DrawItem += new DrawItemEventHandler(cbBackColor_DItem);
        }

        private void cbBackColor_DItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.comboBox1.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            comboBox1.Text = main.rtbBackColor;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Background Color")
                panel1.Visible = true;
            else
                panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.rtbBackColor = comboBox1.Text;
            this.Dispose();
            main.tampilRTB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main.tampilRTB();
        }

        private void frmEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            main.tampilRTB();
        }
    }
}

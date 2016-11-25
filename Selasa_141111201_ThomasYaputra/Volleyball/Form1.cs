using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long fak(long a, long mod)
        {
            long res = 1;
            for (int i = 1; i <= a; i++)
            {
                res *= i;
                res %= mod;
            }
            return res;
        }

        private void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }

        private bool cek(long a, long b)
        {
            if ((a == 24 && b == 25) || (a == 25 && b == 24) || (a < 25 && b < 25) || (a == b) || ((a > 25 || b > 25) && Math.Abs(a - b) != 2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private long mul_inv(long a, long b)
        {
            long b0 = b, t, q;
            long x0 = 0, x1 = 1;
            if (b == 1) return 1;
            while (a > 1)
            {
                q = a / b;
                t = b;
                b = a % b;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }
            if (x1 < 0) x1 += b0;
            return x1;
        }

        private long powermod(long b, long e, long mod)
        {
            if (b < 1 || e < 0 || mod < 1)
                return -1;

            long result = 1;
            while (e > 0)
            {
                if ((e % 2) == 1)
                {
                    result = (result * b) % mod;
                }
                b = (b * b) % mod;
                e = e / 2;
            }
            return result;
        }

        private long nCr(long a, long b, long mod)
        {
            if (a < b) return 0;
            long hsl = 1;
            hsl *= fak(a, mod);
            hsl %= mod;
            hsl *= mul_inv(fak(a - b, mod), mod);
            hsl %= mod;
            hsl *= mul_inv(fak(b, mod), mod);
            hsl %= mod;
            return hsl;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long a, b, mod;
            mod = 1000000007;

            try
            {
                a = Convert.ToInt64(Txt1.Text);
                b = Convert.ToInt64(Txt2.Text);

                if (a > b) Swap(ref a, ref b);

                if (!cek(a, b))
                {
                    TxtHasil.Text = "0";
                    return;
                }

                long res;
                res = nCr(Math.Min(a + b - 1, 47), Math.Min(b - 1, 24), mod);
                res *= powermod(2, b - 25, mod);
                res %= mod;
                TxtHasil.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "Error");
            }
        }
    }
}

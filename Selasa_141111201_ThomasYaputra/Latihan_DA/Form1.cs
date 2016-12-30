using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_DA
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter customerDA;
        // DataSet ds;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string myConnectionString = "Server=localhost;Database=testing;Uid=root;Pwd=;";
            conn = new MySqlConnection(myConnectionString);
            conn.Open();
            // ds = new DataSet();
            dt = new DataTable();
            initializeDA();
            customerDA.SelectCommand.ExecuteScalar();
            // customerDA.Fill(ds, "customer");
            customerDA.Fill(dt);
            dgvDaftar.ReadOnly = true;
            dgvDaftar.AllowUserToAddRows = false;
            dgvDaftar.AllowUserToDeleteRows = false;
            dgvDaftar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingSource bs = new BindingSource();
            // bs.DataSource = ds.Tables["customer"];
            bs.DataSource = dt;
            dgvDaftar.DataSource = bs;
            // dgvDaftar.DataSource = ds.Tables["customer"];
        }

        private void initializeDA()
        {
            customerDA = new MySqlDataAdapter();

            // SELECT
            string customerSelectSql = String.Concat("SELECT * FROM customer");
            customerDA.SelectCommand = new MySqlCommand(customerSelectSql, conn);

            // INSERT
            string customerInsertSql = String.Concat("INSERT INTO customer (name, address, zip_code, phone_number, email,created_at) VALUES (@name, @address, @zip_code, @phone_number, @email,@created_at)");
            /*string sql = "INSERT into customer (name,address,zip_code,phone_number,email,create_at,update_at)";
            sql += "VALUES(@name,@address,@zip_code,@phone_number,@email)";*/
            MySqlCommand customerInsertCommand = new MySqlCommand(customerInsertSql, conn);

            customerInsertCommand.Parameters.AddWithValue("@name", txName.Text);
            customerInsertCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerInsertCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerInsertCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerInsertCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerInsertCommand.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            // customerInsertCommand.Parameters.AddWithValue("@updated_at", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            customerDA.InsertCommand = customerInsertCommand;
            //MessageBox.Show(sql);


            // UPDATE
            string customerUpdateSql = String.Concat("UPDATE customer SET name = @name, address = @address, zip_code = @zip_code, phone_number = @phone_number, email = @email WHERE id = @id");
            MySqlCommand customerUpdateCommand = new MySqlCommand(customerUpdateSql, conn);
            customerUpdateCommand.Parameters.AddWithValue("@id", txId.Text);
            customerUpdateCommand.Parameters.AddWithValue("@name", txName.Text);
            customerUpdateCommand.Parameters.AddWithValue("@address", txAddress.Text);
            customerUpdateCommand.Parameters.AddWithValue("@zip_code", txZipCode.Text);
            customerUpdateCommand.Parameters.AddWithValue("@phone_number", txPhoneNumber.Text);
            customerUpdateCommand.Parameters.AddWithValue("@email", txEmail.Text);
            customerDA.UpdateCommand = customerUpdateCommand;

            // delete


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initializeDA();
            string pesan = "";
            if (txId.Text == "")
            {
                pesan = String.Concat(customerDA.InsertCommand.ExecuteNonQuery(), " Record succesfully saved.");

                // MessageBox.Show(pesan);
            }
            else
            {
                pesan = String.Concat(customerDA.UpdateCommand.ExecuteNonQuery(), " Record succesfully updated.");
            }
            MessageBox.Show(pesan, "Save Information");
            customerDA.SelectCommand.ExecuteScalar();
            dt.Clear();
            customerDA.Fill(dt);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvDaftar.SelectedRows.Count > 0)
            {
                string customerDeleteSql = String.Concat("DELETE FROM customer WHERE ID= @id");
                MySqlCommand customerDeleteCommand = new MySqlCommand(customerDeleteSql, conn);
                customerDeleteCommand.Parameters.AddWithValue("@id", Convert.ToString(dgvDaftar.SelectedCells[0].Value));
                customerDeleteCommand.ExecuteNonQuery();
                customerDA.SelectCommand.ExecuteScalar();
                dt.Clear();
                customerDA.Fill(dt);
            }
            else
            {
                MessageBox.Show("Nothing to Delete !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

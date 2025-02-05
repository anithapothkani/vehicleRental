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

namespace vehicle_rental
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            Autono();
            customerload();


        }




        SqlConnection con = new SqlConnection(" Data Source=Anitha\\SQLEXPRESS;Initial Catalog=vehclerent;User ID=sa;Password=anuhoney;Encrypt=False ");

        SqlCommand cmd;
        SqlDataReader dr;
        string proid;
        string sql;
        bool mode = true;
        string id;


        public void Autono()
        {

            sql = "select custid from customer order by  custid desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if ((dr.Read()))
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                proid = id.ToString("00000");

            }
            else if (Convert.IsDBNull(dr))
            {
                proid = ("00001");


            }
            else
            {
                proid = ("00001");

            }

            txtid.Text = proid.ToString();

            con.Close();

        }

        public void customerload()
        {

            sql = " select * from customer";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

            }
            con.Close();


        }





        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string custname = txtname.Text;
            string address = txtaddress.Text;
            string mobile = txtmobile.Text;


           // id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (mode == true)
            {
                sql = "insert into customer(custid,custname,address,mobile)values(@custid,@custname,@address,@mobile)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@custid", id);
                cmd.Parameters.AddWithValue("@custname", custname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record addeddd");


               txtname.Clear();
                txtaddress.Clear();
                txtmobile.Clear();
                txtname.Focus();
                Autono();


            }
            else
            {

                sql = "update customer set make=@make,model=@model,available=@available where regno = @regno";
                con.Open();
                cmd = new SqlCommand(sql, con);

              //  cmd.Parameters.AddWithValue("@make", make);
                //cmd.Parameters.AddWithValue("@model", model);
                //cmd.Parameters.AddWithValue("@available", available);
                //cmd.Parameters.AddWithValue("@regno", id);



                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated");
                //txtregno.Enabled = true;
                mode = true;

                //txtmake.Clear();
                //txtmodel.Clear();
                //txtavl.Items.Clear();
                //txtmake.Focus();







            }
            con.Close();








        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}

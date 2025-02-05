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
    public partial class rental : Form
    {
        public rental()
        {
            InitializeComponent();
            carload();
            rentalload();

        }


        SqlConnection con = new SqlConnection(" Data Source=Anitha\\SQLEXPRESS;Initial Catalog=vehclerent;User ID=sa;Password=anuhoney;Encrypt=False ");

        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader dr;
        string proid;
        string sql;
        string sql2;
        bool mode = true;
        string id;



        public void carload()
        {
            cmd = new SqlCommand(" select * from vehclereg ", con);
            con.Open();
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                txtcarid.Items.Add(dr["regno"].ToString());
            }
            con.Close();

        }
        public void rentalload()
        {

            sql = " select * from rental";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);

            }
            con.Close();

        }


        private void rental_Load(object sender, EventArgs e)
        {

        }

        private void txtcarid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand(" select * from vehclereg where regno = '" + txtcarid.Text + "' ", con);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                string aval;

                aval = dr["available"].ToString();
                label9.Text = aval;

                if (aval == "No")
                {

                    txtcustid.Enabled = false;
                    txtcustname.Enabled = false;

                    txtrentalfee.Enabled = false;
                    txtdate.Enabled = false;
                    txtduedate.Enabled = false;

                }
                else
                {
                    txtcustid.Enabled = true;
                    txtcustname.Enabled = true;


                    txtrentalfee.Enabled = true;
                    txtdate.Enabled = true;
                    txtduedate.Enabled = true;




                }




            }

            else
            {

                label9.Text = "car not available";
            }

            con.Close();





        }

        private void txtcustid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                cmd = new SqlCommand(" select * from customer where custid = '" + txtcustid.Text + "' ", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    txtcustname.Text = dr["custname"].ToString();

                }
                else
                {

                    MessageBox.Show(" customer ID not Found  ");
                }

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carid = txtcarid.SelectedItem.ToString();
            string custid = txtcustid.Text;
            string custname = txtcustname.Text;
            string fee = txtrentalfee.Text;
            string date = txtdate.Value.Date.ToString("yyyy-MM-dd");
            string due = txtduedate.Value.Date.ToString("yyyy-MM-dd");


            sql = "insert into rental (carid,custid,custname,fee,date,due)values(@carid,@custid,@custname,@fee,@date,@due)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@carid", carid);
            cmd.Parameters.AddWithValue("@custid", custid);
            cmd.Parameters.AddWithValue("@custname", custname);
            cmd.Parameters.AddWithValue("@fee", fee);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@due", due);

            cmd.ExecuteNonQuery();


            sql2 = "  update vehclereg set available = 'No' where regno = @regno";

            cmd2 = new SqlCommand(sql2, con);
            cmd2.Parameters.AddWithValue("@regno", carid);
            cmd2.ExecuteNonQuery();

            MessageBox.Show("record addeddd");
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

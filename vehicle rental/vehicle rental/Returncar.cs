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
    public partial class Returncar : Form
    {
        public Returncar()
        {
            InitializeComponent();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmd = new SqlCommand(" select  carid,custid,date,due,DATEDIFF(dd,due,GETDATE()) as elap from rental where carid = '" + txtcarid.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    txtcustid.Text = dr["custid"].ToString();
                    txtdate.Text = dr["due"].ToString();

                    string elap = dr["elap"].ToString();

                    int elapped = int.Parse(elap);
                    txtdueElapsed.Text = (elap);


                    if (elapped > 0)
                    {

                        int fine = elapped * 100;

                        txtFine.Text = fine.ToString();

                    }
                    else
                    {
                        txtFine.Text = "0";
                        txtFine.Text = "0";


                    }

                    con.Close();



                }


            }
        }

        private void Returncar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string carid = txtcarid.Text;
            string custid = txtcustid.Text;
            string date = txtdate.Text;
            string elp = txtdueElapsed.Text;
            string fine = txtFine.Text;






            if (mode == true)
            {
                sql = "insert into returncar(carid,custid,date,elp,fine)values(@carid,@custid,@date,@elp,@fine)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@carid", carid);
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@elp", elp);
                cmd.Parameters.AddWithValue("@fine", fine);



                cmd.ExecuteNonQuery();
                MessageBox.Show("record addeddd");


            }
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       
        
        {





            }
    }
}
     
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
    public partial class Vehiclereg : Form
    {
        public Vehiclereg()
        {
            InitializeComponent();

            Autono();
            load();

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

            sql = "select regno from vehclereg order by  regno desc";
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
                proid = ("00000");


            }
            else
            {
                proid = ("00000");

            }

            txtregno.Text = proid.ToString();

            con.Close();

        }
        public void load()
        {

            sql = " select * from vehclereg";
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

        public void getid(string num)
        {
            sql = "select * from vehclereg where regno = '" + num + "'   ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtregno.Text = dr[0].ToString();
                txtmake.Text = dr[1].ToString();
                txtmodel.Text = dr[2].ToString();
                txtavl.Text = dr[3].ToString();

            }
            con.Close();

        }




        private void Vehiclereg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string regno = txtregno.Text;
            string make = txtmake.Text;
            string model = txtmodel.Text;
            string available = txtavl.SelectedItem.ToString();
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (mode == true)
            {
                sql = "insert into vehclereg (regno,make,model,available)values(@regno,@make,@model,@available)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@regno", regno);
                cmd.Parameters.AddWithValue("@make", make);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@available", available);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record addeddd");

                txtmake.Clear();
                txtmodel.Clear();
                txtavl.Items.Clear();
                txtmake.Focus();
                Autono();


            }
            else
            {

                sql = "update vehclereg set make=@make,model=@model,available=@available where regno = @regno";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@make", make);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@available", available);
                cmd.Parameters.AddWithValue("@regno", id);



                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated");
                txtregno.Enabled = true;
                mode = true;

                txtmake.Clear();
                txtmodel.Clear();
                txtavl.Items.Clear();
                txtmake.Focus();







            }
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {

                mode = false;

                txtregno.Enabled = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getid(id);

            }

            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = " delete from vehclereg where regno = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("record deleteeeee");
                con.Close();

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
            Autono();

            txtmake.Clear();
            txtmodel.Clear();
            txtavl.Items.Clear();
            txtmake.Focus();
            Autono();





        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

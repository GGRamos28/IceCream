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

namespace Ice_Cream
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader leituradados;

        string image;
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login telalog = new Login();
            this.Hide();
            telalog.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost ; database=bd_proj_sorv ; user id=root ; password=";

            con.Open();

            banner1.Image = Properties.Resources.WhatsApp_Image_2020_08_05_at_19_51_25;
        }

        private void btpesq_Click(object sender, EventArgs e)
        {
            string sqlreg = " select * from tb_produtos where id_prod = " + txtpesq.Text;

            /*  select * from tb_produtos where id_prod = 1;
            */

            Console.WriteLine(sqlreg);
            comando = new MySqlCommand(sqlreg, con);

            leituradados = comando.ExecuteReader();


            if (leituradados.HasRows)
            {
                leituradados.Read();

                lblnota.Text = leituradados["nota_prod"].ToString();
                lblnome.Text = leituradados["nome_prod"].ToString();
                lblmarca.Text = leituradados["marca_prod"].ToString();
                lbling.Text = leituradados["ingred_prod"].ToString();
                lbldesc.Text = leituradados["desc_prod"].ToString();
            }
            else
            {
                MessageBox.Show("Sorvete não encontrado", "Mr. Ice Cream");

            }
            leituradados.Close();

            con.Close();
        }

        private void banner1_Click(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                banner1.Image = Properties.Resources.WhatsApp_Image_2020_08_05_at_19_51_25__1_;
            }
            if (cont == 1)
            {
                banner1.Image = Properties.Resources.WhatsApp_Image_2020_08_05_at_19_51_25__2_;
            }
            if (cont == 2)
            {
                banner1.Image = Properties.Resources.WhatsApp_Image_2020_08_05_at_19_51_25;
            }
            if (cont == 2)
            {
                cont = 0;
            }
            else { cont += 1; }
        }
    }
}

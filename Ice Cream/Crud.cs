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
    public partial class Crud : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand comando = new MySqlCommand();
        MySqlDataReader leituradados;

        public Crud()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Crud_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost ; database=bd_proj_sorv ; user id=root ; password=";

            con.Open();
        }

        private void bttpesq_Click(object sender, EventArgs e)
        {
            string sqlreg = " select * from tb_produtos where id_prod = " + txtpesq.Text;

            comando = new MySqlCommand(sqlreg, con);

            leituradados = comando.ExecuteReader();

            if (leituradados.HasRows)
            {
                leituradados.Read();

                txtnota.Text = leituradados["nota_prod"].ToString();
                txtnome.Text = leituradados["nome_prod"].ToString();
                txtmarca.Text = leituradados["marca_prod"].ToString();
                txting.Text = leituradados["ingred_prod"].ToString();
                txtdesc.Text = leituradados["desc_prod"].ToString();
                
                // quando vc armazena na propriapasta do projeto
                //pictureBox1.Image = Properties.Resources.brigadeiro;


                Image  caiminhoImagem = Image.FromFile(@"C:\Users\EMERSON ROCHA\Downloads\Ice Cream-20200818T164111Z-001\Ice Cream\Ice Cream\Resources\" + leituradados["foto_prod"].ToString().ToLower());

                pictureBox1.Image =caiminhoImagem;
               // MessageBox.Show(leituradados["foto_prod"].ToString());
            }
            else
            {
                MessageBox.Show("Sorvete não encontrado", "Mr. Ice Cream");
            }

            leituradados.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdesc.Clear();
            txting.Clear();
            txtmarca.Clear();
            txtnome.Clear();
            txtnota.Clear();
            txtpesq.Clear();
        }

        private void Crud_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 vol = new Form1();
            this.Hide();
            vol.ShowDialog();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlUpdate = " Update tb_produtos " +
                     " set nome_prod = '" + txtnome.Text + "' , " +
                     " nota_prod = '" + txtnota.Text + "' , " +
                     " marca_prod = '" + txtmarca.Text + "' , " +
                     " desc_prod = '" + txtdesc.Text + "' , " +
                     " ingred_prod = '" + txting.Text + "'  " +
                     " where id_prod= " + txtpesq.Text;


                 /* 
                  * Erro no sintaxe do sql
                  * 
                  * string sqlUpdate = " Update tb_produto " +
                     " set nome_prod = '" + txtnome.Text + "' , " +
                     " nota_prod = '" + txtnota.Text + "' , " +
                     " marca_prod = '" + txtmarca.Text + "' , " +
                     " desc_prod = '" + txtdesc.Text + "' , " +
                     " ingred_prod = " + txting.Text + "'  " +
                     " where id_prod= " + txtpesqt;

    */

           
           comando = new MySqlCommand(sqlUpdate, con);

            int afetadolinha = comando.ExecuteNonQuery();

            int id_cli = int.Parse(txtpesq.Text);

            if (afetadolinha > 0)
            {
                MessageBox.Show("SD");

                if (txtnome.Text != string.Empty)
                {
                    /*

                    string sqllogin = " Update tb_login " +
                                        " set nome_prod = '" + txtnome.Text + "' , " +
                                        " nota_prod = '" + txtnota.Text + "' , " +
                     " marca_prod = '" + txtmarca.Text + "' , " +
                     " desc_prod = '" + txtdesc.Text + "' , " +
                     " ingred_prod = " + txting.Text + "' , " +
                     " where id_prod= " + txtpesq.Text;

                    comando = new MySqlCommand(sqllogin, con);

                    comando.ExecuteNonQuery();
                    */

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqldelete = " Delete from tb_produtos " +
                               " where id_prod= " + txtpesq.Text;

            Console.WriteLine(sqldelete);


            if (txtnome.Text != String.Empty)
            {

                string sqllogin = " Delete from tb_produtos " +
                   " where id_prod = " + txtpesq.Text;

                comando = new MySqlCommand(sqllogin, con);

                comando.ExecuteNonQuery();
            }


            comando = new MySqlCommand(sqldelete, con);



            int linhacliente = comando.ExecuteNonQuery();



            if (linhacliente > 0)
            {


                MessageBox.Show("Registro apagado com sucesso!", "Mr. Ice Cream");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string SQLInsert = " insert into tb_cliente(nome_prod, desc_prod, nota_prod, marca_prod, ingred_prod) ";
            SQLInsert += " values('" + txtnome.Text + "' , '" + txtdesc.Text + "' , '" + txtnota.Text + "' , '" + txtmarca.Text + "' , '" + txting.Text + ") ";

            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                txtnome.Focus();
                MessageBox.Show("Preencha o campo Nome!", "Mr. Ice Cream");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdesc.Text))
            {
                txtdesc.Focus();
                MessageBox.Show("Preencha o campo descrição!", "Mr. Ice Cream");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnota.Text))
            {
                txtnota.Focus();
                MessageBox.Show("Preencha o campo nota!", "Mr. Ice Cream");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtmarca.Text))
            {
                txtmarca.Focus();
                MessageBox.Show("Preencha o campo marca!", "Mr. Ice Cream");
                return;
            }
            if (string.IsNullOrWhiteSpace(txting.Text))
            {
                txting.Focus();
                MessageBox.Show("Preencha o campo ingrediente!", "Mr. Ice Cream");
                return;
            }

            comando = new MySqlCommand(SQLInsert, con);

            

           

            con.Close();

        }
    }
}

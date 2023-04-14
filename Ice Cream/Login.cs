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
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand comando;
        MySqlDataReader leituradados;
        string sqllogin;
        public Login()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            this.Hide();
            voltar.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost ; database=bd_proj_sorv ; user id=root ; Password=";

            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlogin.Text))
            {
                MessageBox.Show("Campo login obrigatório", "Mr. Ice Cream", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtlogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtsenha.Text))
            {
                MessageBox.Show("Campo senha obrigatório", "Mr. Ice Cream", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtsenha.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtlogin.Text) && !string.IsNullOrWhiteSpace(txtsenha.Text))
            {
                sqllogin = " Select * from tb_adm ";
                sqllogin += " Where login_adm = '" + txtlogin.Text + "' ";
                sqllogin += " and senha_adm = '" + txtsenha.Text + "' ";

                comando = new MySqlCommand(sqllogin, con);

                leituradados = comando.ExecuteReader();

                if (leituradados.HasRows)
                {
                    MessageBox.Show("Acesso permitido", "Mr. Ice Cream");

                    Crud cu = new Crud();
                    this.Hide();
                    cu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado", "Mr. Ice Cream");
                }

                leituradados.Close();
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ice_Cream
{
    public partial class Avaliacao : Form
    {
        public Avaliacao()
        {
            InitializeComponent();
        }

        private void Avaliacao_Load(object sender, EventArgs e)
        {
            Form1 ola = new Form1();
            
        }

        private void label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login telalog = new Login();
            this.Hide();
            telalog.ShowDialog();
        }
    }
}

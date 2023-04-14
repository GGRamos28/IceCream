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
    public partial class Load : Form
    {
        Timer frm = new Timer();
        Timer dl = new Timer();

        public Load()
        {
            InitializeComponent();

            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            this.frm.Interval = 600;
            this.frm.Enabled = true;
            this.frm.Tick += Frm_Tick; ;

            this.dl.Enabled = true;
            this.dl.Interval = 3000;
        }

        private void Frm_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                frm.Stop();

                dl.Start();
                dl.Tick += Dl_Tick; ;
            }
        }

        private void Dl_Tick(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            dl.Stop();
            menu.ShowDialog();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            this.frm.Start();
        }
    }
}

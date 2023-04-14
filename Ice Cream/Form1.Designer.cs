namespace Ice_Cream
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.login = new System.Windows.Forms.LinkLabel();
            this.txtpesq = new System.Windows.Forms.TextBox();
            this.btpesq = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.lbling = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.ptcfoto = new System.Windows.Forms.PictureBox();
            this.banner1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptcfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.Location = new System.Drawing.Point(-23, -4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1020, 40);
            this.progressBar1.TabIndex = 0;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login.Location = new System.Drawing.Point(674, 9);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 6;
            this.login.TabStop = true;
            this.login.Text = "Login";
            this.login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_LinkClicked);
            // 
            // txtpesq
            // 
            this.txtpesq.AccessibleName = "";
            this.txtpesq.Location = new System.Drawing.Point(177, 7);
            this.txtpesq.Name = "txtpesq";
            this.txtpesq.Size = new System.Drawing.Size(372, 20);
            this.txtpesq.TabIndex = 10;
            this.txtpesq.Tag = "";
            // 
            // btpesq
            // 
            this.btpesq.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btpesq.Location = new System.Drawing.Point(555, 7);
            this.btpesq.Name = "btpesq";
            this.btpesq.Size = new System.Drawing.Size(42, 21);
            this.btpesq.TabIndex = 11;
            this.btpesq.Text = "Pesq";
            this.btpesq.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btpesq.UseVisualStyleBackColor = true;
            this.btpesq.Click += new System.EventHandler(this.btpesq_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(248, 313);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(0, 15);
            this.lblnome.TabIndex = 13;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(248, 382);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(0, 13);
            this.lbldesc.TabIndex = 14;
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(424, 313);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(0, 13);
            this.lblnota.TabIndex = 15;
            // 
            // lbling
            // 
            this.lbling.AutoSize = true;
            this.lbling.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbling.Location = new System.Drawing.Point(248, 419);
            this.lbling.Name = "lbling";
            this.lbling.Size = new System.Drawing.Size(0, 13);
            this.lbling.TabIndex = 16;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(248, 348);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(0, 13);
            this.lblmarca.TabIndex = 17;
            // 
            // ptcfoto
            // 
            this.ptcfoto.Location = new System.Drawing.Point(12, 310);
            this.ptcfoto.Name = "ptcfoto";
            this.ptcfoto.Size = new System.Drawing.Size(206, 181);
            this.ptcfoto.TabIndex = 12;
            this.ptcfoto.TabStop = false;
            // 
            // banner1
            // 
            this.banner1.Image = global::Ice_Cream.Properties.Resources.WhatsApp_Image_2020_08_05_at_19_51_25;
            this.banner1.InitialImage = ((System.Drawing.Image)(resources.GetObject("banner1.InitialImage")));
            this.banner1.Location = new System.Drawing.Point(12, 49);
            this.banner1.Name = "banner1";
            this.banner1.Size = new System.Drawing.Size(694, 255);
            this.banner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner1.TabIndex = 9;
            this.banner1.TabStop = false;
            this.banner1.Click += new System.EventHandler(this.banner1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(105, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lbling);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.ptcfoto);
            this.Controls.Add(this.btpesq);
            this.Controls.Add(this.txtpesq);
            this.Controls.Add(this.banner1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel login;
        private System.Windows.Forms.PictureBox banner1;
        private System.Windows.Forms.TextBox txtpesq;
        protected System.Windows.Forms.Button btpesq;
        private System.Windows.Forms.PictureBox ptcfoto;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.Label lbling;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label label1;
    }
}


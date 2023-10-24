namespace MercadoPagoPix
{
    partial class frmRecebimentoPix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecebimentoPix));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblAguardandoPag = new Label();
            lblSegundos = new Label();
            lblAbre = new Label();
            lblFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 678);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(143, 240);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblAguardandoPag
            // 
            lblAguardandoPag.BackColor = Color.Transparent;
            lblAguardandoPag.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAguardandoPag.ForeColor = Color.Red;
            lblAguardandoPag.Location = new Point(60, 532);
            lblAguardandoPag.Name = "lblAguardandoPag";
            lblAguardandoPag.Size = new Size(239, 70);
            lblAguardandoPag.TabIndex = 2;
            lblAguardandoPag.Text = "Aguardando pagamento: ";
            lblAguardandoPag.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSegundos
            // 
            lblSegundos.Anchor = AnchorStyles.Right;
            lblSegundos.AutoSize = true;
            lblSegundos.BackColor = Color.Transparent;
            lblSegundos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundos.ForeColor = Color.Red;
            lblSegundos.Location = new Point(34, 12);
            lblSegundos.Name = "lblSegundos";
            lblSegundos.Size = new Size(23, 25);
            lblSegundos.TabIndex = 3;
            lblSegundos.Text = "0";
            // 
            // lblAbre
            // 
            lblAbre.Anchor = AnchorStyles.Right;
            lblAbre.AutoSize = true;
            lblAbre.BackColor = Color.Transparent;
            lblAbre.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAbre.ForeColor = Color.Red;
            lblAbre.Location = new Point(-5, 4);
            lblAbre.Name = "lblAbre";
            lblAbre.Size = new Size(48, 37);
            lblAbre.TabIndex = 4;
            lblAbre.Text = "(...";
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.Red;
            lblFecha.Location = new Point(60, 4);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(27, 37);
            lblFecha.TabIndex = 5;
            lblFecha.Text = ")";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(lblSegundos);
            panel1.Controls.Add(lblAbre);
            panel1.Controls.Add(lblFecha);
            panel1.Location = new Point(302, 543);
            panel1.Name = "panel1";
            panel1.Size = new Size(86, 50);
            panel1.TabIndex = 6;
            // 
            // frmRecebimentoPix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(486, 679);
            Controls.Add(lblAguardandoPag);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "frmRecebimentoPix";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recebimento Pix";
            Load += frmRecebimentoPix_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblAguardandoPag;
        private Label lblSegundos;
        private Label lblAbre;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel1;
    }
}

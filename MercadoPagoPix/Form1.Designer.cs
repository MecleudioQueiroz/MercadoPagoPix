namespace MercadoPagoPix
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCobranca = new Button();
            txtQrcode = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCobranca
            // 
            btnCobranca.Location = new Point(32, 367);
            btnCobranca.Name = "btnCobranca";
            btnCobranca.Size = new Size(117, 51);
            btnCobranca.TabIndex = 0;
            btnCobranca.Text = "Criar Cobrança";
            btnCobranca.UseVisualStyleBackColor = true;
            btnCobranca.Click += btnCobranca_Click;
            // 
            // txtQrcode
            // 
            txtQrcode.Location = new Point(354, 12);
            txtQrcode.Multiline = true;
            txtQrcode.Name = "txtQrcode";
            txtQrcode.Size = new Size(423, 426);
            txtQrcode.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtQrcode);
            Controls.Add(btnCobranca);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCobranca;
        private TextBox txtQrcode;
        private PictureBox pictureBox1;
    }
}

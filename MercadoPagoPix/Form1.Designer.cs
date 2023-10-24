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
            SuspendLayout();
            // 
            // btnCobranca
            // 
            btnCobranca.Location = new Point(325, 183);
            btnCobranca.Name = "btnCobranca";
            btnCobranca.Size = new Size(117, 51);
            btnCobranca.TabIndex = 0;
            btnCobranca.Text = "Criar Cobrança";
            btnCobranca.UseVisualStyleBackColor = true;
            btnCobranca.Click += btnCobranca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCobranca);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCobranca;
    }
}

using MercadoPago.Client.Payment;
using MercadoPago.Resource.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MercadoPagoPix
{
    public partial class frmRecebimentoPix : Form
    {
        MemoryStream ms;
        Payment _payment;
        PaymentClient _cliente;
        int segundos = 0;
        public frmRecebimentoPix(MemoryStream _ms, Payment payment, PaymentClient cliente)
        {
            InitializeComponent();
            ms = _ms;
            _payment = payment;
            _cliente = cliente;
            pictureBox2.Image = Image.FromStream(ms);
            Status();
        }
        private void frmRecebimentoPix_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblSegundos.Text = segundos.ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblSegundos.Text = segundos.ToString();
            if (segundos > 7)
            {
                this.Close();
            }
        }
        public async void Status()
        {
            long id = (long)_payment.Id;
            var cli = await _cliente.GetAsync(id);

            while (cli.Status == "pending")
            {
                cli = await _cliente.GetAsync(id);
            }
            lblSegundos.ForeColor = Color.Green;
            lblAbre.ForeColor = Color.Green;
            lblFecha.ForeColor = Color.Green;
            lblAguardandoPag.ForeColor = Color.Green;
            lblAguardandoPag.Text = "Pagamento recebido com sucesso!";
            timer1.Enabled = false;
            segundos = 0;
            timer2.Enabled = true;
        }
    }
}

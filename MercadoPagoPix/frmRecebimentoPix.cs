using MercadoPago.Client.Payment;
using MercadoPago.Resource.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public frmRecebimentoPix(MemoryStream _ms, Payment payment, PaymentClient cliente)
        {
            InitializeComponent();
            ms = _ms;
            _payment = payment;
            _cliente = cliente;
            pictureBox2.Image = Image.FromStream(ms);
            Status();
        }

        public async void Status()
        {
            long id = (long)_payment.Id;
            var cli = await _cliente.GetAsync(id);

            while (cli.Status == "pending")
            {
                cli = await _cliente.GetAsync(id);
            }

            cli.

           // MessageBox.Show("Pagamento Aprovado com sucesso!", "Aviso");
            this.Close();
        }
    }
}

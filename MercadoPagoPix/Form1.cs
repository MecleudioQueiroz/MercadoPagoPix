using MercadoPago.Config;
using MercadoPago.Client.Common;
using MercadoPago.Client.Payment;
using MercadoPago.Resource.Payment;
using MercadoPago.Client;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Imaging;

namespace MercadoPagoPix
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Payment payment;
        PaymentClient cliente = new PaymentClient();
        decimal valor = 0.03M;
        public async void MercadoPago()
        {
            //MercadoPagoConfig.AccessToken = "APP_USR-1720662152161752-090102-3cb06a9b706e27e712b387bf37108af3-111665071";
            MercadoPagoConfig.AccessToken = "TEST-1720662152161752-090102-822b8698386e6902f87b84fabc54080a-111665071";
            var request = new PaymentCreateRequest
            {
                TransactionAmount = valor,
                Description = "Produto Teste",
                PaymentMethodId = "pix",
                
                Payer = new PaymentPayerRequest
                {
                    Email = "suporte@gmail.com",
                    FirstName = "Mecleudio",
                    LastName = "Queiroz",

                    Identification = new IdentificationRequest
                    {
                        Type = "CPF",
                        Number = "001672982-08"
                    }
                }
            };

            payment = await cliente.CreateAsync(request);
            var id = payment.Id;

            //String Base64
            string base64 = payment.PointOfInteraction.TransactionData.QrCodeBase64;

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64)))
            {


                frmRecebimentoPix rec = new frmRecebimentoPix(ms, payment, cliente);
                rec.Show();
                //pictureBox1.Image = Image.FromStream(ms);

                //Criar um novo Bitmap baseado na MemoryStream
                //using (Bitmap bmp = new Bitmap(ms))
                //{
                //Local onde vamos salvar a imagem
                //string path = Path.Combine("C:\\Users\\Meck Tecnologia\\source\\repos\\Mercado-Pago-sdk\\src\\MercadoPagoPix\\pix.jpg");   /*Server.MapPath("~/cbsa.jpg");*/

                //Salvar a imagem no formato JPG na raiz do site
                //bmp.Save(path, ImageFormat.Jpeg);
                //}
            }
        }
        private async void btnCobranca_Click(object sender, EventArgs e)
        {
            MercadoPago();
        }
    }
}



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
        public frmRecebimentoPix(MemoryStream _ms)
        {
            InitializeComponent();
            ms = _ms;
            pictureBox2.Image = Image.FromStream(ms); 
        }    
    }
}

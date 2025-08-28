using C_POO2.ejem1Guia8;

namespace ejem1Guia8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            decimal monto = Convert.ToDecimal(txtMonto.Text);
            IPago metodoPago;

            if (rbTarjeta.Checked)
                metodoPago = new PagoConTarjeta();
            else if (rbBitcoin.Checked)
                metodoPago = new PagoConBitcoin();
            else
                metodoPago = new PagoConEfectivo();

            string resultado = metodoPago.ProcesarPago(monto);
            MessageBox.Show(resultado, "Resultado del Pago");
        }
    }
}

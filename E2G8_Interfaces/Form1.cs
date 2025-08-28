using C_POO2.E2G8_Interfaces;

namespace E2G8_Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            IVehiculo vehiculo = null;
            if (cmbVehiculos.SelectedItem.ToString() == "Carro")
                vehiculo = new Carro();
            else if (cmbVehiculos.SelectedItem.ToString() == "Moto")
                vehiculo = new Moto();
            else
                vehiculo = new Bus();

            lblResultado.Text = vehiculo?.MostrarInformacion();

        }
    }
}

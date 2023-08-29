namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Importe;
            double Subtotal;
            double Impuesto;
            double Descuento;
            double Consumo = int.Parse(txtconsumos.Text);
            if (Consumo < 100)
            {
                Descuento = (Consumo * 0.1);
                lbldesc.Text = "Su total con descuento es: " + Descuento;

                Subtotal = (Consumo - Descuento);
                lblsubtotal.Text = "El Subtotal a pagar es: " + Subtotal;

                Impuesto = (Subtotal * 0.18);
                lblimpuesto.Text = "Su impuesto a pagar es: " + Impuesto;

                Importe = (Subtotal + Impuesto);
                lblimporte.Text = "El importe a pagar es: " + Importe;
            }
            else if (Consumo >= 100) 
            {
                Descuento = (Consumo * 0.2);
                lbldesc.Text = "Su total con descuento es: " + Descuento;

                Subtotal = (Consumo - Descuento);
                lblsubtotal.Text = "El Subtotal a pagar es: " + Subtotal;

                Impuesto = (Subtotal * 0.18);
                lblimpuesto.Text = "Su impuesto a pagar es: " + Impuesto;

                Importe = (Subtotal + Impuesto);
                lblimporte.Text = "El importe a pagar es: " + Importe;
            }
        }
    }
}
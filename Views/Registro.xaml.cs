using static System.Runtime.InteropServices.JavaScript.JSType;

namespace acabreraExamen.Views;

public partial class Registro : ContentPage
{
    public Registro(string usuario)
    {
		InitializeComponent();
        lblusuario.Text = "Bienvenida/o: " + usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if(pckciudades.SelectedIndex>=0 && pckPaises.SelectedIndex>=0)
        {
            double montoInicial = Convert.ToDouble(txtMonto.Text);
            double pagoMensual = Convert.ToDouble(txtPagomensual.Text);
            double pagoTotal = 1500;
            if (montoInicial > 0 && montoInicial < 1500 )
            {
                montoInicial = pagoTotal- montoInicial;
                pagoMensual = montoInicial / 4 + (0.04 * pagoTotal) ;
                txtPagomensual.Text = pagoMensual.ToString();   
            }
            else
            {
                DisplayAlert("Alerta", "Debe ingresar el monto correcto", "Ok");
            }


        }
        else
        {
            DisplayAlert("Alerta", "Ingrese la ciudad y el país", "Ok");
        }
    }

    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Resumen(lblusuario.Text, txtNombre.Text, dtpFecha.Date.ToString("dd/MM/yyyy"), txtApellido.Text, txtPagomensual.Text, txtEdad.Text, pckciudades.SelectedItem.ToString(), pckPaises.SelectedItem.ToString(), txtMonto.Text));

    }
}
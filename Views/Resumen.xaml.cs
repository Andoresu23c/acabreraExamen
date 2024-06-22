namespace acabreraExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario, string nombre,string fecha, string apellido, string pagomensual, string edad, string ciudad, string pais, string monto)
	{
		InitializeComponent();
        lblusuario.Text = usuario;
		txtNombre.Text = nombre;
		txtApellido.Text = apellido;
		txtEdad.Text = edad;
		txtFecha.Text = fecha;
		txtCiudad.Text = ciudad;
		txtPais.Text = pais;	
		txtMontoI.Text = monto;	
		txtPagoMensual.Text = pagomensual;
		txtPagoTotal.Text = Convert.ToString(1500);
    }
}
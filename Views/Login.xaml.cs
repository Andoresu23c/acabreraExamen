using Microsoft.Win32;

namespace acabreraExamen.Views;

public partial class Login : ContentPage
{
    private string[,] usuariosPasswords;
    public Login()
    {
        InitializeComponent();
        usuariosPasswords = new string[,]
        {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
        };
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
        {
            DisplayAlert("Alerta", "Debe ingresar usuario y contraseña", "Ok");
            return;
        }

        bool isAuthenticated = false;

        for (int i = 0; i < usuariosPasswords.GetLength(0); i++)
        {
            if (usuariosPasswords[i, 0] == txtUsuario.Text && usuariosPasswords[i, 1] == txtContrasena.Text)
            {
                isAuthenticated = true;
                break;
            }
        }

        if (isAuthenticated)
        {
            DisplayAlert("Éxito", "Inicio de sesión correcto", "Ok");
            Navigation.PushAsync(new Registro(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Ok");
        }
    }
}
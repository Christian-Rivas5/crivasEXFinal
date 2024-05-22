namespace crivasEXFinal.Views;

public partial class vLguin : ContentPage
{

    string usuario1;
    string contrasena1;
    
    public vLguin()
	{
		InitializeComponent();
	}

    private async void btnCrear_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new vRegistro());
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string[] usuarios;
        string[] contrasenas;

        Boolean logueado;
        string usuario_logueado;

        usuarios = new string[3];
        contrasenas = new string[3];

        logueado = false;
        usuario_logueado = "";

        usuarios[0] = "christian.rivas@americancollege.edu.ec";
        usuarios[1] = "sandra.rios@americancollege.edu.ec";
        usuarios[2] = "maria.sibri@americancollege.edu.ec";

        contrasenas[0] = "American.24";
        contrasenas[1] = "American.25";
        contrasenas[2] = "American.26";

        for (int i = 0; i < usuarios.Length; i++)
        {
            if ((txtCorreo.Text == usuarios[i] && txtContrasena.Text == contrasenas[i]))
            {
                logueado = true;
                usuario_logueado = usuarios[i];
                break;
            }
            else if ((txtCorreo.Text == usuario1 && txtContrasena.Text == contrasena1))
            {
                logueado = true;
                usuario_logueado = usuario1;
                break;
            }
        }
        if (logueado)
        {
            Navigation.PushAsync(new vAgregarDocumento(usuario_logueado));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/contrasena incorresctos", "Cerrar");
        }
    }
}
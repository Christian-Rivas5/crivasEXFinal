using Android.Hardware;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Net.Http;
using System.Net.Http.Headers;
namespace crivasEXFinal.Views;


public partial class vAgregarDocumento : ContentPage
{
    public vAgregarDocumento(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido: " + usuario, "Cerrar");
        lblUsuario.Text = "usuario conectado: " + usuario;
    }

    private void btnSubirDoc_Clicked(object sender, EventArgs e)
    {

    }

    private async void OnUploadImageClicked(object sender, EventArgs e)
    {
        await CrossMedia.Current.Initialize();

        if (!CrossMedia.Current.IsPickPhotoSupported)
        {
            await DisplayAlert("No soportado", "Elige una foto no soportada en este dispositivo.", "OK");
            return;
        }

        _mediaFile = await CrossMedia.Current.PickPhotoAsync();

        if (_mediaFile == null)
            return;

        selectedImage.Source = ImageSource.FromStream(() => _mediaFile.GetStream());
    }
}

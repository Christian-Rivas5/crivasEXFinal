using crivasEXFinal.Views;

namespace crivasEXFinal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new vLguin());
        }
    }
}

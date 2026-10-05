namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void EnviarCounter(object? sender, EventArgs e)
        {


            ingresaBTN.Text = $"Clicked {count} time";
            

        }
    }
}

using Xamarin.Forms;

namespace SampleUITesting
{
    public partial class SampleUITestingPage : ContentPage
    {
        public SampleUITestingPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Result", "Hello World", "Ok");
        }
    }
}

using Xamarin.Forms;

namespace TestMap.Views
{
    public partial class MapTest : ContentPage
    {
        public MapTest()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            SfMap.ZoomLevel += 1;
        }
    }
}

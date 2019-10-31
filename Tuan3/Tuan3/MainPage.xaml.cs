using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tuan3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnThemHoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemHoa());
        }

        private void btnThemLoaiHoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ThemLoaiHoa());
        }

        private void btnDanhSach_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DanhSach());
        }
    }
}

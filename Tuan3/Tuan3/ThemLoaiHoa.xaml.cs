using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemLoaiHoa : ContentPage
    {
        public ThemLoaiHoa()
        {
            InitializeComponent();
        }

        private void btnGhi_Clicked(object sender, EventArgs e)
        {
            Database db = new Database();
            LoaiHoa loaiHoa = new LoaiHoa { TenLoai = etTenLoai.Text };
            if (db.InsertLoaihoa(loaiHoa) == true)
            {
                DisplayAlert("Thông Báo", "Thêm loại hoa thành công", "OK");
            }
            else
                DisplayAlert("Thông Báo", "Thêm loại hoa Lỗi", "OK");
        }
    }
}
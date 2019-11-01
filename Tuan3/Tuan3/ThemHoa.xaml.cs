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
    public partial class ThemHoa : ContentPage
    {
        public ThemHoa()
        {
            Database db = new Database();
            List<LoaiHoa> list = db.selectLoaihoa();
            List<string> pickerData = new List<string>();
            foreach (LoaiHoa loaiHoa in list)
            {
                pickerData.Add(loaiHoa.TenLoai);
            }
            InitializeComponent();
            pcMaLoai.ItemsSource = pickerData;
        }
    }
}
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
    public partial class DanhSach : ContentPage
    {
        Database db;
        List<LoaiHoa> dsl;
        public DanhSach()
        {
            InitializeComponent();
            InitializeComponent();
            db = new Database();
            dsl = db.selectLoaihoa();
            lstdsloai.ItemsSource = dsl;
        }
    }
}
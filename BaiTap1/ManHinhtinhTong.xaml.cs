using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManHinhtinhTong : ContentPage
    {
        public ManHinhtinhTong()
        {
            InitializeComponent();
        }

        private void clickTinhTong(object sender, EventArgs e)
        {
            double so1, so2, tong;
            if (soa.Text == null || sob.Text == null)
            {
                DisplayAlert("THÔNG BÁO", "Vui lòng nhập đầy đủ ", "OK");
            }
            else
            {
                so1 = double.Parse(soa.Text);
                so2 = double.Parse(sob.Text);
                tong = so1 + so2;
                txtTong.Text = tong.ToString();
            }
        }
        private void clickVeTrangChu(object sneder, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaiTap1
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
        private void clickChao(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhChao());
        }
        private void clickTinhTong(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhtinhTong());
        }
        private void clickStackLayout(object sender, EventArgs e)
        {

        }
        private void clickAbsoluteLayout(object sender, EventArgs e)
        {

        }
        private void clickGridLayout(object sender, EventArgs e)
        {

        }
        private void clickLogin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}

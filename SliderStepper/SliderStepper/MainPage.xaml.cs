using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SliderStepper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Editor1.FontSize = Slider1.Value;
        }
        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.NewValue > 0)
            {
                Editor1.FontSize = e.NewValue;
                Slider1.Value = e.NewValue;
                Slider2.Value = e.NewValue;
                Slider3.Value = e.NewValue;
            }
        }
    }
}

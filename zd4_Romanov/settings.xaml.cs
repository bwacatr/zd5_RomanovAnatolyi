using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4_Romanov
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class settings : ContentPage
	{
		public settings ()
		{
			InitializeComponent ();
		}

        private void EffectsSlider_ValueChanged(object sender, ValueChangedEventArgs e) //смена цвета кнопки
        {
            ColorButton.BackgroundColor = Color.FromRgb(Math.Round(SliderEffect1.Value), Math.Round(SliderEffect2.Value), Math.Round(SliderEffect3.Value));
            
        }

        private void Button_Clicked(object sender, EventArgs e) // смена цвета экрана
        {
            this.BackgroundColor = Color.FromRgb(Math.Round(SliderEffect1.Value), Math.Round(SliderEffect2.Value), Math.Round(SliderEffect3.Value));

            int index = picker1.SelectedIndex;

            switch (index)
            {
                case 0:
                    {
                        StaticBtn.Text = "Понедельник";
                        break;
                    }
                case 1:
                    {
                        StaticBtn.Text = "Вторник";
                        break;
                    }
                case 2:
                    {
                        StaticBtn.Text = "Среда";
                        break;
                    }
                case 3:
                    {
                        StaticBtn.Text = "Четверг";
                        break;
                    }
                case 4:
                    {
                        StaticBtn.Text = "Пятница";
                        break;
                    }
                case 5:
                    {
                        StaticBtn.Text = "Суббота";
                        break;
                    }
                case 6:
                    {
                        StaticBtn.Text = "Воскресенье";
                        break;
                    }
                default:
                    {
                        break;
                    }

            }
            
        }

        private void Button_Clicked_1(object sender, EventArgs e) // сброс настроек
        {
            this.BackgroundColor = Color.White;
            switch1.IsToggled = false;
            switch2.IsToggled = false;
            picker1.SelectedItem = null;
            StaticBtn.Text = "STATIC";
            
        }
    }
}
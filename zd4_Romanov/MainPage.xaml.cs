using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace zd4_Romanov
{
    public partial class MainPage : CarouselPage
    {
        public MainPage(string login)
        {
            InitializeComponent();

            this.Children.Add(new welcome(login));
            this.Children.Add(new settings());
        }
    }
}

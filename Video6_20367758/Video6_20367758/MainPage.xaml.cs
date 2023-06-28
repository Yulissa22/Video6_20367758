using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Video6_20367758
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pasado = e.OldTextValue;
            string nuevo = e.NewTextValue;

        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }
}
 
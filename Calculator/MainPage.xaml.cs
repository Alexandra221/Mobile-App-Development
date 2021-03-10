using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Submit_Clicked(object sender, EventArgs e)
        {
            try
            {
                int first = Convert.ToInt32(First.Text);
                int second = Convert.ToInt32(Second.Text);

                int result = first + second;

                Page1 secondpage = new Page1();
                Navigation.PushAsync(secondpage);
                secondpage.Calculator(result);
            }
            catch (FormatException)
            {
                DisplayAlert("Ошибка", "Введите числовые данные", "Ввести заново");

            }


        }
    }

}

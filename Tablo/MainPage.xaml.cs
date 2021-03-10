using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tablo
{
    public partial class MainPage : ContentPage
    {
        public int Can_count = 0;
        public int Usa_count = 0;
        public int temp = 0;
        public MainPage()
        {
            InitializeComponent();


        }

        private void Can_Clicked(object sender, EventArgs e)
        {
            Can_count++;
            ita_count.Text = Can_count.ToString();
        }

        private void Usa_Clicked(object sender, EventArgs e)
        {
            Usa_count++;
            ger_count.Text = Usa_count.ToString();
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            Can_count = 0;
            ita_count.Text = Can_count.ToString();
            Usa_count = 0;
            ger_count.Text = Usa_count.ToString();
        }



        private void Switch_Clicked(object sender, EventArgs e)
        {
            temp++;
            if (temp % 2 != 0)
            {
                Title = "Футбольный матч";
                Can.Text = "Канада";
                Usa.Text = "США";
                Reset.Text = "Сброс";
                Switch.Text = "Переключить язык";
            }
            else
            {

                Title = "Football cup";
                Can.Text = "Can";
                Usa.Text = "Usa";
                Reset.Text = "Reset";
                Switch.Text = "Switch language";
            }



        }
        private double width = 0;
        private double height = 0;

        protected override void OnSizeAllocated(double width, double height)
        {



            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                if (width > height)
                {
                    orientation.Orientation = StackOrientation.Horizontal;
                    Primary.Spacing = 100;
                    usa_image.WidthRequest = 150;
                    usa_image.HeightRequest = 100;
                    can_image.WidthRequest = 150;
                    can_image.HeightRequest = 100;
                    Add_scores.Spacing = 110;



                }
                else
                {
                    orientation.Orientation = StackOrientation.Vertical;
                    Primary.Spacing = 10;
                    usa_image.WidthRequest = 120;
                    usa_image.HeightRequest = 80;
                    can_image.WidthRequest = 120;
                    can_image.HeightRequest = 80;
                    Add_scores.Spacing = 70;
                    Usa.WidthRequest = 120;
                    Can.WidthRequest = 120;
                    Reset.WidthRequest = 150;

                }



            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.santa);
            int row = Grid.GetRow(this.santa);

            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    col--;
                    break;
                case SwipeDirection.Right:
                    col++;
                    break;
                case SwipeDirection.Up:
                    row--;
                    break;
                case SwipeDirection.Down:
                    row++;
                    break;
            }
            Grid.SetColumn(this.santa, col);
            Grid.SetRow(this.santa, row);
            if (col == Grid.GetColumn(this.elka) && row == Grid.GetRow(this.elka))
            {
                await DisplayAlert("Поздравление", "Вы успели положить подарок под ёлку!", "Ура!");
                await Navigation.PushAsync(new FinalStagePage());
            }
        }

        private void SwipeGestureRecognizer_Swiped_1(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.box_swipe);
            switch (e.Direction)
            {
               case SwipeDirection.Right:
                    col++;
                    break;
                default:

                break;
            }
            Grid.SetColumn(this.box_swipe, col);
        }
    }
}

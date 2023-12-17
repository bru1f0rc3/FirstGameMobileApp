using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoreQuestPage : ContentPage
    {
        public MoreQuestPage()
        {
            InitializeComponent();
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.year1);
            int row = Grid.GetRow(this.year1);

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
            Grid.SetColumn(this.year1, col);
            Grid.SetRow(this.year1, row);
        }

        private void SwipeGestureRecognizer_Swiped_1(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.year2);
            int row = Grid.GetRow(this.year2);

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
            Grid.SetColumn(this.year2, col);
            Grid.SetRow(this.year2, row);
        }

        private void SwipeGestureRecognizer_Swiped_2(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.year3);
            int row = Grid.GetRow(this.year3);

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
            Grid.SetColumn(this.year3, col);
            Grid.SetRow(this.year3, row);
        }

        private void SwipeGestureRecognizer_Swiped_3(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.year4);
            int row = Grid.GetRow(this.year4);

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
            Grid.SetColumn(this.year4, col);
            Grid.SetRow(this.year4, row);
        }

        private async void SwipeGestureRecognizer_Swiped_4(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.star);
            int row = Grid.GetRow(this.star);

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
            Grid.SetColumn(this.star, col);
            Grid.SetRow(this.star, row);

            await DisplayAlert("Правило", "У вас есть на всё 20 секунд чтобы нарядить ёлочку", "Хорошо");

            int sec = 0;
            for (int i = 1; i <= 20; i++)
            {
                sec++;
                await Task.Delay(1000);
            }

            if (sec == 20)
            {
                if (Grid.GetRow(this.star) == 0 && (Grid.GetColumn(this.star) == 1))
                {
                    await DisplayAlert("Игра", "Вы справились с этим", "УРА!");
                    await Task.Delay(500);
                    await DisplayAlert("Игра", "Вы перемещаетесь в главное меню..", "OK");
                    await Task.Delay(1000);
                    await Navigation.PushAsync(new Page2());
                }
            }
            else
            {
                await DisplayAlert("Игра", "Вы проиграли мы начинаем по новой", "Ok...");
                await Task.Delay(1000);
                await Navigation.PushAsync(new MoreQuestPage());
            }
        }
    }
}
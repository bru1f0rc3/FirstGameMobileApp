using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinalStagePage : ContentPage
    {
        public FinalStagePage()
        {
            InitializeComponent();
        }

        public bool ShowMessage = false;

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            int col = Grid.GetColumn(this.boy);
            int row = Grid.GetRow(this.boy);
            
            // string yes = "Да";
            // string dont = "Нет";

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
            Grid.SetColumn(this.boy, col);
            Grid.SetRow(this.boy, row);

            if (Grid.GetRow(this.boy) == 4 && (Grid.GetColumn(this.boy) == 1))
            {
                
                await DisplayAlert("Мальчик", "Время уже 1:00 AM", "Хм...");
                await Task.Delay(800);
                await DisplayAlert("Мальчик", "Думаю дедушка мороз уже положил под елочку подарок мне", "Пора идти!");
                await Task.Delay(800);
                ShowMessage = true;
            }

            ShowMessage = false;
            if (col == Grid.GetColumn(this.elka) && row == Grid.GetRow(this.elka))
            {
                await DisplayAlert("Мальчик", "Подарок и правда был под ёлочкой", "Ура!!!");
                await Task.Delay(800);
                await DisplayAlert("Мальчик", "Надо сесть за стол на кухне и съесть шоколад лежащий в подарке", "Идём");
                await Task.Delay(800);
            }
            int clickCount = 1;
            if (Grid.GetRow(this.boy) == 6 && (Grid.GetColumn(this.boy) == 5))
            {
                await DisplayAlert("Мальчик", "Пора съесть шоколадку", "Начинаем");
                await Task.Delay(800);
                await DisplayAlert("Подсказка", "чтобы съесть шоколадку нужно прокликать 20 раз", "OK");
                await Task.Delay(800);

                for (int i = 1; i <= 20; i++)
                {
                    clickCount++;
                    await DisplayAlert("Подсказка", $"Клик {clickCount}", "OK");
                    await Task.Delay(150);
                }

                await DisplayAlert("Мальчик", "Все съел шоколадку", "OK");
                await Task.Delay(800);
                await DisplayAlert("Главное", "Игра на этом окончена", "OK");
            }
        }
    }
}
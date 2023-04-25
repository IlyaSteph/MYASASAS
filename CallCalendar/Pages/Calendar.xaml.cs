using CallCalendar.Data;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CallCalendar
{
    /// <summary>
    /// Логика взаимодействия для chpe.xaml
    /// </summary>
    public partial class chpe : Page
    {
        public chpe()
        {
            InitializeComponent();
            datePicker.SelectedDate = DateTime.Now;
        }

        public chpe(DateOnly date)
        {
            InitializeComponent();
            datePicker.SelectedDate = date.ToDateTime(new TimeOnly());
        }

        private void hyyy(object sender, RoutedEventArgs e)
        {
            gj();
        }


        private void ma(object sender, SizeChangedEventArgs e)
        {
            smena_negra();
        }

        private void pi(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded)
                gj();
        }

        private void knopk(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate == null)
                return;

            datePicker.SelectedDate = datePicker.SelectedDate.Value.AddMonths(-1);
        }

        private void esh(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate == null)
                return;

            datePicker.SelectedDate = datePicker.SelectedDate.Value.AddMonths(1);
        }


        private void smena_negra()
        {
            foreach (dattt square in canvas.Children.OfType<dattt>())
                square.Margin = new Thickness(10 + ((square.Day - 1) % ((int)(canvas.RenderSize.Width) / 80)) * 80, 10 + ((square.Day - 1) / ((int)canvas.RenderSize.Width / 80)) * 80, 10, 10);
        }
        /// <summary>
        /// смену над сбда 
        /// </summary>
        private void gj()
        {
            canvas.Children.Clear();
            if (datePicker.SelectedDate == null)
                return;

            DateTime selectedDate = datePicker.SelectedDate ?? DateTime.Now;
            DateLabel.Content = selectedDate.ToString("MMMM yyyy");

            for (int aggggggggggg = 1; aggggggggggg <= DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month); aggggggggggg++)
            {
                dattt square = new (speee.LoadUserChoose(new DateOnly(selectedDate.Year, selectedDate.Month, aggggggggggg)))
                {
                    Margin = new Thickness(10 + 80 * (aggggggggggg - 1), 10, 10, 10),
                    VerticalAlignment = VerticalAlignment.Top,
                    HorizontalAlignment = HorizontalAlignment.Left
                };

                canvas.Children.Add(square);
            }

            smena_negra();
        }
    }
}
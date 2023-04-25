using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace CallCalendar
{
    public partial class dattt : UserControl
    {
        public Che_hoch choose;
        public int Day => choose.date.Day;
        private string kart = "/icons/pngwin.png";
        public dattt(Che_hoch choose)
        {
            InitializeComponent();

            this.choose = choose;
            label.Content = Day.ToString();

            kart = "/icons/pngwin.png";
            if (choose.items.Count > 0)
                kart = $"/icons/{choose.items[0]}.png";

            picture.Source = new BitmapImage(new Uri(kart, UriKind.Relative)); ;
        }

        private void Click(object sender, MouseButtonEventArgs e)
        {
            MainWindow window = (MainWindow)App.Current.MainWindow;
            window.Frame.Content = new ListPage(choose);
        }
    }
}
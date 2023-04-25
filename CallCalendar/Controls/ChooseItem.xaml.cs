using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CallCalendar
{

    public partial class virrr : UserControl
    {
        public string name { get; init; }
        public bool isOn => checkbox.IsChecked ?? false;
        public virrr(string name, bool isOn)
        {
            InitializeComponent();

            this.name = name;
            picture.Source = new BitmapImage(new Uri("/icons/" + name + ".png", UriKind.Relative));///через юрриии или хуй знает
            label.Content = name;

            checkbox.IsChecked = isOn;
        }

        private void checkbox_Checked(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
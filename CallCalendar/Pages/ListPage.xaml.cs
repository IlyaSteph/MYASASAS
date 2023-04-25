using CallCalendar.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CallCalendar
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public Che_hoch choose;
        public ListPage(Che_hoch choose)
        {
            InitializeComponent();

            this.choose = choose;
            foreach(string option in Che_hoch.options)
            {
                listBox.Items.Add(new virrr(option, choose.items.Contains(option)));
            }

            DateLabel.Content = choose.date.ToString("d MMMM yyyy");
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            choose.items.Clear();

            foreach (virrr item in listBox.Items.OfType<virrr>())
                if (item.isOn)
                    choose.items.Add(item.name);

            speee.SaveUserChoose(choose);

            Exit();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            MainWindow window = (MainWindow)App.Current.MainWindow;
            window.Frame.Content = new chpe(choose.date);
        }
    }
}
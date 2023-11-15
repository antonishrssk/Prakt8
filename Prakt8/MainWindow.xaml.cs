using System;
using System.Windows;
using Lib_4;

namespace Prakt8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        WorkerFather wfa = new WorkerFather("Владимир", "Петров", "учитель", 1),
            wfb = new WorkerFather("Алексей", "Воробьёв", "инженер", 2);

        private void tbFirstName1_LostFocus(object sender, RoutedEventArgs e) => wfa.FirstName = tbFirstName1.Text;

        private void tbLastName1_LostFocus(object sender, RoutedEventArgs e) => wfa.LastName = tbLastName1.Text;

        private void tbJob1_LostFocus(object sender, RoutedEventArgs e) => wfa.Job = tbJob1.Text;

        private void tbChildren1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(tbChildren1.Text, out int n)) wfa.Children = n;
            else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void tbFirstName2_LostFocus(object sender, RoutedEventArgs e) => wfb.FirstName = tbFirstName2.Text;

        private void tbLastName2_LostFocus(object sender, RoutedEventArgs e) => wfb.LastName = tbLastName2.Text;

        private void tbJob2_LostFocus(object sender, RoutedEventArgs e) => wfb.Job = tbJob2.Text;

        private void tbChildren2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(tbChildren2.Text, out int n)) wfb.Children = n;
            else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnClone1_Click(object sender, RoutedEventArgs e)
        {
            wfb = (WorkerFather)wfa.Clone();
            tbFirstName2.Text = wfb.FirstName;
            tbLastName2.Text = wfb.LastName;
            tbJob2.Text = wfb.Job;
            tbChildren2.Text = wfb.Children.ToString();
        }

        private void btnClone2_Click(object sender, RoutedEventArgs e)
        {
            wfa = (WorkerFather)wfb.Clone();
            tbFirstName1.Text = wfa.FirstName;
            tbLastName1.Text = wfa.LastName;
            tbJob1.Text = wfa.Job;
            tbChildren1.Text = wfa.Children.ToString();
        }

        private void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            tbInfo.Text = $"1) {WorkerFather.GetInfo(wfa)}\n2) {WorkerFather.GetInfo(wfb)}";
        }

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            tbResult.Text = "Фамилии работников " + (wfa.CompareTo(wfb) == 0 ? "равны" : "не равны");
        }

        private void miInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Антонишин Кирилл Сергеевич\n" +
                "Практическая работа №8\n" +
                "Создать интерфейсы - работник и отец-семейства. Создать класс работника-отца семейства. " +
                "Класс должен включать конструктор, функцию для формирования строки информации о работнике. " +
                "Сравнение производить по фамилии.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

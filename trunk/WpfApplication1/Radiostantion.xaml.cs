using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Radiostantion : Window
    {
        MainController _c;

        public Radiostantion(MainController c)
        {
            InitializeComponent();
            _c = c;
        }

        private void RadiostantionsComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("http://radio.goha.ru:8000/grind.fm");
            data.Add("http://animeradio.su:8000/");
            data.Add("http://online-radioroks.tavrmedia.ua/RadioROKS");
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = 0;
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            _c.PlayMusic(RadiostantionTextBox.Text);
            this.Close();
        }

        private void RadiostantionsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RadiostantionTextBox.Text = (sender as ComboBox).SelectedItem as string;
        }
    }
}

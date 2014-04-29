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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MediaPlayer mediaPlayer = new MediaPlayer();
        private MainController c;

        public MainWindow()
        {
            InitializeComponent();
            
            c = new MainController(this);
            c.mediaPlayer = this.mediaPlayer;
            c.PlayMusic("http://radio.goha.ru:8000/grind.fm");
        }

        public void PLayMusic(string s)
        {
            c.PlayMusic(s);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (VolumeSlider.Visibility == System.Windows.Visibility.Hidden){
                VolumeSlider.Visibility = System.Windows.Visibility.Visible;
                ChangeImage.Visibility = System.Windows.Visibility.Visible;
                RadiostantionButton.Visibility = System.Windows.Visibility.Visible;
            }
            else{
                VolumeSlider.Visibility = System.Windows.Visibility.Hidden;
                ChangeImage.Visibility = System.Windows.Visibility.Hidden;
                RadiostantionButton.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaPlayer.Volume = (sender as Slider).Value;
        }

        private void ChangeImage_Click(object sender, RoutedEventArgs e)
        {
            c.ChangeImage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Radiostantion r = new Radiostantion(c);
            r.Show();
        }

    }
}

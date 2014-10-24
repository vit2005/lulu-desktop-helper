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
using System.Threading;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {

        private MediaPlayer mediaPlayer = new MediaPlayer();
        private MainController c;
        private bool settingsVisible;
        private Point dragPoint;

        public MainWindow()
        {
            InitializeComponent();

            c = new MainController(this);
            c.mediaPlayer = this.mediaPlayer;
            c.PlayMusic((c.LoadMusic().Any()) ? c.LoadMusic()[0] : "http://radio.goha.ru:8000/grind.fm");
            settingsVisible = false;
            this.StateChanged += new EventHandler(Window1_StateChanged);
        }

        public void PLayMusic(string s)
        {
            c.PlayMusic(s);
        }

        private void SwapSettings()
        {
            if (settingsVisible)
            {
                HideSettings();
            }
            else
            {
                ShowSettings();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                dragPoint = new Point(Left,Top);
                DragMove();
                if (Left == dragPoint.X && Top == dragPoint.Y)
                {
                    SwapSettings();
                }
            }
        }

        private void Window_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Volume = (mediaPlayer.Volume == 0) ? mediaPlayer.Volume = VolumeSlider.Value : 0;
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

        private void ShowSettings()
        {
            VolumeSlider.Visibility = Visibility.Visible;
            ChangeImage.Visibility = Visibility.Visible;
            RadiostantionButton.Visibility = Visibility.Visible;
            settingsVisible = true;
        }

        private void HideSettings()
        {
            VolumeSlider.Visibility = Visibility.Hidden;
            ChangeImage.Visibility = Visibility.Hidden;
            RadiostantionButton.Visibility = Visibility.Hidden;
            settingsVisible = false;
        }

        private void Window_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Application.Current.Shutdown();
            }
        }

        void Window1_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
                GIFCtrl.StopAnimate();
            else
                GIFCtrl.StartAnimate();
        }
    }
}

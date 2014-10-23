using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApplication1
{
    public class MainController
    {
        private MainWindow _w;
        public MediaPlayer mediaPlayer = new MediaPlayer();

        public MainController(MainWindow w)
        {
            _w = w;
        }

        public void ChangeImage()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog(); 
            dlg.DefaultExt = ".gif";
            dlg.Filter = "Waifu (.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                Bitmap b = new Bitmap(filename);
                _w.GIFCtrl.Image = b;
            }
        }

        public void PlayMusic(string s)
        {
            mediaPlayer.Open(new Uri(s));
            mediaPlayer.Volume = 0.1;
            mediaPlayer.Play();
        }

        public List<string> LoadMusic()
        {
            List<string> data = new List<string>();
            try
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader("radio.txt");
                while ((line = file.ReadLine()) != null)
                {
                    data.Add(line);
                }
            }
            catch (Exception) { }
            return data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public class pizzajoint_template
    {
        public string Name { get; set; }
        public string Hyperlink { get; set; }
        public string Logo_imagelink { get; set; }
        public Bitmap Logo { get; set; }
        public pizzajoint_template(string name, string hyperlink, string logo)
        {
            Name = name;
            Hyperlink = hyperlink;
            Logo_imagelink = logo;
        }

        public Button create_button(int y_)
        {
            
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    // Download the image data from the URL
                    byte[] imageData = webClient.DownloadData(Logo_imagelink);

                    // Create a MemoryStream from the downloaded data
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {
                        // Create a Bitmap from the MemoryStream
                        Bitmap bitmap = new Bitmap(memoryStream);
                        Logo = bitmap;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"- - {Logo_imagelink} - -\nError grabbing image URL above. Make sure this is a valid image URL.\nIf it is not valid, you can update is under Settings > Edit list");
            }


            Button new_pizza_button = new Button
            {
                Text = Name,
                Left = 10,
                Top = y_,
                Width = 200,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                BackgroundImage = Logo,
                BackgroundImageLayout = ImageLayout.Zoom
            };
            new_pizza_button.Click += (s, e) =>
            {
                string default_browser = Properties.Settings.Default.app_default_browser;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.FileName = default_browser;
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                startInfo.Arguments = Hyperlink;
                try
                {
                    Process.Start(startInfo);
                } catch (Exception ex)
                {
                    MessageBox.Show($"Error trying to load {Hyperlink} into browser {default_browser}.\nMake sure you have browser installed on your machine.");
                }
                Application.Exit();
            };

            return new_pizza_button;
        }



    }
}

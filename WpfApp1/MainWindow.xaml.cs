using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.DownloadHtmlAsync("http://msdn.microsoft.com");
            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show("Waiting for the task to complete");
            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }

        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url);

        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\TriNghia-Dev-26\Downloads\result2.html"))
            {
                streamWriter.Write(html);
            }

        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"C:\Users\TriNghia-Dev-26\Downloads\result.html"))
            {
                streamWriter.Write(html);
            }

        }
    }
}

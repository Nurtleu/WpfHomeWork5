using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WebBrowser
{
    /// <summary>
    /// Логика взаимодействия для WebBrowser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.GoBack();
            }
            catch { }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.GoForward();
            }
            catch { }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri("http://" + searchTextBox.Text);
            }
            catch { }
        }

        private void GoogleWebBrowser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri("https://www.google.kz/");
            }
            catch { }
        }

        private void YandexWebBrowser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri("https://yandex.kz/");
            }
            catch { }
        }

        private void WikipediaWebBrowser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri("https://www.wikipedia.org/");
            }
            catch { }
        }

        private void MailWebBrowser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri("https://mail.ru/");
            }
            catch { }
        }

        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri(" ");
            }
            catch { }
        }

        private void TabControl_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void CopyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Copy();
        }

        private void PasteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Paste();
        }

        private void CutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Cut();
        }

        private void DeleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Clear();
        }

        private void MailMenuItem_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri("https://mail.ru/");
        }

        private void WikipediaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri("https://www.wikipedia.org/");
        }

        private void YandexMenuItem_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri("https://yandex.kz/");
        }

        private void GoogleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri("https://www.google.kz/");
        }
    }
}

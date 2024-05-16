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

namespace IT3B_Chat.Client
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
        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            string serverAddress = ServerAddressTextBox.Text;
            MessageBox.Show($"Připojeno k serveru na adrese: {serverAddress}");
        }

        private void DisconnectButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Odpojeno od serveru");
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string newMessage = NewMessageTextBox.Text;
            MessageBox.Show($"Odeslána zpráva: {newMessage}");
        }
    }
}
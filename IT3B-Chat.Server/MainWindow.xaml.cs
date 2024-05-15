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
using WebSocketSharp.Server;

namespace IT3B_Chat.Server
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
        private WebSocketServer wsServer;

        public MainWindow()
  {
   InitializeComponent();
  }
        private void ConnectDisconnect_Click(object sender, RoutedEventArgs e)
        {
            if (wsServer == null || !wsServer.IsListening)
            {
                
                wsServer = new WebSocketServer(serverAddressTextBox.Text);

               
                wsServer.AddWebSocketService<ChatBehavior>("/chat");

                
                wsServer.Start();
                connectDisconnectButton.Content = "Odpojit";
            }
            else
            {
                
                wsServer.Stop();
                wsServer = null;
                connectDisconnectButton.Content = "Připojit";
            }
        }

        
        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            if (wsServer != null && wsServer.IsListening)
            {
                wsServer.WebSocketServices.Broadcast(newMessageTextBox.Text);
                newMessageTextBox.Text = ""; 
            }
            else
            {
                MessageBox.Show("Server není připojen.");
            }
        }
    }
}
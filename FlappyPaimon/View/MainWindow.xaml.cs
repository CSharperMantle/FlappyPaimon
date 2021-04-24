using System.Windows;
using System.Diagnostics;


namespace FlappyPaimon.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaunchGitHubRepo(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/CSharperMantle/FlappyPaimon");
        }
    }
}
using FlappyPaimon.Model;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

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

            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void LaunchGitHubRepo(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/CSharperMantle/FlappyPaimon");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Jump();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            player.Update();
            System.Diagnostics.Debug.WriteLine(string.Format("X: {0}, Y: {1}", player.Position.X, player.Position.Y));
        }

        private readonly Player player = new Player(new Point(0, 0));

        private readonly DispatcherTimer timer = new DispatcherTimer();
    }
}
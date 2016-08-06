// -----------------------------------------------------------
// Copyrights (c) 2016 Seditio 🍂 INC. All rights reserved.
// -----------------------------------------------------------

using System.Windows;
using System.Windows.Controls;

using MahApps.Metro.Controls;

namespace AyriaDesktop
{
    /// <summary>
    ///   Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // TODO: Placeholder event.

            // Adding random data
            ClassListBox.Items.Add("ScannedGame1");
            ClassListBox.Items.Add("ScannedGame2");
            ClassListBox.Items.Add("ScannedGame3");
            ClassListBox.Items.Add("ScannedGame4");
            ClassListBox.Items.Add("ScannedGame5");
            ClassListBox.Items.Add("ScannedGame6");
            ClassListBox.Items.Add("ScannedGame7");
            ClassListBox.Items.Add("ScannedGame8");
            ClassListBox.Items.Add("ScannedGame9");
            ClassListBox.Items.Add("ScannedGame10");
        }

        private void GameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: Placeholder event.
        }

        private void ScanGames(object sender, RoutedEventArgs e)
        {
            // TODO: Placeholder event.
        }

        private void AddGame(object sender, RoutedEventArgs e)
        {
            // TODO: Placeholder event.
        }

        private void ShowBugReport(object sender, RoutedEventArgs e)
        {
            // TODO: Placeholder event.
        }

        private void ShowSettings(object sender, RoutedEventArgs e)
        {
            ShowFlyout(0);
        }

        private void ShowFlyout(int index)
        {
            var flyout = Flyouts.Items[index] as Flyout;
            if(flyout == null)
            {
                return;
            }

            flyout.IsOpen = !flyout.IsOpen;
        }
    }
}
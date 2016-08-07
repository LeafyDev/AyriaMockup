// -----------------------------------------------------------
// Copyrights (c) 2016 Seditio 🍂 INC. All rights reserved.
// -----------------------------------------------------------

using System;
using System.ComponentModel;
using System.Threading;
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
            GameListBox.Items.Add("ScannedGame1");
            GameListBox.Items.Add("ScannedGame2");
            GameListBox.Items.Add("ScannedGame3");
            GameListBox.Items.Add("ScannedGame4");
            GameListBox.Items.Add("ScannedGame5");
            GameListBox.Items.Add("ScannedGame6");
            GameListBox.Items.Add("ScannedGame7");
            GameListBox.Items.Add("ScannedGame8");
            GameListBox.Items.Add("ScannedGame9");
            GameListBox.Items.Add("ScannedGame10");
        }

        private void WindowLoaded()
        {
            SmoothTransition();
        }

        private void SmoothTransition()
        {
            Thread.Sleep(new Random().Next(500, 2000)); // Fake loading time, appreciated the gif.

            var i = 0;
            do
            {
                try
                {
                    Dispatcher.Invoke(() =>
                    {
                        Content.Opacity = Content.Opacity + .1F;
                        GameList.Opacity = GameList.Opacity + .1F;
                        Loading.Opacity = Loading.Opacity - .1F;
                    });
                }
                catch(Exception)
                {
                    // Ignored
                }

                i++;
                Thread.Sleep(50);
            }
            while(i != 10000);
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

        private void MWindow_ContentRendered(object sender, EventArgs e)
        {
            new Thread(WindowLoaded).Start();
        }

        private void MWindow_Closing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0); // Remaining threads just need to fucking die.
        }
    }
}
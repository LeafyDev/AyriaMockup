// -----------------------------------------------------------
// Copyrights (c) 2016 Seditio 🍂 INC. All rights reserved.
// -----------------------------------------------------------

using System.Windows;

namespace AyriaDesktop
{
    /// <summary>
    ///   Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void AppStart(object sender, StartupEventArgs e)
        {
            // TODO: Add some self updater stuff here.
            new MainWindow().Show();
        }
    }
}
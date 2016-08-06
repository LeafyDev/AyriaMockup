// -----------------------------------------------------------
// Copyrights (c) 2016 Seditio 🍂 INC. All rights reserved.
// -----------------------------------------------------------

using System.ComponentModel;
using System.Windows;

using MaterialDesignThemes.Wpf;

namespace AyriaDesktop.Flyouts
{
    /// <summary>
    ///   Interaction logic for SettingsFlyout.xaml
    /// </summary>
    internal partial class SettingsFlyout : INotifyPropertyChanged
    {
        private bool _isDark;

        public SettingsFlyout()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void DarkButton_Toggled(object sender, RoutedEventArgs e)
        {
            _isDark = !_isDark;
            new PaletteHelper().SetLightDark(_isDark);
        }
    }
}
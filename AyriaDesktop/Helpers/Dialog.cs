// -----------------------------------------------------------
// Copyrights (c) 2016 Seditio 🍂 INC. All rights reserved.
// -----------------------------------------------------------

#region

using System;
using System.Windows;

using MahApps.Metro.Controls.Dialogs;

#endregion

namespace AyriaDesktop.Helpers
{
    internal static class Dialog
    {
        internal static async void ShowMessageDialog(string messageTitle, string message)
        {
            var m = new MetroDialogSettings
            {
                AffirmativeButtonText = "OK",
                AnimateShow = true,
                AnimateHide = true,
                SuppressDefaultResources = true,
                CustomResourceDictionary = new ResourceDictionary {Source = new Uri("pack://application:,,,/Resources/Themes/Dialogs.xaml")}
            };
            await ((MainWindow) Application.Current.MainWindow).ShowMessageAsync(messageTitle, message, MessageDialogStyle.Affirmative, m);
        }
    }
}
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

namespace Scouting_Application_2_complete.Views
{
    public sealed partial class ScoutingPage : Page, INotifyPropertyChanged
    {
        public ScoutingPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
        }

        private void TextBlock_SelectionChanged(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void DropDownButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void ToggleSwitch_Toggled(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}

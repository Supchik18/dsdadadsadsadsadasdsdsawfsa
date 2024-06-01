using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

namespace WpfApp1
{
    public static class ThemeManager
    {
        private static ResourceDictionary _currentTheme;

        static ThemeManager()
        {
            _currentTheme = new ResourceDictionary
            {
                Source = new Uri("LightTheme.xaml")
            };
            Application.Current.Resources.MergedDictionaries.Add(_currentTheme);
        }

        public static void ChangeTheme(string themeName)
        {
            Application.Current.Resources.MergedDictionaries.Remove(_currentTheme);

            if (themeName == "Dark")
            {
                _currentTheme = new ResourceDictionary
                {
                    Source = new Uri("\"pack://application:,,,/ThemeLibrary;component/YellowTheme.xaml")
                };
            }
            else
            {
                _currentTheme = new ResourceDictionary
                {
                    Source = new Uri("pack://application:,,,/ThemeLibrary;component/LightTheme.xaml")
                };
            }

            Application.Current.Resources.MergedDictionaries.Add(_currentTheme);
        }
    }
}
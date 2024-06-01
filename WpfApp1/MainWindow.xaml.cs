using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme("Dark");
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ThemeManager.ChangeTheme("Light");
        }

        private void savepract(object sender, RoutedEventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string filePath = Path.Combine(desktopPath, "json.json");

            File.WriteAllText(filePath, SerializationHelper.Serialize(block1.Text));
            MessageBox.Show("Данные сохранены");
        }

        private void loadpract(object sender, RoutedEventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "json.json");

            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                string deserializedData = SerializationHelper.Deserialize<string>(jsonData);

                Loading.Text = deserializedData;
            }
            else
            {
                Loading.Text = "Не удалось загрузить файл";
            }
        }
    }
}


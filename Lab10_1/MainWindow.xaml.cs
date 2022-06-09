using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab10_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Worker worker;
        public MainWindow()
        {
            InitializeComponent();
            worker = new Worker();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == false) return;
            ReadAsync(openFileDialog.FileName);
        }
        private async void ReadAsync(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                int i = 1;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    switch (i)
                    {
                        case 1: worker.Surname = line; break;
                        case 2: worker.Name = line; break;
                        case 3: worker.Patronymic = line; break;
                        case 4: worker.PostalCode = int.Parse(line); break;
                        case 5: worker.Country = line; break;
                        case 6: worker.Region = line; break;
                        case 7: worker.District = line; break;
                        case 8: worker.City = line; break;
                        case 9: worker.Street = line; break;
                        case 10: worker.House = line; break;
                        case 11: worker.Apartment = line; break;
                        case 12: worker.DateOfBirth = int.Parse(line); break;
                        case 13: worker.NumberWorkshop = int.Parse(line); break;
                        case 14: worker.ServiceNumber = int.Parse(line); break;
                        case 15: worker.Education = line; break;
                        case 16: worker.YearOfAdmissionToWork = int.Parse(line); break;                   
                    }
                    i++;
                }
                TextInput.Text = worker.ToString();
            }
        }

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == false) return;
            SaveAsync(saveFileDialog.FileName);
        }
        private async void SaveAsync(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                await writer.WriteLineAsync(TextInput.Text);
            }
        }
    }
}

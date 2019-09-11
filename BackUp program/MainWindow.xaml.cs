using Ionic.Zip;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BackUp_program
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

        MyLib my = new MyLib();
        bool ch = false, sh = false;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ch = true;
                pathNameBox.Text = folderBrowserDialog.SelectedPath;
                statusLabel.Content = "Выбрана директория: " + my.getname(pathNameBox.Text);
                copiedLabel.Content = "";
            }
        }

        private void FileChoose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ch = false;
                pathNameBox.Text = openFileDialog.FileName;
                statusLabel.Content = "Выбран файл: " + my.getname(pathNameBox.Text);
                copiedLabel.Content = "";
            }
        }

        bool progress = false;
        private void BackUp_botton_Click(object sender, RoutedEventArgs e)
        {
            string name = my.getname(pathNameBox.Text), folder = "./backup";

            progress = true;

            if (name == "")
            {
                copiedLabel.Foreground = new SolidColorBrush(Colors.Red);
                copiedLabel.Content = "Ошибка";
                statusLabel.Content = "Файлы не выбраны.";
            }
            else
            {
                using (ZipFile zip = new ZipFile())
                {
                    zip.AlternateEncoding = Encoding.UTF8;
                    zip.UseUnicodeAsNecessary = true;

                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);

                    if (sh == true && passBox.Text != "")
                    {
                        zip.Password = passBox.Text;
                    }

                    if (ch == true) zip.AddDirectory(pathNameBox.Text);
                    else zip.AddFile(pathNameBox.Text);

                    zip.Save(folder + "/" + name + my.gettime() + ".zip");
                    copiedLabel.Foreground = new SolidColorBrush(Colors.Green);
                    copiedLabel.Content = "Готово!";

                    pathNameBox.Text = "";
                    passBox.Text = "Пароль";
                    pass_checkbox.IsChecked = false;
                    passBox.IsEnabled = false;
                    sh = false;

                }
            }
        }

        private void ProgressBar_ValueChanged(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
            {
                progressBar.Value = e.EntriesSaved * 100 / e.EntriesTotal;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (pass_checkbox.IsChecked == true)
            {
                sh = true;
                passBox.Text = "";
                passBox.IsEnabled = true;
            }
        }
    }
}

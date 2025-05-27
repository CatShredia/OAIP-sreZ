using System;
using System.Collections.Generic;
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

namespace _3task
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
            double IMT = Convert.ToInt32(inputVesHuman.Text) / Convert.ToInt32(inputHeightHuman.Text) ^ 2;

            if(Convert.ToInt32(inputVesHuman.Text) > 100)
            {
                outputVes.Text = "У вас ожирение...";
            } else
            {
                outputVes.Text = "Вы в форме, ура !!!";
            }

            outputIMT.Text = "Ваш ИМТ: " + Convert.ToString(IMT);
        }
    }
}

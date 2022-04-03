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
using System.Windows.Shapes;

namespace Prilozenie_PP
{
    /// <summary>
    /// Логика взаимодействия для MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        private int SlideNum;
        public MainWin()
        {
            InitializeComponent();
        }
        //Надо личный ебануть "Рома харош ебланить" 
        private void LK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
            this.Close();
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            if (SlideNum != 1)
                SlideNum++;
            Change_Slide();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            if (SlideNum != -1)
                SlideNum--;
            Change_Slide();
        }
        private void Change_Slide()
        {
            if(SlideNum==-1)
                SlideImage.Source = new BitmapImage(new Uri("/image/Slide2.jpeg", UriKind.Relative));
            if (SlideNum == 0)
                SlideImage.Source = new BitmapImage(new Uri("/image/Slide1.jpeg", UriKind.Relative));
            if (SlideNum==1)
                SlideImage.Source = new BitmapImage(new Uri("/image/Slide3.jpg", UriKind.Relative));
        }
    }
}

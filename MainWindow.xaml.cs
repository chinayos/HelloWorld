using System;
using System.Collections.Generic;
using System.Data;
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
using OfficeOpenXml;
using System.IO;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using OfficeOpenXml.Drawing.Slicer.Style;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.Manual;
            {
                Left = 400;
                Top = 200;
            }
            // WindowStartupLocation = WindowStartupLocation.CenterScreen;// 窗体居中
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "测试文本 HelloWOrld！！"; //赋值给文本框
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = textBox.Text.ToString();//获取文本框的值
            string caption = "Word Processor";//定义弹出窗口标题text
            MessageBoxButton button = MessageBoxButton.YesNoCancel; //定义弹出窗口的按钮是“yes/no/cancel
            MessageBoxImage icon = MessageBoxImage.Warning;//定义弹出窗口的图标
            MessageBoxResult result; //获取弹出窗口返回的值

            result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes); //展示团出窗口的用法（显示文本， 标题文本， 按钮形式，图标，生成的值）
            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show(result + "你选择了YES", "显示上一个弹出窗口的选规则结果", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
                
            }
            else
            {
                if (result == MessageBoxResult.No)
                {
                    MessageBox.Show(result + "看来你选择了其他");
                }
                else
                {
                    MessageBox.Show(result + "原来你选择了“Canel”！","SHOW you choose" ,MessageBoxButton.OK, MessageBoxImage.Exclamation); 
                }
            }
            
        }
    }

}

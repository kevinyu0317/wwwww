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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            List1.Text = "One Direction";
            List2.Text = "Maroon 5";
            List3.Text = "Linkin Park";
            List4.Text = "The Beatles";
            List5.Text = "頑童MJ116";
            List6.Text = "飛輪海";
            List7.Text = "棒棒堂";
            List8.Text = "5566";

        }
        private void Chinese_Click(object sender, RoutedEventArgs e)
        {
            // 宣告隨機物件
            Random RD = new Random();
            // 宣告陣列
            string[] Chinese1 = { "頑童MJ116", "飛輪海", "棒棒堂", "5566" };

            for (int i = 0; i < Chinese1.Length; i++)
            {
                string temp = Chinese1[i];

                // 將第隨機個元素放到目前位置（交換)
                int r = RD.Next(0, Chinese1.Length);
                Chinese1[i] = Chinese1[r];

                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                Chinese1[r] = temp;
                Chinese.Text = Chinese1[r].ToString();
            }
        }
        private void English_Click(object sender, RoutedEventArgs e)
        {
            // 宣告隨機物件
            Random RD1 = new Random();
            // 宣告陣列
            string[] English1 = { "One Direction", "Maroon 5", "Linkin Park", "The Beatles" };

            for (int i = 0; i < English1.Length; i++)
            {
                string temp = English1[i];

                // 將第隨機個元素放到目前位置（交換)
                int r = RD1.Next(0, English1.Length);
                English1[i] = English1[r];

                // 將備份的元素放到剛才那隨機的位置上（完成交換）
                English1[r] = temp;
                English.Text = English1[r].ToString();
            }
        }
    }
}

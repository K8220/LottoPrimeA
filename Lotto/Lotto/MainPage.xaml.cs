using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LottoPrime
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buttonDraw_Click(object sender, RoutedEventArgs e)
        {
            int i = int.Parse(boxNumbers.Text);
            Random random = new Random();
            string rows = "";

            List<int> numbers = new List<int> { };
            for (int j = 1; i >= j; j++)
            {
                rows += "Row " + j.ToString("00") + ":  ";
                for (int k = 0; k < 7; k++)
                {
                    int number = random.Next(1, 40 + 1);
                    numbers.Add(number);
                }
                numbers.Sort();
                foreach (int number in numbers)
                {
                    rows += number.ToString("00") + " ";
                }
                numbers.Clear();
                rows += "\n";
            }
            rowsBlock.Text = rows;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            rowsBlock.Text = "";
        }
    }
}
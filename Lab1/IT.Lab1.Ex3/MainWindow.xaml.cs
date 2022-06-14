using System;
using System.Windows;

namespace IT.Lab1.Ex2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            string line=testInput.Text;
            line = line.Replace(",", " y:");
            line = "x:" + line;
            formattedText.Text = line;
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            // Buffer to hold a line read from the file on standard input
            string line;
            // Loop until the end of the file
            while ((line = Console.ReadLine()) != null)
            {
                // Format the data in the buffer
                line = line.Replace(",", " y:");
                line = "x:" + line + "\n";
                // Put the results into the TextBlock
                formattedText.Text += line;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace AiProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] labirynthGraph;
        public MainWindow()
        {
            InitializeComponent();

            labirynthGraph = new string[10];
            try
            {
                int i = 0;
                string[] lines = File.ReadAllLines("../Labirynth.txt");
                List<string> graphList = new List<string>();

                foreach (string line in lines)
                {
                    graphList.Add(line);
                }

                foreach (string line in graphList)
                {

                    Test.Text += line + '\n';
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
    }
}

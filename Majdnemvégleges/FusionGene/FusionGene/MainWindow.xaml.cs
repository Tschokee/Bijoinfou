
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using FusionGeneDatabase;
using FusionGene;
using System.Windows.Forms;

namespace FusionGene
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int Deviation { get; set; }
        bool StopItOrNot { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            StopItOrNot = true;
            StreamWriter writer = new StreamWriter(textBox3.Text + "\\Output.txt");
            GeneDatabase g1 = new GeneDatabase(textBox1.Text);
            GeneDatabase g2 = new GeneDatabase(textBox2.Text);
            for (int i = 0; i < g1.count() - 1; i++)
            {
                for (int j = i + 1; j < g1.count(); j++)
                {
                    for (int k = 0; k < g2.count(); k++)
                    {
                        if (Algoritmus.algorithm(g1.getGene(i).getGeneString(), g1.getGene(j).getGeneString(), g2.getGene(k).getGeneString(), Deviation))
                        {
                            writer.WriteLine(g2.getGene(k).getId() + " : " + g1.getGene(i).getId() + " , " + g1.getGene(j).getId());
                        }
                        if (!StopItOrNot)
                        {
                            System.Windows.MessageBox.Show("Stopped by user!");
                            writer.Close();
                            return;
                        }
                    }
                }
            }
            //			Application.EnableVisualStyles();
            //			Application.SetCompatibleTextRenderingDefault(false);
            //			Application.Run(new MainForm());
            //Algoritmus.algorithm();
            System.Windows.MessageBox.Show("Fusion gene searshing is ready!");
            writer.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Deviation = Convert.ToInt32(textBox4.Text);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".fasta";
            dlg.Filter = "Fasta files (.fasta)|*.fasta";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                textBox1.Text = filename;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension
            dlg.DefaultExt = ".fasta";
            dlg.Filter = "Fasta files (.fasta)|*.fasta";

            // Display OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                textBox2.Text = filename;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            // Set filter for file extension and default file extension
            fbd.SelectedPath = "C:\\";
            

            // Display OpenFileDialog by calling ShowDialog method
            DialogResult result = fbd.ShowDialog();

            // Get the selected file name and display in a TextBox
            if (result.ToString() == "OK")
            {
                // Open document
                textBox3.Text = fbd.SelectedPath;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            StopItOrNot = false;
        }
    }
}

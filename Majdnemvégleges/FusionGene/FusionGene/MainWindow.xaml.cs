
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
using System.Threading;

namespace FusionGene
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class algorithm 
	{
    	string s1 {get;set;}
    	string s2 {get;set;}
    	string s3 {get;set;}
    	string s4 {get;set;}
        System.Windows.Controls.Label lb;
    	public algorithm(string p1, string p2, string p3, string p4, System.Windows.Controls.Label lb)
    	{
    		s1 = p1;
    		s2 = p2;
    		s3 = p3;
    		s4 = p4;
            this.lb = lb;
    	}
    	
		
        public void futtat()
        {
        	int Deviation, Counter;
        	Counter = 0;
        	StreamWriter writer = new StreamWriter(s3 + "\\Output.txt");
        	GeneDatabase g1 = new GeneDatabase(s1);
        	GeneDatabase g2 = new GeneDatabase(s2);
        	Deviation = Convert.ToInt32(s4);
        	
        	for (int i = 0; i < g1.count() - 1; i++)
        	{lb.Content = i+"/"+g1.count().ToString();
        		for (int j = i + 1; j < g1.count(); j++)
        		{
        			for (int k = 0; k < g2.count(); k++)
                    {
                        
        				if (Algoritmus.algorithm(g1.getGene(i).getGeneString(), g1.getGene(j).getGeneString(), g2.getGene(k).getGeneString(), Deviation))
        				{
        					writer.WriteLine(g2.getGene(k).getId() + " : " + g1.getGene(i).getId() + " , " + g1.getGene(j).getId());
        					Counter++;
        				}
        			}
        		}
        	}
        	System.Windows.MessageBox.Show("Fusion gene searching finished! " + Counter + " gene(s) were found!");
        	writer.Close();
        }
	}
    
    public partial class MainWindow : Window
    {
    	Thread thr;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Work in progress!");
            algorithm a = new algorithm(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,progress);
            thr = new Thread( new ThreadStart(a.futtat));  
            
            thr.Start();
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
		
		void button4_Click(object sender, RoutedEventArgs e)
		{
			thr.Abort();
		}
    }
}

/*
 * Created by SharpDevelop.
 * User: Juri
 * Date: 2012.11.27.
 * Time: 15:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using FusionGene;
using FusionGeneDatabase;
using System.IO;

namespace FusionGene
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			StreamWriter writer = new StreamWriter("Output.txt");
			GeneDatabase g1 = new GeneDatabase("ACLA.fasta");
			GeneDatabase g2 = new GeneDatabase("AGOS1.fasta");
			for(int i = 0 ; i < g1.count() - 1 ; i++)
			{
				for(int j = i + 1 ; j < g1.count() ; j++)
				{
					for(int k = 0 ; k < g2.count() ; k++)
					{
						if(Algoritmus.algorithm(g1.getGene(i).getGeneString(), g1.getGene(j).getGeneString(), g2.getGene(k).getGeneString(), 200))
						{
							writer.WriteLine(g2.getGene(k).getId() + " : " + g1.getGene(i).getId() + " , " + g1.getGene(j).getId());
						}
					}
				}
			}
//			Application.EnableVisualStyles();
//			Application.SetCompatibleTextRenderingDefault(false);
//			Application.Run(new MainForm());
			//Algoritmus.algorithm();
			writer.Close();
		}
		
	}
}

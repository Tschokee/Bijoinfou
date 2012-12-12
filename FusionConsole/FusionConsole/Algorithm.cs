using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FusionGeneDatabase;



using System.IO;
using FusionGene;
namespace FusionConsole
{
    public class algorithm
    {
        string s1 { get; set; }
        string s2 { get; set; }
      
        string s4 { get; set; }
        
        public algorithm(string p1, string p2, string p4)
        {
            s1 = p1;
            s2 = p2;
            
            s4 = p4;
           
        }


        public void futtat()
        {
            int Deviation, Counter;
            Counter = 0;
            StreamWriter writer = new StreamWriter("Output.txt");
            GeneDatabase g1 = new GeneDatabase(s1);
            GeneDatabase g2 = new GeneDatabase(s2);
            
            Deviation = Convert.ToInt32(s4);

            for (int i = 0; i < g1.count() - 1; i++)
            {
                System.Console.Clear();
                System.Console.WriteLine(i + "\\" + g1.count());
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
            System.Console.WriteLine("Fusion gene searching finished! " + Counter + " gene(s) were found!");
            writer.Close();
        }
    }
}

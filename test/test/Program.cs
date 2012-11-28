
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FusionGeneDatabase;

namespace test
{
    

    class Program
    {
        static void Main(string[] args)
        {

            GeneDatabase geneDatabase = new GeneDatabase(@"..\..\..\..\Acralc1.fasta");
            for (int i = 0; i < geneDatabase.count(); i++)
            {
               Console.WriteLine(geneDatabase.getGene(i).getId());
               Console.WriteLine(geneDatabase.getGene(i).getGeneString());
            }
        
        
        }
    }
}

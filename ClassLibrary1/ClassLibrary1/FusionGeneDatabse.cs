using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FusionGeneDatabase
{
    public class Gene
    {
        private string id;
        private StringBuilder GeneString = new StringBuilder();
        public Gene(String id)
        {
            this.id = id;

        }
        public void addGeneSequence(string sequence)
        {
            this.GeneString.Append(sequence);


        }
        public string getId()
        {
            return this.id;
        }
        public string getGeneString()
        {
            return this.GeneString.ToString();
        }
    }
    public class GeneDatabase
    {
        private List<Gene> database = new List<Gene>();
        public GeneDatabase(string file)
        {
            string[] lines = System.IO.File.ReadAllLines(@file);

            foreach (string line in lines)
            {
                if (line.Contains(">"))
                {
                    Gene gene = new Gene(line.Replace("\n", string.Empty));
                    database.Add(gene);
                }
                else
                {
                    database.ElementAt(database.Count() - 1).addGeneSequence(line.Replace("\n", string.Empty));
                }
            }


        }
        private void addGene(Gene gene)
        {
            this.database.Add(gene);

        }
        public Gene getGene(int id)
        {
            return database.ElementAt(id);
        }
        public double count()
        {

            return database.Count();
        }


    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionGeneDatabase
{
    interface IFusionDatabase<T>
    {
        
         T getGene(int id);
    }
}

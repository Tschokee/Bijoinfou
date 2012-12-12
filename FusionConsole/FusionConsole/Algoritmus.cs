/*
 * Created by SharpDevelop.
 * User: Juri
 * Date: 2012.11.27.
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FusionGene;
using FusionGeneDatabase;

namespace FusionGene
{
    class Algoritmus
    {
        public static bool algorithm(string s1, string s2, string f, int h)
        {
            int i, j, k, kuszob1 = 0, kezdo1 = -1, kezdo2 = -1;
            if ((s1.Length + s2.Length) > f.Length)
                return false;
            for (i = 0; i < f.Length - s1.Length; i++)
            {
                k = 0;
                kuszob1 = h;
                for (j = i; j < s1.Length + i; j++, k++)
                {
                    if (!f[j].Equals(s1[k]))
                        kuszob1--;
                    if (kuszob1 < 0)
                        break;
                    if (k + 1 == s1.Length)
                        kezdo1 = i;
                }
                if (kezdo1 != -1)
                    break;
            }
            for (i = 0; i < f.Length - s2.Length; i++)
            {
                k = 0;
                for (j = i; j < s2.Length + i; j++, k++)
                {
                    if (!f[j].Equals(s2[k]))
                        kuszob1--;
                    if (kuszob1 < 0)
                        break;
                    if (k + 1 == s2.Length)
                        kezdo2 = i;
                }
                if (kezdo2 != -1)
                    break;
            }
            if (kezdo1 == -1 || kezdo2 == -1)
                return false;
            if (Math.Abs((kezdo1 + s1.Length) - kezdo2) -  kuszob1 > h)
                return false;
            if (Math.Abs((kezdo2 + s2.Length) - kezdo1) -  kuszob1 > h)
                return false;
            return true;
        }
    }
}

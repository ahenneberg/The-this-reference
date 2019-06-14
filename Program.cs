/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_this_reference
{
    /* The this reference refers to the instance itself. In the 
     following example, the Marry method uses this to set the 
     partner's mate field: */
    public class Panda
    {
        public Panda Mate;
        public void Marry (Panda partner)
        {
            Mate = partner;
            partner.Mate = this;
        }
    }
    /* The this reference also disambiguates a local variable
    or parameter from a field. For example: */
    public class Test
    {
        string name;
        public Test(string name) { this.name = name; }
        /* The this reference is valid only within nonstatic
         members of a class or struct. */
    }
    class Program
    {
        static void Main()
        {

        }
    }
}

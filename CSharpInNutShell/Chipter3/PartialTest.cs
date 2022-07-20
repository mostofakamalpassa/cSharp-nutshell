using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    public partial class PartialTest
    {



         partial void IsValid(string identifier);
         partial void TryParse(string number,  int result);
         partial void M1(); // Extended partial method
         partial void M2(); // Extended partial method
    }
}

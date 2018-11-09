using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNG.Utilities.Samples
{
  class Program
  {
    static void Main(string[] args)
    {
      Util.AppendFile("charges.csv", "C-20181109-01", DateTime.Now, 955.2);
      Util.AppendFile("charges.csv", "C-20181109-02", DateTime.Now, 738.9);
      Util.AppendFile("charges.csv", "C-20181109-03", DateTime.Now, 629.6);
    }
  }
}

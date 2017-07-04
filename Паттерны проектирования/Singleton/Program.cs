using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {

            Logger.Instance.Write("Preved, Medved");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var wizard = new InstallationWizard();

            wizard.GoNext();

            wizard.GoNext();
            
            wizard.Cancel();

            Console.ReadLine();
        }
    }
}

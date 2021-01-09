using InterfaceSegregationPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
// The interface-segregation principle(ISP) states that "no client should be forced to depend on methods it does not use".
// This means, instead of one fat interface many small interfaces are preferred based on groups of methods with each one serving one sub-module.
// The ISP was first used and formulated by Robert C.Martin while consulting for Xerox.
    class HPLaserJet : IPrintScanContent, IFaxContent, IPrintDuplex
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }
}

namespace ISPDemoConsole.Client
{
    class CannonMG2470 : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}

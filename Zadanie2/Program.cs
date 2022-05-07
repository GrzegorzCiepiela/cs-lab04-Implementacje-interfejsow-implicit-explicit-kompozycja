using System;
using ver1;
using Zadanie1;
using Zadanie2;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            var xerox = new MultiFunctionalDevice();
            xerox.PowerOn();
            IDocument doc1 = new PDFDocument("aaa.pdf");
            xerox.Print(in doc1);

            IDocument doc2;
            xerox.Scan(out doc2);

            xerox.ScanAndPrint();
            System.Console.Write("Liczba uruchomień kserokopiarki: ");
            System.Console.WriteLine(xerox.Counter);
            System.Console.Write("Liczba wydrukowanych dokumentow: ");
            System.Console.WriteLine(xerox.PrintCounter);
            System.Console.Write("Liczba zeskanowanych dokumentow: ");
            System.Console.WriteLine(xerox.ScanCounter);


            System.Console.WriteLine(" \n");
            

            xerox.ScanAndPrintAndFax("fax receiver");
            System.Console.Write("Liczba uruchomień kserokopiarki: ");
            System.Console.WriteLine(xerox.Counter);
            System.Console.Write("Liczba wydrukowanych dokumentow: ");
            System.Console.WriteLine(xerox.PrintCounter);
            System.Console.Write("Liczba zeskanowanych dokumentow: ");
            System.Console.WriteLine(xerox.ScanCounter);
            System.Console.Write("Liczba wyslanych Fax: ");
            System.Console.WriteLine(xerox.FaxCounter);
        }
    }
}

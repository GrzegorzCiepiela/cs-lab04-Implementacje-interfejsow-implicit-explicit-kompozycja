using System;
using ver1;

namespace Zadanie1
{
    class Program
    {
        static void Main()
        {
            var xerox = new Copier();
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
        }
    }
}

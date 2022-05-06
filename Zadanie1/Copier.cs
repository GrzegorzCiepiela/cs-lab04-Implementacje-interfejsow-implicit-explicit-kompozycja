﻿using System;
using System.Collections.Generic;
using System.Text;
using ver1;

namespace Zadanie1
{
    public class Copier : BaseDevice, IPrinter, IScanner
    {
        public int PrintCounter { get; set; }
        public int ScanCounter { get; set; }
        public new int Counter { get; set; }
        public void Print(in IDocument document)
        {
            if (state == IDevice.State.on)
            {
                PrintCounter++;
                Console.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss} Print: {document.GetFileName()}");
            }
        }

        public void Scan(out IDocument document, IDocument.FormatType formatType = IDocument.FormatType.PDF)
        {
            document = null;

            if (GetState() == IDevice.State.on)
            {
                switch (formatType)
                {
                    case IDocument.FormatType.PDF:
                        document = new PDFDocument($"PDFScan{ScanCounter}.pdf");
                        break;

                    case IDocument.FormatType.JPG:
                        document = new ImageDocument($"ImageScan{ScanCounter}.jpg");
                        break;

                    case IDocument.FormatType.TXT:
                        document = new TextDocument($"TextScan{ScanCounter}.txt");
                        break;
                }

                Console.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm:ss} Scan: {document.GetFileName()}");
                ScanCounter++;

            }
        }
        public void ScanAndPrint()
        {
            if (GetState() == IDevice.State.on)
            {
                Scan(out IDocument document);
                Print(in document);
            }
        }

        public new void PowerOn()
        {
            if (GetState() == IDevice.State.off)
            {
                Counter++;
                base.PowerOn();
            }
        }
    }
}


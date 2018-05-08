using Task5.Solution.Entities;
using Task5.Solution.Entities.DocumentParts;
using Task5.Solution.Entities.DocumentParts.Base;
using Task5.Solution.Entities.Extensions;

namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
            {
                new PlainText {Text = "Some plain text"},
                new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                new BoldText {Text = "Some bold text"}
            };

            Document document = new Document(parts);

            foreach (var part in document.ConnvertToHtml())
            {
                Console.WriteLine(part);
            }

            Console.WriteLine();

            foreach (var part in document.ConnvertToPlainText())
            {
                Console.WriteLine(part);
            }

            Console.WriteLine();

            foreach (var part in document.ConnvertToLaText())
            {
                Console.WriteLine(part);
            }

            Console.ReadLine();
        }
    }
}

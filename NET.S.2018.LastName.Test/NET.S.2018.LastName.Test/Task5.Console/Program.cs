using Task5.Solution;

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
                    new DataText(x =>  "\\textbf{" + x + "}") {Text = "Some plain text"},
                    new HtmlText(x => "<b>" + x + "</b>") {Text = "google.com", Url = "https://www.google.by/"},
                    new DataText(x => "**" + x + "**") {Text = "Some bold text"}
                };

            Document document = new Document(parts);

            Console.WriteLine(document.Convert());           

            Console.ReadLine();
        }
    }
}

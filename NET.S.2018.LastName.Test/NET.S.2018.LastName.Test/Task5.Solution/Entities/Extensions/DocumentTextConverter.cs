using System.Collections.Generic;
using Task5.Solution.Entities.Visitors;

namespace Task5.Solution.Entities.Extensions
{
    public static class DocumentConverter
    {
        public static IEnumerable<string> ConnvertToHtml (this Document document)
        {
            var htmlVisitor = new HtmlTextVisitor();

            foreach (var part in document.Parts)
            {
                part.Accept(htmlVisitor);

                yield return htmlVisitor.ConvertedText;
            }
        }

        public static IEnumerable<string> ConnvertToPlainText(this Document document)
        {
            var htmlVisitor = new PlainTextVisitor();

            foreach (var part in document.Parts)
            {
                part.Accept(htmlVisitor);

                yield return htmlVisitor.ConvertedText;
            }
        }

        public static IEnumerable<string> ConnvertToLaText(this Document document)
        {
            var htmlVisitor = new LaTextVisitor();

            foreach (var part in document.Parts)
            {
                part.Accept(htmlVisitor);

                yield return htmlVisitor.ConvertedText;
            }
        }
    }
}
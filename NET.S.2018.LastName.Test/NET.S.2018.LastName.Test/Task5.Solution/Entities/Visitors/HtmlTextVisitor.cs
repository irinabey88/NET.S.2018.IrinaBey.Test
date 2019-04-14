using System;
using Task5.Solution.Entities.DocumentParts;
using Task5.Solution.Interfaces;

namespace Task5.Solution.Entities.Visitors
{
    public class HtmlTextVisitor : ITextVisitor
    {
        public string ConvertedText { get; private set; }

        public void Visit(BoldText text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this.ConvertedText = "<b>" + text.Text + "</b>";
        }

        public void Visit(PlainText text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this.ConvertedText = text.Text;
        }

        public void Visit(Hyperlink text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            this.ConvertedText = "<a href=\"" + text.Url + "\">" + text.Text + "</a>";
        }
    }
}
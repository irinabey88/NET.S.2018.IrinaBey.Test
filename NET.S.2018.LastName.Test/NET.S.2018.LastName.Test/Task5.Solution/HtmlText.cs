using System;

namespace Task5.Solution
{
    public class HtmlText : DocumentPart
    {
        private Func<string, string> _convertFunc;

        public HtmlText(Func<string, string> convertFunc)
        {
            this._convertFunc = convertFunc ?? throw new ArgumentNullException(nameof(convertFunc));
        }

        public string Url { get; set; }

        public override string Convert()
        {

            var inputStr = "<a href=\"" + this.Url + "\">" + this.Text + "</a>";

            return this._convertFunc(inputStr);
        }
    }
}
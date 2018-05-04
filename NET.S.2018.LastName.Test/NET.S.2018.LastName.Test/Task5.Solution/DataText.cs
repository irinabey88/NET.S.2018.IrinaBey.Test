using System;

namespace Task5
{
    public class DataText : DocumentPart
    {
        private Func<string, string> _convertFunc;

        public DataText(Func<string, string> convertFunc) 
        {
            this._convertFunc = convertFunc ?? throw new ArgumentNullException(nameof(convertFunc));
        }

        public override string Convert()
        {
            return this._convertFunc(this.Text);
        }
    }
}
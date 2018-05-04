using System;
using System.Collections.Generic;
using Task5.Solution.Interfaces;

namespace Task5.Solution
{
    public class Document
    {
        private IEnumerable<DocumentPart> _parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }

            this._parts = parts;
        }

        public string Convert()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this._parts)
            {
                output += $"{part.Convert()}\n";
            }

            return output;
        }
    }
}
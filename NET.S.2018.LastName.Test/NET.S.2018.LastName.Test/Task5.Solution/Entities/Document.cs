using System;
using System.Collections.Generic;
using Task5.Solution.Entities.DocumentParts.Base;

namespace Task5.Solution.Entities
{
    public class Document
    {
        private List<DocumentPart> _parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this._parts = new List<DocumentPart>(parts);
        }

        public IEnumerable<DocumentPart> Parts => this._parts;
    }
}

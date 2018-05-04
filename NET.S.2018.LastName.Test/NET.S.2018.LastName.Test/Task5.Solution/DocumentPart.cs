using System;
using Task5.Solution.Interfaces;

namespace Task5
{
    public abstract class DocumentPart : IDataConverter
    {
        public string Text { get; set; }

        public abstract string Convert();
    }
}

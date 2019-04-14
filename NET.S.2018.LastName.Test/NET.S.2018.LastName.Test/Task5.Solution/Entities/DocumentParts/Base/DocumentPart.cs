using Task5.Solution.Interfaces;

namespace Task5.Solution.Entities.DocumentParts.Base
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        /// <summary>
        /// Execute custom logic for concrete child
        /// </summary>
        /// <param name="visitor">Provides custom logic</param>
        public void Accept(ITextVisitor visitor)
        {
            visitor.Visit((dynamic) this);
        }
    }
}

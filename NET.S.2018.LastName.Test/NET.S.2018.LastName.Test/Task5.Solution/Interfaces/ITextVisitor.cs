using Task5.Solution.Entities.DocumentParts;

namespace Task5.Solution.Interfaces
{
    /// <summary>
    /// Interface for realisation pattern Visitor
    /// </summary>
    public interface ITextVisitor
    {
        void Visit(BoldText text);

        void Visit(PlainText text);

        void Visit(Hyperlink text);
    }
}
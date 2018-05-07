using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace ReSharper.MinimalPlugin
{
    [StaticSeverityHighlighting(Severity.WARNING, HighlightingGroupIds.GutterMarksGroup)]
    public class ClassNameWarning : IHighlighting
    {
        readonly IClassDeclaration m_ClassDeclaration;
        readonly DocumentRange m_DocumentRange;

        public ClassNameWarning(IClassDeclaration classDeclaration, DocumentRange documentRange)
        {
            m_ClassDeclaration = classDeclaration;
            m_DocumentRange = documentRange;
        }

        public bool IsValid()
        {
            return m_ClassDeclaration.IsValid();
        }

        public DocumentRange CalculateRange()
        {
            return m_DocumentRange;
        }

        public string ToolTip => "Class name contains 'Foo'. Rename it immediately!";
        public string ErrorStripeToolTip => "Class name contains 'Foo'. Rename it immediately! Side bar.";
    }
}

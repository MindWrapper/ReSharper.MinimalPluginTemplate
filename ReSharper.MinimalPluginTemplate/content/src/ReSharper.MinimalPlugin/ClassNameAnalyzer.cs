using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace ReSharper.MinimalPlugin
{
    [ElementProblemAnalyzer(typeof(IClassDeclaration), HighlightingTypes = new[] { typeof(ClassNameWarning) })]
    public class ClassNameAnalyzer : ElementProblemAnalyzer<IClassDeclaration>
    {
        protected override void Run(IClassDeclaration element, ElementProblemAnalyzerData data, IHighlightingConsumer consumer)
        {
            if (element.DeclaredName.Contains("Foo"))
            {
                consumer.AddHighlighting(new ClassNameWarning(element, element.NameIdentifier.GetDocumentRange()));
            }
        }
    }
}


using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.FeaturesTestFramework.Daemon;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;

namespace ReSharper.MinimalPlugin.Tests
{
    [TestFixture]
    public class ClassNameAnalyzerTests : CSharpHighlightingTestBase
    {
        protected override string RelativeTestDataPath
        {
            get { return @"\"; }
        }

        protected override bool HighlightingPredicate(IHighlighting highlighting, IPsiSourceFile sourceFile)
        {
            return highlighting is ClassNameWarning;
        }

        [Test]
        public void TestBar()
        {
            DoNamedTest2();
        }

        [Test]
        public void TestFoo()
        {
            DoNamedTest2();
        }
    }
}

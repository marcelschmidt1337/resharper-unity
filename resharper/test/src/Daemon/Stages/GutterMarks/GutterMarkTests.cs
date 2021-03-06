using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.FeaturesTestFramework.Daemon;
using JetBrains.ReSharper.Plugins.Unity.Daemon.Stages.Highlightings;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Daemon.Stages.GutterMarks
{
    [TestUnity]
    public class GutterMarkTests : CSharpHighlightingTestBase
    {
        protected override string RelativeTestDataPath => @"Daemon\Stages\GutterMark";

        protected override bool HighlightingPredicate(IHighlighting highlighting, IPsiSourceFile sourceFile)
        {
            return highlighting is UnityMarkOnGutter;
        }

        [Test] public void Test01() { DoNamedTest(); }
    }
}
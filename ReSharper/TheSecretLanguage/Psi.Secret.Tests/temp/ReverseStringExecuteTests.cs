using JetBrains.ReSharper.Feature.Services.CSharp.Bulbs;
using JetBrains.ReSharper.Intentions.CSharp.Test;
using JetBrains.ReSharper.Intentions.Extensibility;
using NUnit.Framework;

namespace ReSharperSecretLanguage.Tests
{
    [TestFixture]
    public class ReverseStringExecuteTests : CSharpContextActionExecuteTestBase
    {
        protected override string ExtraPath
        {
            get
            {
                return "ReverseStringAction";
            }
        }

        protected override string RelativeTestDataPath
        {
            get
            {
                return "ReverseStringAction";
            }
        }

        [Test]
        public void ExecuteTest()
        {
            this.DoTestFiles("execute01.cs");
        }

        protected override IContextAction CreateContextAction(ICSharpContextActionDataProvider dataProvider)
        {
            return new ReverseStringAction(dataProvider);
        }
    }
}

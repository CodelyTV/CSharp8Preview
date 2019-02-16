using NUnit.Framework;

namespace Tests
{
    public class FeaturesPreviewTests
    {
        [Test]
        public void nullable_reference_types()
        {
            string hello = null;
            Assert.AreEqual(hello?[0], null);
        }
    }
}
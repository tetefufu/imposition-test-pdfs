using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void CanGetTestPdf()
        {
            var filePath = imposition_test_pdfs.Tests.File("A4.bleed0mm.pdf");

            Assert.That(filePath, Is.Not.Null.Or.Empty);

            FileAssert.Exists(filePath);
        }
    }
}
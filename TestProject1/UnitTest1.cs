using FirstOOP;
namespace MyFirstTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Kuh myKuh = new Kuh("paula", "Schwarz");
            Assert.That(myKuh.Name, Is.EqualTo("Paula"));
        }
    }
}

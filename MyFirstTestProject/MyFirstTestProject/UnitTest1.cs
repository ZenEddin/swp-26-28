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
            Assert.Equals(1, 1);
            Assert.Pass();
        }
    }
}

namespace HelloTest101
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test01()
        {
            Assert.Pass();
        }

        [Test]
        public void Test02()
        {
            Assert.Fail();
        }
    }
}
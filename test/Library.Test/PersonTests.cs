using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Lucas", "5.480.931-3","24/4/1996");
            string expected = "Lucas";
            Assert.AreEqual(expected, p.Name);
        }

        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Lucas", "5.480.931-3","24/4/1996");
            string expected = "5.480.931-3";
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestBirthday() // Cambiá el nombre para indicar qué estás probando
        {
            Person p = new Person("Lucas", "5.480.931-3","24/04/1996");
            string expected = "24/04/1996";
            Assert.AreEqual(expected, p.Birthday);
        }
    }
}
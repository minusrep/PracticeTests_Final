using Practice_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_FinalTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void GetName_StandardName_ReturnsJohn()
        {
            var user = new User("John", 25);
            string name = user.Name;
            Assert.AreEqual("John", name);
        }

        [TestMethod]
        public void GetName_EmptyName_ReturnsHuman()
        {
            User user = new User("", 25);
            string name = user.Name;
            Assert.AreEqual("Human", name);
        }

        [TestMethod]
        public void GetName_NameWithDigits_ReturnsJohn01()
        {
            User user = new User("John01", 25);
            string name = user.Name;
            Assert.AreEqual("John01", name);
        }

        [TestMethod]
        public void GetAge_StandardAge_Returns25()
        {
            User user = new User("John", 25);
            int age = user.Age;
            Assert.AreEqual(25, age);
        }

        [TestMethod]
        public void GetAge_NegativeAge_Returns25()
        {
            User user = new User("John", -25);
            int age = user.Age;
            Assert.AreEqual(25, age);
        }

        [TestMethod]
        public void GetAge_LargeAge_Returns159()
        {
            User user = new User("John", 159);
            int age = user.Age;
            Assert.AreEqual(159, age);
        }

        [TestMethod]
        public void IncreaseAge_StandardAge_IncreasesTo26()
        {
            User user = new User("John", 25);
            user.IncreaseAge();
            int age = user.Age;
            Assert.AreEqual(26, age);
        }

        [TestMethod]
        public void IncreaseAge_ZeroAge_IncreasesTo1()
        {
            User user = new User("John", 0);
            user.IncreaseAge();
            int age = user.Age;
            Assert.AreEqual(1, age);
        }

        [TestMethod]
        public void IncreaseAge_Twice_IncreasesTo27()
        {
            User user = new User("John", 25);
            user.IncreaseAge();
            user.IncreaseAge();
            int age = user.Age;
            Assert.AreEqual(27, age);
        }

        [TestMethod]
        public void IncreaseAge_LargeAge_IncreasesTo160()
        {
            User user = new User("John", 159);
            user.IncreaseAge();
            int age = user.Age;
            Assert.AreEqual(160, age);
        }
    }
}

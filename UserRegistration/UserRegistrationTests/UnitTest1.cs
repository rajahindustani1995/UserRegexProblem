using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Rajesh", "Rajesh")]
        [DataRow("Ra", null)]
         
        [DataRow("Ambavale", "Ambavale")]
        [DataRow("A", null)]
        public void Name(string a, string expected)
        {
            RegisterForTests register = new RegisterForTests();
            string actual = register.Name(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        public void Email(string a, string expected)
        {
            RegisterForTests register = new RegisterForTests();

            string actual = register.Email(a);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("9 9967872990", "9 9967872990")]
        [DataRow("91 9967872990", "91 9967872990")]
        [DataRow("1 1000987267", null)]
        [DataRow("919967872990", null)]
        [DataRow("91 996787", null)]
        public void MobileNumber(string a, string expected)
        {
            RegisterForTests validate = new RegisterForTests();

            string actual = validate.Mobile(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("9D*jkscu", "9D*jkscu")]
        [DataRow("S&dfhkkdkwn", null)]
        [DataRow("123sdf34", null)]
        public void Password(string a, string expected)
        {
            RegisterForTests register  = new RegisterForTests();

            string actual = register.Password(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
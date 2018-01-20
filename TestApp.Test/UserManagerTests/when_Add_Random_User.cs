using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestApp.Manager;

namespace TestApp.Test.GenerateRandomItemTests
{
    [TestFixture()]
    public class when_Add_Random_User
    {
        private Mock<IGenerateRandomItem> _mockedGenerateRandomItem;

        private UserManager _userManager;

        [SetUp]
        public void Setup()
        {
            _mockedGenerateRandomItem=new Mock<IGenerateRandomItem>();

            _userManager = new UserManager(_mockedGenerateRandomItem.Object);
        }

        [Test]
        public void Should_Set_Name_Properly()
        {
            _mockedGenerateRandomItem
                .Setup(x => x.GenerateRandomString())
                .Returns("cumhur");

            string result=_userManager.AddRandomUser(1).FirstOrDefault().Name;

            result.Should().Be("cumhur");
        }

        [Test]
        public void Should_Set_LastName_Properly()
        {
            _mockedGenerateRandomItem
                .Setup(x => x.GenerateRandomString())
                .Returns("duzlu");

            string result = _userManager.AddRandomUser(1).FirstOrDefault().LastName;

            result.Should().Be("duzlu");
        }


        [Test]
        public void Should_Set_Age_Properly()
        {
            _mockedGenerateRandomItem
                .Setup(x => x.generateRandomAge())
                .Returns(20);

            short result = _userManager.AddRandomUser(1).FirstOrDefault().Age;

            result.Should().Be(20);
        }


        [Test]
        public void Should_Set_PhoneNumber_Properly()
        {
            _mockedGenerateRandomItem
                .Setup(x => x.generateRandomPhoneNumber())
                .Returns(1234567890);

            int result = _userManager.AddRandomUser(1).FirstOrDefault().PhoneNumber;

            result.Should().Be(1234567890);
        }

        [Test]
        public void Should_Return_Specify_Number_Of_User()
        {
            int result = _userManager.AddRandomUser(10).Count();

            result.Should().Be(10);
        }
    }
}

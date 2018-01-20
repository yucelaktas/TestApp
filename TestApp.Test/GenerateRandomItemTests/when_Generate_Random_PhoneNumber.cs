using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using TestApp.Manager;

namespace TestApp.Test.GenerateRandomItemTests
{
    [TestFixture]
    public class when_Generate_Random_PhoneNumber
    {
        private GenerateRandomItem _generateRandomItem;

        [SetUp]
        public void Setup()
        {
            _generateRandomItem = new GenerateRandomItem();
        }

        public void Should_Result_Length_Is_10()
        {
            int result = _generateRandomItem.generateRandomPhoneNumber().ToString().Length;

            result.Should().Be(10);
        }

        public void Should_Result_Start_With_Zero()
        {
            bool result = _generateRandomItem.generateRandomPhoneNumber().ToString().StartsWith("0");

            result.Should().BeTrue();
        }


    }
}

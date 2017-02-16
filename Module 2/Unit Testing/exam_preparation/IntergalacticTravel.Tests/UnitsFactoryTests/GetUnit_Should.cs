using IntergalacticTravel.Exceptions;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests.UnitsFactoryTests
{
    [TextFixture]
    public class GetUnit_Should
    {
        [Test]        
        [TestCase("create unit Procyon Gosho 1")]        
        public void ReturnProperNewProcyonUnit_WhenCorrectCreateUnitCommandPassed(string command)
        {
            // Arrange            
            var factory = new UnitsFactory();

            // Act
            var actual = factory.GetUnit(command);

            //Assert
            Assert.That(actual, Is.InstanceOf<Procyon>());
        }

        [Test]
        [TestCase("create unit Luyten Pesho 2")]
        public void ReturnProperNewLuytenUnit_WhenCorrectCreateUnitCommandPassed(string command)
        {
            // Arrange            
            var factory = new UnitsFactory();

            // Act
            var actual = factory.GetUnit(command);

            //Assert
            Assert.That(actual, Is.InstanceOf<Luyten>());
        }

        [Test]
        [TestCase("create unit Lacaille Tosho 3")]
        public void ReturnProperNewLacailleUnit_WhenCorrectCreateUnitCommandPassed(string command)
        {
            // Arrange            
            var factory = new UnitsFactory();

            // Act
            var actual = factory.GetUnit(command);

            //Assert
            Assert.That(actual, Is.InstanceOf<Lacaille>());
        }        

        [Test]
        [TestCase("creaXXXte unXXit LaXXcaille TXXosho 3XX")]
        [TestCase("")]
        public void ThrowInvalidUnitCreationCommandException_WhenInvalidCreateUnitCommandPassed(string command)
        {
            // Arrange
            var factory = new UnitsFactory();

            // Act & Assert
            Assert.That(() => factory.GetUnit(command), 
                   Throws.TypeOf<InvalidUnitCreationCommandException>());
        }
    }
}

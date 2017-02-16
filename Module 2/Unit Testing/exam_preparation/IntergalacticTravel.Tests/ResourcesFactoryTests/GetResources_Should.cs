namespace IntergalacticTravel.Tests.ResourcesFactoryTests
{
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class GetResources_Should
    {
        [Test]
        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources gold(20) bronze(40) silver(30)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void ReturnProperNewResourcesObject_WhenCorrectPropertiesPassed(string command)
        {
            // Arrange
            var factory = new ResourcesFactory();
            var properties = command.Split(' ').Where(s => (s.Split('(')[0].ToLower() == "gold") ||
            (s.Split('(')[0].ToLower() == "silver") || (s.Split('(')[0].ToLower() == "bronze"));

            foreach (var item in properties)
            {

            }


            // Act
            var actual = factory.GetResources(command);

            // Assert
            Assert.That(actual, Is.InstanceOf<Resources>());            
        }
    }
}

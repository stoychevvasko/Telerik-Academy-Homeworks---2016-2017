//// <copyright file="Constructor_Should.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Tests.Core.Models.Potato
{
    using NUnit.Framework;

    [TestFixture]
    internal class Constructor_Should
    {
        [Test]
        public void CreateValidInstance_WhenInvoked()
        {
            var actual = new Task1.Core.Models.Potato();

            Assert.That(actual, Is.InstanceOf<Task1.Core.Models.Potato>());
        }
    }
}

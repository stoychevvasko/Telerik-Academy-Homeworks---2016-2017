//// <copyright file="GetPotato_Should.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Tests.Core.Factories.KitchenFactory
{
    using NUnit.Framework;
    using Task1.Core.Factories;

    [TestFixture]
    internal class GetPotato_Should
    {
        [Test]
        public void CreateValidPotato_WhenInvoked()
        {
            var actual = KitchenFactory.Instance.GetPotato();

            Assert.That(actual, Is.InstanceOf<Task1.Core.Models.Potato>());
        }
    }
}

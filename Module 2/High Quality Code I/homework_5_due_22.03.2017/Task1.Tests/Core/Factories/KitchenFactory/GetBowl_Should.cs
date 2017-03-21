//// <copyright file="GetBowl_Should.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task1.Tests.Core.Factories.KitchenFactory
{
    using NUnit.Framework;
    using Task1.Core.Factories;

    [TestFixture]
    internal class GetBowl_Should
    {
        [Test]
        public void CreateValidBowl_WhenInvoked()
        {
            var actual = KitchenFactory.Instance.GetBowl();

            Assert.That(actual, Is.InstanceOf<Task1.Core.Models.Bowl>());
        }
    }
}

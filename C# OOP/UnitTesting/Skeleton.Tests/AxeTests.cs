using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void Axe_Looses_Durability_After_Attack()
        {
            Axe axe = new Axe(10, 10);

            axe.Attack(new Dummy(100,100));

            Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack.");
        }

        [Test]

        public void Attacking_With_Broken_Weapon() {
            Axe axe = new Axe(10, 1);

            axe.Attack(new Dummy(100, 100));

            Assert.Throws<InvalidOperationException>(() => {
                axe.Attack(new Dummy(100, 100));
            });           
        }
    }
}
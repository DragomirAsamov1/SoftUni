using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests {
        [Test]
        public void Duumy_Loses_Health_If_Attacked() {
            Dummy dummy = new Dummy(100, 100);
            new Axe(10, 10).Attack(dummy);

            Assert.That(dummy.Health, Is.EqualTo(90));
        }

        [Test]

        public void Dead_Dummy_Throws_Exception() {
            Dummy dummy = new Dummy(0, 0);

            Assert.Throws<InvalidOperationException>(() => {
                dummy.TakeAttack(1);
            });
        }

        [Test]
        public void Dead_Dummy_Can_Give_Experience() {

            Dummy dummy = new Dummy(0, 10);

            Assert.That(dummy.GiveExperience(), Is.GreaterThan(0));
        }

        [Test]
        public void Alive_Dummy_Cant_Give_Experience() {
            Dummy dummy = new Dummy(1, 1);

            Assert.Throws<InvalidOperationException>(() => {
                dummy.GiveExperience();
            });
        }
    }
}
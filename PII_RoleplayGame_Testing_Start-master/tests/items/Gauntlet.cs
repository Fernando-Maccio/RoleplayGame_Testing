using NUnit.Framework;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class GauntletTest
    {
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void TestGauntletPowerWithManyGem(int numberOfGems)
        {
            Gauntlet gauntlet = new Gauntlet();
            for (int i = 0; i < numberOfGems; i++)
            {
                gauntlet.AddGem(new Gem());
            }

            int expected = (numberOfGems * 30) + 1;
            Assert.AreEqual(expected, gauntlet.AttackPower);
        }

        [Test]
        public void TestMagicStickDefensePower2()
        {
            Magic magic = new Magic();
            MagicStick magicStick = new MagicStick();

            int expected = magic.DefensePower;
            Assert.AreEqual(expected, magicStick.DefensePower);
        }
    }
}
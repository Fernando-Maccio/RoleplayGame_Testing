using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

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

        [Test]
        public void TestCharacterWithMagicAttackPower7()
        {
            Elf elf = new Elf("Elf");

            int firstExpected = 0;
            Assert.AreEqual(firstExpected, elf.AttackPower);

            Magic magic = new Magic();
            elf.AddItem(magic);

            int secondExpected = 80;
            Assert.AreEqual(secondExpected, elf.AttackPower);
        }
    }
}
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
    }
    public class ElfTest
    {
        [Test]
        public void TestElfCreation3()
        {
            int result = 0;
            Elf Fran = new Elf("Francisco");
            int health = Fran.Health;
            foreach(IItem item in Fran.Items)
            {
                if(item is Robes)
                {
                    result += 1;
                }
            }

            Assert.AreEqual(120, health);
            Assert.AreEqual(1, result);
        }
    }
}
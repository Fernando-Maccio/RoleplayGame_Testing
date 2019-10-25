using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
namespace RoleplayGame.Library.Test
{
    public class GauntletTest
    {
        [Test]
         public void TestMagicStickAttack1()
         {
             MagicStick magicStick = new MagicStick();
             int expected = 89;
             Assert.AreEqual(expected, magicStick.AttackPower);
         }

        [Test]
         public void TestCharacterDefense()
         {
             Elf character = new Elf("sofia");
             character.AddItem(new Magic());
             int expected = 32;
             Assert.AreEqual(32, character.DefensePower);

         }
        // public void TestCharacterRemover
    
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
}
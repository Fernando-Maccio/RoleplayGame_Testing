using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;
using RoleplayGame.Encounters;

namespace RoleplayGame.Library.Test
{
    public class GauntletTest
    {
        [Test]

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
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

        [Test]
        public void TestRemoveNonExistentItem13()
        {
            Elf elf = new Elf("Elf");
            Stick stick = new Stick();

            try
            {
                elf.RemoveItem(stick);
            }
            catch (System.Exception exception)
            {
                Assert.IsInstanceOf(typeof(ItemNotFoundException), exception);
            }
        }

        [Test]
        public void TestAttackPower2Items11()
        {
            Elf elf = new Elf("Elf");
            Stick stick = new Stick();
            Magic magic = new Magic();

            elf.AddItem(stick);
            elf.AddItem(magic);

            int expected = stick.AttackPower + magic.AttackPower;
            Assert.AreEqual(expected, elf.AttackPower);
        }
        [Test]
        public void TestTrollCreator4()
        {
            //Asset
            string expectedname= "francisco";
            int healthexpected= 150;
            int result=0;
            int result2=0;
            
            //Action
            Troll troll = new Troll(expectedname);
            
            foreach(IItem item in troll.Items)
            {
               
                if(item is Stick)
                {
                    result+=1;
                }
                 if(item is Armor)
                {
                    result2+=1;
                }

            }

            //Assert
            Assert.AreEqual(expectedname, troll.Name);
            Assert.AreEqual(healthexpected, troll.Health);
            Assert.AreEqual(result,1);
            Assert.AreEqual(result2,1);

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
    public class MagicRemove
    {
        [Test]
        public void MagicRemovedTest10()
        {
            Wizard Fernando = new Wizard("Fernando"); 
            Fernando.RemoveItem(Fernando.Items[0]);
            Assert.AreEqual(0, Fernando.DefensePower);
        }
    }
}
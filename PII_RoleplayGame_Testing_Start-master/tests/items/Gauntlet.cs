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
}
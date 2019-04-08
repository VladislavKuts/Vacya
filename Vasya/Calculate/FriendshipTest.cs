using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Calculate
{
    [TestFixture]
    public class FriendshipTest
    {
        int amountOfFriends = 4;
        int amountOfDay = 7;

        [Test]
        public void Test()
        {
            Vasya vasyok = new Vasya();
            List<Friend> friendList = new List<Friend>();
            for (int i = 0; i < amountOfFriends; i++) {
                friendList.Add(new Friend() { _name = "Friend_"+(i+1)});
                Console.WriteLine(friendList[i]._name);
            }

            vasyok.apples = 27;
            vasyok.VasyaEat(3);
            double applesForEachFriend = new CalcCore().DivideMethod(vasyok.apples, amountOfFriends);

            for (int i = 0; i < amountOfFriends; i++)
            {
                friendList[i].Eat(applesForEachFriend);
            }

            double eatenApples = 0;
            for (int i = 0; i < amountOfFriends; i++)
            {
                eatenApples = new CalcCore().PlusMethod(eatenApples, friendList[i].hasEat);
            }
            Console.WriteLine(eatenApples);

            vasyok.apples = new CalcCore().MinusMethod(vasyok.apples, eatenApples);
            double _expected_result = 0;
            Assert.AreEqual(_expected_result, vasyok.apples);
        }


        [Test]
        public void TestDrink_1()
        {
            
            Vasya vasyok = new Vasya();
            vasyok.amountOfLitersWater = 100;
            List<Friend> friendList = new List<Friend>();
            for (int i = 0; i < amountOfFriends; i++)
            {
                friendList.Add(new Friend() { _name = "Friend_" + (i + 1) });
                Console.WriteLine(friendList[i]._name);
            }

            double totalDrunked=0;

            for (int i =0; i < amountOfDay; i++)
            {
                vasyok.VasyaDrink(3);
                for (int j=0; j < friendList.Count; j++)
                {
                    friendList[j].Drink(4);
                    totalDrunked += 4;
                }
            }
            double litersLeft = vasyok.amountOfLitersWater - totalDrunked;
            double _expected_result = -33;
            Assert.AreEqual(_expected_result, litersLeft);
        }

        [Test]
        public void TestDrink_2()
        {
            Vasya vasyok = new Vasya();
            vasyok.apples = 27;
            vasyok.amountOfLitersWater = 100;
            for (int i = 0; i < amountOfDay; i++)
            {
                vasyok.VasyaEat(3);
                vasyok.VasyaDrink(3);
            }
            double _expected_result_Apples = 6;
            double _expected_result_Water = 79;
            
            Assert.AreEqual(_expected_result_Apples, vasyok.apples);
            Assert.AreEqual(_expected_result_Water, vasyok.amountOfLitersWater);
        }

        [Test]
        public void TestDrink_3()
        {
            Vasya vasyok = new Vasya();
            List<Friend> friendList = new List<Friend>();
            for (int i = 0; i < amountOfFriends; i++)
            {
                friendList.Add(new Friend() { _name = "Friend_" + (i + 1) });
                Console.WriteLine(friendList[i]._name);
            }
            vasyok.apples = 27;
            vasyok.amountOfLitersWater = 100;
            double totalDrunked = 0;
            for (int i = 0; i < amountOfDay; i++)
            {
                vasyok.VasyaEat(3);
                vasyok.VasyaDrink(3);
                for (int j = 0; j < friendList.Count; j++)
                {
                    friendList[j].Drink(4);
                    totalDrunked += 4;
                }
            }
            vasyok.amountOfLitersWater -= totalDrunked;

            double applesForEachFriend = new CalcCore().DivideMethod(vasyok.apples, amountOfFriends);
            double eatenApples = 0;

            for (int i = 0; i < amountOfFriends; i++)
            {
                friendList[i].Eat(applesForEachFriend);
                eatenApples += friendList[i].hasEat;
            }
            vasyok.apples -= eatenApples;

            double _expected_result_Water = -33;
            double _expected_result_Apples = 0;
            
            Assert.AreEqual(_expected_result_Water, vasyok.amountOfLitersWater);
            Assert.AreEqual(_expected_result_Apples, vasyok.apples);
        }

        [Test]
        public void TestDrink_4()
        {
            Vasya vasyok = new Vasya();
            List<Friend> friendList = new List<Friend>();
            for (int i = 0; i < amountOfFriends; i++)
            {
                friendList.Add(new Friend() { _name = "Friend_" + (i + 1) });
                Console.WriteLine(friendList[i]._name);
            }
            vasyok.apples = 27;
            vasyok.amountOfLitersWater = 100;

            double totalDrunked = 0;
            for (int i = 0; i < amountOfDay; i++)
            { 
                for (int j = 0; j < friendList.Count; j++)
                {
                    friendList[j].Drink(4);
                    totalDrunked += 4;
                }
            }
            vasyok.amountOfLitersWater -= totalDrunked;

            double applesForEachFriend = new CalcCore().DivideMethod(vasyok.apples, amountOfFriends);
            double eatenApples = 0;

            for (int i = 0; i < amountOfFriends; i++)
            {
                friendList[i].Eat(applesForEachFriend);
                eatenApples += friendList[i].hasEat;
            }
            vasyok.apples -= eatenApples;

            double _expected_result_Water = -12;
            double _expected_result_Apples = 0;

            Assert.AreEqual(_expected_result_Water, vasyok.amountOfLitersWater);
            Assert.AreEqual(_expected_result_Apples, vasyok.apples);
        }
    }
}

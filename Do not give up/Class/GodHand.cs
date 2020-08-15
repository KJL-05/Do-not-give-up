using Do_not_give_up.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Do_not_give_up.Class
{
    class GodHand: IIntroduction, IResurrection
    {
        public int AttackPower = 100;
        public int HP = 3000;
        int NumberOfTimes = 1;
        public void Introduction()
        {
            Console.WriteLine("“十二试炼”"+"\r\n"+ "这既是“神之祝福”也是“诅咒”的代表不死性的宝具"+"\r\n"+"获得此宝具承认者，肉身便会化为宝具本身，宝具即为肉体，肉体即为宝具"+"\r\n"+ "唯一被动：死亡后自动使肉体苏生，此苏生贮存着11次的份量");
        }

        public void Resurrection(People people)
        {
            while (true)
            {
                if (NumberOfTimes < 12)
                {
                    people.HP = 3200;
                    NumberOfTimes++;
                }
            }
        }
    }
}

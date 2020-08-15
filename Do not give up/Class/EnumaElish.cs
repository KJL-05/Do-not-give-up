using Do_not_give_up.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Do_not_give_up.Class
{
    class EnumaElish:IIntroduction
    {
        public int AttackPower = 9999;

        public void Introduction()
        {
            Console.WriteLine("“乖离剑”"+"\r\n"+ "这并非人造的武器，而是由星球锻造而成的神造兵器"+"\r\n"+ "立于圣剑顶点的宝具"+"\r\n"+ "其为对界宝具，名副其实的切裂世界之剑"+"\r\n"+ "终极技能：乖离剑·EA——空间切断 （能够撕裂世界的一剑，绝对的必杀）");
        }
    }
}

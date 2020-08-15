using Do_not_give_up.Interface;
using System;
using System.Xml;


namespace Do_not_give_up
{
    class Excalibur:IUseUltimateSkills, IIntroduction
    {
        public int AttackPower = 300;

        public void Introduction()
        {
            Console.WriteLine("“誓约胜利之剑”"+"\r\n"+ "等级：A++"+"\r\n"+ "类别：对城宝具"+"\r\n"+"攻击力+300"+"终极技能：对敌人造成1000伤害，一次战斗中只能使用一次");
        }

        public void UseUltimateSkills(int x)
        {
            x -= 1000;
        }
    }
}

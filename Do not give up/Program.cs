using Do_not_give_up.Class;
using System;
using System.Threading;
using System.Xml;

namespace Do_not_give_up
{

    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
 //开始场景
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("从今天起，你是一个大学生了，你开始了大学生活");
            Thread.Sleep(700);
            Console.WriteLine("你整理好了宿舍，独自一人，坐在床上，看着室友的父母");
            Thread.Sleep(700);
            Console.WriteLine("你想起了自己的父母，你很希望他们能来，尽管从小到大，他们一直对你打骂          o(╥﹏╥)o");
            Thread.Sleep(700);
            Console.WriteLine("回想着父母，夜幕降临了，你决定：");
            Thread.Sleep(700);
            Console.WriteLine("1.睡觉      2.继续酸涩的回忆");
            Thread.Sleep(700);
            Console.WriteLine("输入对应数字进行选择");
            Thread.Sleep(700);
            while (true)
            {
               int select = ReadInt();
               if (select > 0)
                {
                    if (select < 3)
                    {
                        if (select == 1)
                        {
                            Console.WriteLine("你并没有睡得很踏实，接连做了好几个噩梦");
                            break;
                        }
                        if (select == 2)
                        {
                            Console.WriteLine("一夜无眠,心中不禁升起些许悲凉，24：00了，你打开网易云，寻求最后的安慰");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入有误，重新输入！");
                        continue;
                    }
                }
            }
            Thread.Sleep(700);
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            AddInterval();
            var CalDay = 1;
            Thread.Sleep(700);
 //第二个场景（第1~4天）
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("//////////////////////////////");
                Thread.Sleep(700);
                Console.WriteLine("第"+CalDay+"天"+"\r\n"+ "该去上课了，你决定：");
                Thread.Sleep(700);
                Console.WriteLine("1.去上课    2.出去逛一圈    3.待在宿舍吧");
                Thread.Sleep(700);
                Console.WriteLine("输入对应数字进行选择");
                Thread.Sleep(700);
                while (true)
                {
                    int select = ReadInt();
                    if (select > 0)
                    {
                        if (select < 4)
                        {
                            if (select == 1)
                            {
                                Thread.Sleep(700);
                                Console.WriteLine("你上了一天的课，没有人与你交谈");
                                break;
                            }
                            if (select ==2 )
                            {
                                Thread.Sleep(700);
                                Console.WriteLine("你把学校逛了个遍，觉得周围人看你的目光很令人不适");
                                break;
                            }
                            if (select == 3)
                            {
                                Thread.Sleep(700);
                                Console.WriteLine("你在冷清的宿舍孤独的躺了一天");
                                break;
                            }
                        }
                        else
                        {
                            Thread.Sleep(700);
                            Console.WriteLine("输入有误，重新输入！");
                            continue;
                        }
                    }
                }
                Thread.Sleep(700);
                Console.WriteLine("//////////////////////////////");
                AddInterval();
                CalDay += 1;
            }
            Thread.Sleep(700);
            BranchSelection BranchSelection = new BranchSelection();
            Thread.Sleep(700);
//第三个场景
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            Console.WriteLine("第5天"+"\r\n"+ "有一群人想欺负你，他们朝你要钱"+"\r\n"+ "你没有给，被打了一顿"+"\r\n"+ "你决定：");
            Thread.Sleep(700);
            Console.WriteLine("1.报告给学校    2.忍气吞声吧");
            Console.WriteLine("输入对应数字进行选择");
            while (true)
            {
                BranchSelection.option= ReadInt();
                if (BranchSelection.option > 0)
                {
                    if (BranchSelection.option < 3)
                    {
                        if (BranchSelection.option == 1)
                        {
                            Thread.Sleep(700);
                            Console.WriteLine("你将情况报告给了导员，导员叫你先回去，你看出了导员眼神的躲闪");
                            break;
                        }
                        if (BranchSelection.option == 2)
                        {
                            Thread.Sleep(700);
                            Console.WriteLine("那帮人在欺负你的时候，旁边有很多人，但是他们都冷眼旁观              ╯﹏╰" + "\r\n"+"你觉得这帮人不简单，想了想决定就这么算了");
                            break;
                        }
                    }
                    else
                    {
                        Thread.Sleep(700);
                        Console.WriteLine("输入有误，重新输入！");
                        continue;
                    }
                }
                
            }
            Thread.Sleep(700);
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            AddInterval();
            Thread.Sleep(700);
//第四个场景  第一次抉择 2个选项
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            if (BranchSelection.option == 1)
            {
                Thread.Sleep(700);
                Console.WriteLine("已经上大学一个月了" + "\r\n" + "那伙人明目张胆的欺负你已经有7次了");
                Thread.Sleep(700);
                Console.WriteLine("你每次都报告给了学校");
                Thread.Sleep(700);
                Console.WriteLine("但是每次消息都石沉大海" + "\r\n" + "你，绝望了，抑郁随之而来" + "\r\n" + "你有些觉得活着没什么意思了，干脆放弃这条命好了；" + "\r\n" + "但是不甘涌上心头" + "\r\n" + "你决定：");
            }
            if (BranchSelection.option == 2)
            {
                Thread.Sleep(1200);
                Console.WriteLine("已经上大学一个月了" + "\r\n" + "那伙人明目张胆的欺负你已经有7次了");
                Thread.Sleep(1000);
                Console.WriteLine("你每次都决定独自承受，你想找人倾诉，可还没开口，对方不耐烦加嫌弃的眼神让你又失去了勇气");
                Thread.Sleep(900);
                Console.WriteLine("你，绝望了，抑郁随之而来" + "\r\n" + "你有些觉得活着没什么意思了，干脆放弃这条命好了；" + "\r\n" + "但是不甘涌上心头" + "\r\n" + "你决定：");
            }
            Thread.Sleep(700);
            Console.WriteLine("1.Give Up");
            Thread.Sleep(700);
            Console.WriteLine("2.Don't Give Up");
            Thread.Sleep(700);
            Console.WriteLine("输入对应数字进行选择");
            while (true)
            {
                int select = ReadInt();
                if (select > 0)
                {
                    if (select < 3)
                    {
                        if (select == 1)
                        {
                            Console.WriteLine("这就没意思了，我知道亲 你想结束这段，但是后面还有呢");
                            Thread.Sleep(700);
                            Console.WriteLine("来吧亲，跟随我的脚步，选择Don't Give Up，一路走下去吧");
                            Thread.Sleep(700);
                            Console.WriteLine("重新选择吧");
                            continue;
                        }
                        if (select == 2)
                        {
                            Console.WriteLine("你确定吗？这么多的苦难，这么多的不公");
                            Thread.Sleep(700);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入有误，重新输入！");
                        Thread.Sleep(700);
                        continue;
                    }
                }
            }
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            AddInterval();
            Thread.Sleep(700);
//第五个场景  第二次抉择  5个选项
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("为什么不放弃呢？放弃了多好啊，放弃吧!!");
            Thread.Sleep(700); 
            Console.WriteLine("走不进的世界就不要硬挤了，难为了别人，作贱了自己，何必呢?");
            var Number = 1;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(Number+ ".Give Up");
                Number++;
            }
            Console.WriteLine("4.Don't Give Up");
            Console.WriteLine("5.Give Up");
            Thread.Sleep(700);
            Console.WriteLine("输入对应数字进行选择");
            while (true)
            {
                int select = ReadInt();
                if (select > 0)
                {
                    if (select < 6)
                    {
                        if (select != 4)
                        {
                            Console.WriteLine("这就没意思了，我知道亲 你想结束这段，但是后面还有呢");
                            Thread.Sleep(700);
                            Console.WriteLine("来吧亲，跟随我的脚步，选择Don't Give Up，一路走下去吧");
                            Thread.Sleep(700);
                            Console.WriteLine("重新选择吧");
                            continue;
                        }
                        if (select == 4)
                        {
                            Console.WriteLine("你确定吗？");
                            Thread.Sleep(500);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入有误，重新输入！");
                        Thread.Sleep(700);
                        continue;
                    }
                }
            }
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            AddInterval();
            Thread.Sleep(700);
//第六个场景   第三次抉择   10个选项
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("你的梦已经碎了！！");
            Thread.Sleep(700);
            Console.WriteLine("你想继续坚持你那遥不可及的梦？!!!!!");
            Thread.Sleep(700);
            Console.WriteLine("可笑！！！！！！！" + "\r\n"+"天真！！！！！！！"+"\r\n"+"愚蠢！！！！！！！");
            Thread.Sleep(1000);
            Console.WriteLine("梦已经碎了一地，捡起，努力拼凑，而后又碎，再捡起，拼凑，直到有一天再也拼凑不来。");
            Thread.Sleep(900);
            Console.WriteLine("放弃吧，可怜的孩子");
            Thread.Sleep(700);
            Console.WriteLine("1.Give Up"+"\r\n"+"2.Give Up");
            Console.WriteLine("3.Don't Give Up");
            Number = 4;
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(Number + ".Give Up");
                Number++;
            }
            Thread.Sleep(700);
            Console.WriteLine("输入对应数字进行选择");
            while (true)
            {
                int select = ReadInt();
                if (select > 0)
                {
                    if (select < 11)
                    {
                        if (select != 3)
                        {
                            Console.WriteLine("这就没意思了，我知道亲 你想结束这段，但是后面还有呢");
                            Thread.Sleep(700);
                            Console.WriteLine("来吧亲，跟随我的脚步，选择Don't Give Up，一路走下去吧");
                            Thread.Sleep(700);
                            Console.WriteLine("重新选择吧");
                            continue;
                        }
                        if (select == 3)
                        {
                            Console.WriteLine("你确定吗？");
                            Thread.Sleep(700);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入有误，重新输入！");
                        Thread.Sleep(700);
                        continue;
                    }
                }
            }
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            AddInterval();
            Thread.Sleep(700);
//第七个场景   第四次抉择   15个选项
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("为什么要坚持？   ((٩(//̀Д/́/)۶))！！！！！");
            Thread.Sleep(900);
            Console.WriteLine("活着还有什么意思吗，还有劲头吗，还有乐趣吗");
            Thread.Sleep(1500);
            Console.WriteLine("不要指望你足够努力就可以得到认可！！！！！！");
            Thread.Sleep(2000);
            Console.WriteLine("不要指望生活会怜悯你！！！！！！");
            Thread.Sleep(2000);
            Console.WriteLine("会怜悯你的只有我，你的心魔，只有我会关心你，来吧，让我抱紧你");
            Thread.Sleep(2000);
            Console.WriteLine("这个社会，这个世界都是错误的，不要坚持了，放弃吧");
            Thread.Sleep(2000);
            Number = 1;
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(Number + ".Give Up");
                Number++;
            }
            Console.WriteLine("7.Don't Give Up");
            Number = 8;
            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine(Number + ".Give Up");
                Number++;
            }
            Thread.Sleep(700);
            Console.WriteLine("输入对应数字进行选择");
            while (true)
            {
                int select = ReadInt();
                if (select > 0)
                {
                    if (select < 16)
                    {
                        if (select != 7)
                        {
                            Console.WriteLine("这就没意思了，我知道亲 你想结束这段，但是后面还有呢");
                            Thread.Sleep(700);
                            Console.WriteLine("来吧亲，跟随我的脚步，选择Don't Give Up，一路走下去吧");
                            Thread.Sleep(700);
                            Console.WriteLine("重新选择吧");
                            continue;
                        }
                        if (select == 7)
                        {
                            Console.WriteLine("你确定吗？");
                            Thread.Sleep(700);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("输入有误，重新输入！");
                        Thread.Sleep(700);
                        continue;
                    }
                }
            }
            Console.WriteLine("你在恶魔的低语中渐渐的渐渐睡去");
            Thread.Sleep(700);
            Console.WriteLine("心中充斥着的是对生的渴望。");
            Thread.Sleep(700);
            Console.WriteLine("你坚信，总有一天，自己能昂首挺胸，自信地立于天地之间");
            Thread.Sleep(700);
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            AddInterval();
            Thread.Sleep(700);
 //第八个场景   穿越了   
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            Console.WriteLine("第二天，你在床上醒来，觉得前所未有的轻松。");
            Thread.Sleep(700);
            Console.WriteLine("伸手去揉眼睛，映入眼帘的是手中紧紧抓住的一张卡片");
            Thread.Sleep(700);
            Console.WriteLine("一张通体洁白，正中央画有一个16岁左右的美少女");
            Thread.Sleep(700);
            Console.WriteLine("身着羽衣，有着半透明水色的长发和眼瞳。气质宛若女神一般");
            Thread.Sleep(700);
            Console.WriteLine("你伸出另一只手，想要抚摸那张卡片");
            Thread.Sleep(700);
            Console.WriteLine("可就在你的双手都触及卡片时，一道水蓝色的光芒刹那间照亮了眼前");
            Thread.Sleep(700);
            Console.WriteLine("紧接着一阵眩晕感袭来，让你瞬间昏阙了过去");
            Thread.Sleep(700);
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(700);
            AddInterval();
            Thread.Sleep(700);
//第九个场景   神器选定
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(400);
            Console.WriteLine("你醒来了，睁眼看到的却不再是自己的床铺");
            Thread.Sleep(600);
            Console.WriteLine("看得到的赫然是之前那张卡片上画着的身影");
            Thread.Sleep(600);
            Console.WriteLine("“我叫阿库娅，水之女神，恭喜你少年，战胜了自己的心魔”");
            Thread.Sleep(600);
            Console.WriteLine("“因为你的出色表现，所以我将你召唤到了这个世界过来，并希望你能拯救这个恶魔肆虐的世界”");
            Thread.Sleep(600);
            Console.WriteLine("“虽然这个世界被恶魔肆虐，但是都是些弱小的恶魔，最重要的还是那名为‘抑郁’的恶魔之王（boss）”");
            Thread.Sleep(600);
            Console.WriteLine("你可以在酒馆招募同伴，他们会帮你清除掉那些炮灰恶魔，你直接对战boss就好");
            Thread.Sleep(600);
            Console.WriteLine("你看着自称是水之女神的少女，感受着她眼中“智慧”的光芒，相信了她对你所说的一切");
            Thread.Sleep(600);
            Console.WriteLine("“少年，你即将踏上征途，但手无寸铁可不行”");
            Thread.Sleep(600);
            Console.WriteLine("“我这里有几件神器，但我不能直接帮助人类，所以只能让神器自己跟你走”");
            Thread.Sleep(600);
            Console.WriteLine("“神器都有封印，你要去探索解除封印的方法”");
            Thread.Sleep(600);
            Console.WriteLine("“将手放在神器上，如果神器认可了你，你便会与ta建立牢不可破的联系”");
            Thread.Sleep(600);
            Console.WriteLine("“下面又是开始神器选定了，来吧”（输入Y开始神器选定）");
            Excalibur excalibur = new Excalibur();
            EnumaElish enumaElish = new EnumaElish();
            GodHand godHand = new GodHand();
            while (true)
            {
                var select = Console.ReadLine();
                if (select == "Y")
                {
                    var string1 = DateTime.Now.Second.ToString();
                    int NowSecond;
                    int.TryParse(string1, out NowSecond);
                    if (NowSecond < 6)
                    {
                        Console.WriteLine("恭喜获得“誓约胜利之剑”");
                        excalibur.Introduction();
                        people.AttackPower += excalibur.AttackPower;
                        people.Equipment = 1;
                        break;
                    }
                    if (NowSecond > 5)
                    {
                        if (NowSecond < 51)
                        {
                            Console.WriteLine("恭喜获得“天地乖离开辟之星——乖离剑”");
                            enumaElish.Introduction();
                            people.AttackPower += enumaElish.AttackPower;
                            people.Equipment = 2;
                            break;
                        }
                    }
                    if (NowSecond > 50)
                    {
                        
                        Console.WriteLine("恭喜获得“十二试炼”");
                        godHand.Introduction();
                        people.AttackPower += godHand.AttackPower;
                        people.HP += godHand.HP;
                        people.Equipment = 3;
                        break;
                       
                    }
                }
                else
                {
                    Console.WriteLine("输入有误，重新输入！");
                    Thread.Sleep(700);
                    continue;
                }

            }
            Console.WriteLine("“你已经得到了神器，我没什么可以给你的了，去吧，拯救世界吧”");
            Thread.Sleep(700);
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(6000);
            AddInterval();
            Thread.Sleep(700);
 //第十个场景   进入世界   向前走（将剧情固定，不再做分支）
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("又是一阵眩晕袭来，醒来时你发现自己正躺在一辆马车上");
            Thread.Sleep(600);
            Console.WriteLine("“你醒啦，勇者！”");
            Thread.Sleep(600);
            Console.WriteLine("“你好，我是阿库西斯教团的祭祀：阿珍”");
            Thread.Sleep(600);
            Console.WriteLine("“接下来我将作为你的引导者，陪伴你走过接下来的冒险”");
            Thread.Sleep(600);
            Console.WriteLine("你看着眼前如阳光一般的少女，点了点头任由其带领踏上了冒险旅途");
            Thread.Sleep(600);
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(6000);
            AddInterval();
            Thread.Sleep(700);

            Console.WriteLine("//////////////////////////////");
//第十一个场景   城镇  
            Console.WriteLine("阿珍带你来到了一个城镇，这个城镇虽然不大，但是却极其热闹");
            Thread.Sleep(700);
            Console.WriteLine("阿珍说这座城镇之所以这么繁华，就是因为传说中，这里是神器的解封之地，神器的三段封印都能在这座城市中解封");
            Thread.Sleep(700);
            Console.WriteLine("阿珍带你来到了城镇上知名的魔药店，并为你买了10瓶能够恢复HP的魔药" +
                "\r\n" +
                "这些魔药能够在一瞬间恢复300的HP");
            Thread.Sleep(700);
            Console.WriteLine("就在阿珍买魔药的时候，你感到了身体内的神器的悸动");
            Thread.Sleep(700);
            Console.WriteLine("你同样感到了什么，想店铺深处走去，突然一个魔法阵出现在脚下，魔力的光辉将你包围");
            Thread.Sleep(700);
            Console.WriteLine("一种难以形容的温暖回荡心间，当一切散去，一股强大的力量从你体内爆发而出，那是属于神器的力量，一道封印解除了");
            Thread.Sleep(700);
            Console.WriteLine("之后阿珍带你前往了城镇上各个酒馆，为你寻找能够帮你清理炮灰恶魔的伙伴");
            Thread.Sleep(700);
            Console.WriteLine("你与阿珍寻找了很多伙伴，那些伙伴在得知了他们的使命后，便都出发去消灭恶魔了");
            Thread.Sleep(700);
            Console.WriteLine("在休息了一段时间后，阿珍带你来到了冒险者工会，在这里你看到了那个能解除神器封印的魔法阵");
            Thread.Sleep(700);
            Console.WriteLine("你不自觉地走上前去，触碰到了魔法阵，如同魔药店那一幕，有一道封印解除了");
            Thread.Sleep(700);
            AddInterval();
            Console.WriteLine("接下来的几天时间，你都与阿珍做着决战的准备，同时也在城镇中寻找最后一座魔法阵" +
                "\r\n" +
                "可是一连几天，直到所有护卫着“抑郁”（Boss）的恶魔全部被消灭也没能找到");
            Thread.Sleep(700);
            Console.WriteLine("你决定：");
            Thread.Sleep(700);
            Console.WriteLine("1.不找了，就以现在的力量决战     2.再找找");
            Thread.Sleep(700);
            Console.WriteLine("输入对应数字进行选择");
            Thread.Sleep(700);
            while (true)
            {
                int select = ReadInt();
                if (select > 0)
                {
                    if (select < 3)
                    {
                        if (select == 1)
                        {
                            Thread.Sleep(700);
                            Console.WriteLine("你坚定的走出了城镇，独自一人踏上了Boss巢穴的路" +
                                "\r\n" +
                                "在路边，你突然感受到了神器的悸动");
                            Thread.Sleep(700);
                            Console.WriteLine("你顺着感觉找到了一处散发着微光的草丛，仔细搜寻了一番");
                            if (people.Equipment != 2)
                            {
                                people.Equipment = 2;
                                Thread.Sleep(700);
                                Console.WriteLine("你在草丛中找到了魔法阵，并触发了它");
                                Thread.Sleep(700);
                                Console.WriteLine("你感到最后一道封印已经解开，但是同时神器突然爆发出前所未有的能量，将你冲昏过去");
                                Thread.Sleep(700);
                                Console.WriteLine("在黑暗中，你看到了，一柄在世界诞生之前就已经存在的剑" +
                                    "“乖离剑”");
                                Thread.Sleep(700);
                                Console.WriteLine("你感受到了他在召唤你，你拼尽全力，抓住了它");
                                Thread.Sleep(700);
                                Console.WriteLine("一阵白光闪过，你醒了过来，但是，你却突然发觉，自己的神器变了，变成了那柄“乖离剑”");
                                enumaElish.Introduction();
                                break;
                            }
                            if (people.Equipment == 2)
                            {
                                Console.WriteLine("你在草丛中找到了魔法阵，并触发了它");
                                Thread.Sleep(700);
                                Console.WriteLine("你感到最后一道封印已经解开，但是同时神器突然爆发出前所未有的能量，将你冲昏过去");
                                Thread.Sleep(700);
                                Console.WriteLine("当你醒过来时，你感受到了“乖离剑”那无穷的力量，仿佛真的能将世界撕裂一般");
                            }
                        }
                        if (select == 2)
                        {
                            if (people.Equipment != 2)
                            {
                                Console.WriteLine("你如同前几天一样，在城中有寻找了一番，但依旧是没有找到，不得已，踏上了讨伐Boss的征程");
                            }
                            if (people.Equipment == 2)
                            {
                                Console.WriteLine("一连又是几天，你终于在一处枯井中找到了魔法阵，并触发了它");
                                Thread.Sleep(700);
                                Console.WriteLine("你感到最后一道封印已经解开，但是同时神器突然爆发出前所未有的能量，将你冲昏过去");
                                Thread.Sleep(700);
                                Console.WriteLine("当你醒过来时，你感受到了“乖离剑”那无穷的力量，仿佛真的能将世界撕裂一般");
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(700);
                        Console.WriteLine("输入有误，重新输入！");
                        continue;
                    }
                }
            }
            Console.WriteLine("//////////////////////////////");
            Thread.Sleep(6000);
            AddInterval();
            Thread.Sleep(700);

            Console.WriteLine("//////////////////////////////");
 //决战           (开始脑瘫了)
            Console.WriteLine("你终于来到了Boss巢穴，你找到了Boss");
            Thread.Sleep(700);
            Console.WriteLine("“你就是那个不靠谱的水之女神 阿库娅召唤来杀我的人？你这般孱弱的人类，能有什么作为？”");
            Thread.Sleep(700);
            Console.WriteLine("对于恶魔的嘲讽你什么也没说只是以坚定的他眼神回应着它，因为自己已经听过太多了，这种话语已经再也不能动摇你的内心");
            Thread.Sleep(700);
            Console.WriteLine("似乎是感受到了你坚定的内心，Boss亦是严肃了起来");
            Thread.Sleep(700);
            Console.WriteLine("“你是一个值得认真对待的对手，记住我的名字：TANYONG，来吧，与我决战在这世界之巅，胜者决定世界的命运”");
            AddInterval();
            if (people.Equipment == 1)
            {
                Console.WriteLine("你紧握着“誓约胜利之剑”,与TANYONG开始了激战，但是一番大战下来，你已经筋疲力尽，无论是魔药，还是神器的技能都已经用尽了" +
                    "TANYONG也已经是强弩之末，但是他还留有一击之力，足以碾杀自己，就差一点，就差那最后一道封印" +
                    "不过你尽力了，你心中已是一片坦然，没有被抑郁打倒，此生便已无悔");
            }
            if (people.Equipment == 2)
            {
                Console.WriteLine("紧握着手中如同三段圆柱组成的最原始的剑，不，它不应称为剑，以为在它诞生之时，还没有“剑”这一概念" +
                    "你感受着“乖离剑”传递给你的力量和情感，不自觉的双手握柄，挥出了那能撕裂世界的一剑" +
                    "这一剑直接命中了TANYONG，无视了时间与空间，直接将TANYONG斩成了粉末，天空中留下了一道漆黑了裂缝，从这边的地平线，延伸到了那一边" +
                    "一片末日景象，不过那裂缝正在换换闭合，你不禁深吸一口气，然后，呐喊");
            }
            if (people.Equipment == 3)
            {
                Console.WriteLine("激战，从开始到结束，不过短短几瞬，对你和TANYONG来说，却是无比漫长" +
                    "就这短短的几个瞬间之后，你躺着呼吸着最后的空气，TANYONG站在你的旁边，也是摇摇欲坠" );
                Thread.Sleep(700);
                Console.WriteLine("“你的神器没有解封完全，只要让你在多复活哪怕一次，也是我输，可惜，是我赢了”" +
                    "\r\n" +
                    "“再见”");
                Thread.Sleep(700);
                Console.WriteLine("在结束前，你的心中没有丝毫阴霾，只有一片坦然，没有被抑郁打倒，此生便已无悔");
            }
            Console.WriteLine("//////////////////////////////");
//结束了，有很多接口没用，战斗部分我想以回合制的那种形似开展，但是精力有限，只能日后完善，其实是想用HTML的,有很多想法想要实现，不过限于精力和技术的限制，选择了C#，不过我正在HTML上对我的想法进行实现
        }
        public static int ReadInt()
        {
            int number = 0;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，重新输入！");
                }
            }
            while (true);
        }
        public static void AddInterval()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("");
            }

        }
    }

}

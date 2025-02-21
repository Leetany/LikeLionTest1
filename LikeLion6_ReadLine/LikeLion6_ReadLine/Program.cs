using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion6_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //사용자 입력을 문자열로 받기
            /*Console.Write("이름을 입력하세요: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"안녕하세요, {userName}님!");*/

            /*Console.Write("나이를 입력하세요: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요.");
            Console.WriteLine("내년에는 " + age + "살이 되겠군요.");
            Console.WriteLine("내년에는 {0} 살이 되겠군요.", age);*/

            float Ruin_Skill_Damage = 0.0f;
            float Card_Gage = 0.0f;
            float Ultimate_Damage = 0.0f;
            int Max_MP = 0;
            int Regain_MP = 0;
            int Nonfight_Regain_MP = 0;
            float Speed = 0.0f;
            float Speed_Riding = 0.0f;
            float Speed_Carrying = 0.0f;
            float Skill_Reuse_Time = 0.0f;

            Console.Write("스킬 피해량을 입력하세요: ");
            string Damage_input = Console.ReadLine();
            Ruin_Skill_Damage = float.Parse(Damage_input);

            Console.Write("카드 게이지 획득량을 입력하세요: ");
            string Card_input = Console.ReadLine();
            Card_Gage = float.Parse(Card_input);

            Console.Write("각성기 피해을 입력하세요: ");
            string Ultimate_input = Console.ReadLine();
            Ultimate_Damage = float.Parse(Ultimate_input);

            Console.Write("각성기 피해을 입력하세요: ");
            string MaxMP_input = Console.ReadLine();
            Max_MP = int.Parse(MaxMP_input);

            Console.Write("각성기 피해을 입력하세요: ");
            string RegainMP_input = Console.ReadLine();
            Regain_MP = int.Parse(RegainMP_input);

            Console.Write("각성기 피해을 입력하세요: ");
            string NonfightMP_input = Console.ReadLine();
            Nonfight_Regain_MP = int.Parse(NonfightMP_input);

            Console.Write("스킬 피해량을 입력하세요: ");
            string Speed_input = Console.ReadLine();
            Speed = float.Parse(Speed_input);

            Console.Write("스킬 피해량을 입력하세요: ");
            string SpeedRiding_input = Console.ReadLine();
            Speed_Riding = float.Parse(SpeedRiding_input);

            Console.Write("스킬 피해량을 입력하세요: ");
            string SoeedCarrying_input = Console.ReadLine();
            Speed_Carrying = float.Parse(SoeedCarrying_input);

            Console.Write("스킬 피해량을 입력하세요: ");
            string SkillReuseTime_input = Console.ReadLine();
            Skill_Reuse_Time = float.Parse(SkillReuseTime_input);

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"루인 스킬 피해: {Ruin_Skill_Damage:F1}%");
            Console.WriteLine($"카드 게이지 획득량: {Card_Gage:F1}%");
            Console.WriteLine($"각성기 피해: {Ultimate_Damage:F1}%");
            Console.WriteLine($"최대 마나: {Max_MP}");
            Console.WriteLine($"전투 중 마나 회복량: {Regain_MP}");
            Console.WriteLine($"비전투 중 마나 회복량: {Nonfight_Regain_MP}");
            Console.WriteLine($"이동 속도: {Speed:F1}%");
            Console.WriteLine($"탈 것 속도: {Speed_Riding:F1}%");
            Console.WriteLine($"운반 속도: {Speed_Carrying:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소: {Skill_Reuse_Time:F1}%");
        }
    }
}

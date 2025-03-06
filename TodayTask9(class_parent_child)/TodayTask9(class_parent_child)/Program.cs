using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask9_class_parent_child_
{
    class Champion
    {
        public string Name;
        protected int Health;
        protected int BaseAttack;
        protected int BaseDeffense;
        protected string Q;
        protected string W;
        protected string E;
        protected string R;

        public Champion()
        {
            Name = "Unknown";
            Health = 0;
            BaseAttack = 0;
            BaseDeffense = 0;
            Q = "Unknown";
            W = "Unknown";
            E = "Unknown";
            R = "Unknown";
        }

        public virtual void Attack(Champion target)
        {
            Console.WriteLine($"{target.Name}이 기본 공격을 합니다.");
        }
        public virtual void PressQ()
        {
            Console.WriteLine($"{Q}가 시전됩니다.");
        }
        public virtual void PressW()
        {
            Console.WriteLine($"{W}가 시전됩니다.");
        }
        public virtual void PressE()
        {
            Console.WriteLine($"{E}가 시전됩니다.");
        }
        public virtual void PressR()
        {
            Console.WriteLine($"{R}가 시전됩니다.");
        }
        public virtual void BaseExplain()
        {
            Console.WriteLine($"Name : {Name}, Health : {Health}, BaseAttack :{BaseAttack}, BaseDeffense : {BaseDeffense}");
        }
    }

    class Garen : Champion
    {
        public Garen()
        {
            Name = "Garen";
            Health = 1000;
            BaseAttack = 20;
            BaseDeffense = 70;
            Q = "풍차돌리기";
            W = "데미시안의 가호";
            E = "이속증가+침묵";
            R = "데마시안!!!!!!!!!!!";
        }

        public override void Attack(Champion target)
        {
            Console.WriteLine($"Garen attack {target.Name}");
        }
    }

    class Lux : Champion
    {
        public Lux()
        {
            Name = "Garen";
            Health = 1000;
            BaseAttack = 20;
            BaseDeffense = 70;
            Q = "힐";
            W = "쉴드";
            E = "속박";
            R = "레이저 빔";
        }
        public override void Attack(Champion target)
        {
            Console.WriteLine($"Lux attack {target.Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> Champions = new List<Champion>();

            Champions.Add(new Garen());
            Champions.Add(new Lux());

            foreach (var Cham in Champions)
            {
                Cham.BaseExplain();
                Cham.PressQ();
                Cham.PressW();
                Cham.PressE();
                Cham.PressR();
                Console.WriteLine();
            }

            Champions[0].Attack(Champions[1]);
            Champions[1].Attack(Champions[0]);

        }
    }
}

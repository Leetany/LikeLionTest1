using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask7
{
    class Program
    {
        const int MAX_ITEMS = 10;

        struct Inventory
        {
            public string[] itemNames;
            public int[] itemCounts;

            public Inventory(int max_items)
            {
                itemNames = new string[MAX_ITEMS];
                itemCounts = new int[MAX_ITEMS];
            }

            public void AddItem(string name, int count)
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == name)
                    {
                        itemCounts[i] += count;
                        return;
                    }
                }

                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == null)
                    {
                        itemNames[i] = name;
                        itemCounts[i] = count;
                        return;
                    }
                }
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }

            //아이템 제거 함수
            public void RemoveItem(string name, int count)
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == name)
                    {
                        if (itemCounts[i] >= count)
                        {
                            itemCounts[i] -= count;
                            if (itemCounts[i] == 0)
                            {
                                itemNames[i] = null;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("아이템 개수가 부족합니다!");
                            return;
                        }
                    }
                }
                Console.WriteLine("아이템을 찾을 수 없습니다!");
            }

            public void ShowInventory()
            {
                Console.WriteLine("현재 인벤토리 : ");
                bool isEmpty = true;

                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] != null)
                    {
                        Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                        isEmpty = false;
                    }
                }
                if (isEmpty)
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
            }
        }
        //아이템 추가 함수
        
        static void Main(string[] args)
        {
            Inventory iv = new Inventory(1);


            iv.AddItem("포션", 5);
            iv.AddItem("칼", 1);
            iv.AddItem("포션", 3); 

            iv.ShowInventory();

            iv.RemoveItem("포션", 2);
            iv.ShowInventory();

            Console.WriteLine("방패 1개 제거 시도");
            iv.RemoveItem("방패", 1);

            iv.ShowInventory();

            Console.WriteLine("포션 6개 사용(초과 사용 테스트)");
            iv.RemoveItem("포션", 6);
            iv.ShowInventory();
        }
    }
}

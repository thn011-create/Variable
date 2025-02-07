using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variable
{

    class GameStartScreen
    {
        public int watchState; //1번 입력 시 상태보기
        public int inventory;  //2번 입력 시 인벤토리
        public int store;      //3번 입력 시 상점
        public GameStartScreen(int enterState, int enterInven, int enterStore) 
        {
            watchState = enterState;
            inventory = enterInven;
            store = enterStore;
        }
       
          
        public int InputNumber()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Converted '{input}' to {number}.");
                switch (number)
                {
                    case 1:
                        Console.WriteLine("상태"); //상태 보기로 이동
                        break;

                    case 2:
                        Console.WriteLine("인벤토리"); //인벤토리로 이동
                        break;

                    case 3:
                        Console.WriteLine("상점"); //상점으로 이동
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다."); //숫자 다시 입력
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{input ?? "<null>"}' failed.");
            }
            return number;
        }



   
    }
    class State
    {
        public int level = 01;
        public string name = "Chad";
        public string job = "전사";
        public int attackDamage = 10;
        public int defense = 5;
        public int health = 100;
        public int gold = 1500;


        public int exit = 0;

        public void StateScreen()
        {
            //Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine("Lv. " + level);
            Console.WriteLine(name + "( " + job + " )");
            Console.WriteLine("공격력 : " + attackDamage);
            Console.WriteLine("방어력 : " + defense);
            Console.WriteLine("체력 : " + health);
            Console.WriteLine("Gold : " + gold + " G");
            Console.WriteLine();
            Console.WriteLine(0 + ". " + "나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            string inputOut = Console.ReadLine();


        }




    }

    class Inventory
    {
        //장착 관리도 여기서 해야함
        public int management = 1;             // 장착관리랑 연결시키는 함수에 쓰일 변수
        public int exit = 0;                   // 시작화면이랑 연결시키는 함수에 쓰일 변수
        public void InventoryScreen()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine(1 + ". " + "장착 관리");
            Console.WriteLine(0 + ". " + "나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            int input = int.Parse(Console.ReadLine());
    
        }
    }

    class Store
    {
        public string[] item = new string[] {"수련자의 갑옷", "무쇠갑옷" , "스파르타의 갑옷" , "낡은 검" , "청동 도끼" , "스파르타의 창" };
        
        void SellList()
        {
            foreach (string item in item) ;
        }
        
        public void StoreScreen()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("보유 골드");
            Console.WriteLine(state.gold + " G");  //state 인스턴스 변수에 있는 gold 변수를 가져다 쓰려고함
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("-" + item.items("") + " | " + "방어력" + "  " + " | " + "수련에 도움을 주는 갑옷입니다." + "             |   " + "1000G");
            Console.WriteLine("-" + 아이템 + "  " + " | " + "방어력" + "  " + " | " + "무쇠로 만들어져 튼튼한 갑옷입니다.");
            Console.WriteLine("-" + 아이템 + "  " + " | " + "방어력" + "  " + " | " + "스파르타의 전사들이 사용했다는 전설의 갑옷입니다." + "   |   " + 구매완료);
            Console.WriteLine("-" + 아이템 + "  " + " | " + "방어력" + "  " + " | " + "쉽게 볼 수 있는 낡은 검 입니다." + "             |   " + "1000G");
            Console.WriteLine("-" + 아이템 + "  " + " | " + "방어력" + "  " + " | " + " 어디선가 사용됐던거 같은 도끼입니다."+ "        |   " + "1000G");
            Console.WriteLine("-" + 아이템 + "  " + " | " + "방어력" + "  " + " | " + "스파르타의 전사들이 사용했다는 전설의 창입니다." + "  |  " + 구매완료);
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            string input = Console.ReadLine();
        }

        class Item
        {
            public string equip = "[E]";            // 장착한 아이템 앞에 붙을 변수 초기화
            public void ItemList()
            {
                
                List<string> items = new List<string>();
                items.Add("수련자 갑옷");
                items.Add("무쇠갑옷");
                items.Add("스파르타의 갑옷");
                items.Add("낡은 검");
                items.Add("청동 도끼");
                items.Add("스파르타의 창");
                foreach (string item in items) ;
            }

            
          
            public void ItemListCost()
            {
                List<int> itemCosts = new List<int>();
                itemCosts.Add(1000);
                itemCosts.Add(3500);
                itemCosts.Add(600);
                itemCosts.Add(1500);
                foreach(int itemCost in  itemCosts) ;

                List<string> itemSells = new List<string>();
                itemSells.Add("판매 완료");
                itemSells.Add("판매 완료");
                foreach (string itemSell in itemSells) ;
            }
            

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            State state1 = new State();
            Store store = new Store();
            GameStartScreen gameStartScreen = new GameStartScreen(1, 2, 3);
            Item item = new Item();
            gameStartScreen.InputNumber();
            state.StateScreen();
            



        }
    }
}

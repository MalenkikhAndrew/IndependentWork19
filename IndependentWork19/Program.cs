using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Specifications> specifications = new List<Specifications>()
            {
            new Specifications(){ Code="A0001",Brend="X-Com *Business*", Processor="IntelCore",Frequency=2600, RamMemory="8 ГБ",HdMemory="240 ГБ",VideoCardMemory="2 ГБ",Price=29660,Quantity=8},
            new Specifications(){ Code="A0002",Brend="MUST", Processor="AMD Ryzen",Frequency=2999, RamMemory="16 ГБ",HdMemory="360 ГБ",VideoCardMemory="4 ГБ",Price=36880,Quantity=45},
            new Specifications(){ Code="A0003",Brend="G4MT", Processor="IntelCore",Frequency=2600, RamMemory="4 ГБ",HdMemory="1 ТБ",VideoCardMemory="6 ГБ",Price=25499,Quantity=84},
            new Specifications(){ Code="A0004",Brend="X-Com *Business*", Processor="AMD Ryzen",Frequency=3600, RamMemory="4 ГБ",HdMemory="240 ГБ",VideoCardMemory="2 ГБ",Price=38800,Quantity=20},
            new Specifications(){ Code="A0005",Brend="MUST", Processor="IntelCore",Frequency=3600, RamMemory="8 ГБ",HdMemory="500 ГБ",VideoCardMemory="4 ГБ",Price=36900,Quantity=11},
            new Specifications(){ Code="A0006",Brend="IRU Home", Processor="AMD Ryzen",Frequency=2999, RamMemory="16 ГБ",HdMemory="360 ГБ",VideoCardMemory="8 ГБ",Price=24185,Quantity=17},
            new Specifications(){ Code="A0007",Brend="X-Com *Business*", Processor="IntelCore",Frequency=2600, RamMemory="8 ГБ",HdMemory="500 ГБ",VideoCardMemory="2 ГБ",Price=45888,Quantity=29},
            new Specifications(){ Code="B0001",Brend="IRU Home", Processor="AMD Ryzen",Frequency=4200, RamMemory="16 ГБ",HdMemory="240 ГБ",VideoCardMemory="8 ГБ",Price=67585,Quantity=112},
            new Specifications(){ Code="C0002",Brend="X-Com *Business*", Processor="IntelCore",Frequency=2600, RamMemory="2 ГБ",HdMemory="360 ГБ",VideoCardMemory="2 ГБ",Price=14622,Quantity=122},
            new Specifications(){ Code="D0003",Brend="G4MT", Processor="IntelCore",Frequency=2600, RamMemory="2 ГБ",HdMemory="240 ГБ",VideoCardMemory="4 ГБ",Price=15222,Quantity=5},
            new Specifications(){ Code="G0004",Brend="X-Com *Business*", Processor="AMD Ryzen",Frequency=4200, RamMemory="4 ГБ",HdMemory="1 ТБ",VideoCardMemory="2 ГБ",Price=19542,Quantity=8},
            };
            Console.WriteLine("Введите имя процессора: (IntelCore)/(AMD Ryzen)");
            string processor = Console.ReadLine();
            List<Specifications> specifications1 = specifications.Where(x => x.Processor == processor).ToList();
            Print(specifications1);

            Console.WriteLine("Введите ОЗУ: ");
            int frequency = Convert.ToInt32(Console.ReadLine());
            List<Specifications> specifications2 = specifications.Where(x => x.Frequency >= frequency).ToList();
            Print(specifications2);

            Console.WriteLine("Список по увиличению стоимости");
            List<Specifications> specifications3 = specifications.OrderBy(x => x.Price).ToList();
            Print(specifications3);

            Console.WriteLine("Список по типу процессора");
            IEnumerable<IGrouping<string, Specifications>> specifications4 = specifications.GroupBy(x => x.Processor);
            foreach (IGrouping<string, Specifications> gr in specifications4)
            {
                Console.WriteLine(gr.Key);
                foreach (Specifications s in gr)
                {
                    Console.WriteLine($"{s.Code}/ {s.Brend}/ {s.Processor}/ {s.Frequency} {"МГц"}/ {s.RamMemory}/ {s.HdMemory}/ {s.VideoCardMemory}/ {s.Price} {"Руб."}/ {s.Quantity} {"Шт."}");
                }
            }

            Console.WriteLine("Самая высокая цена");
            Specifications specifications5 = specifications.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{specifications5.Code}/ {specifications5.Brend}/ {specifications5.Processor}/ {specifications5.Frequency} {"МГц"}/ {specifications5.RamMemory}/ {specifications5.HdMemory}/ {specifications5.VideoCardMemory}/ {specifications5.Price} {"Руб."}/ {specifications5.Quantity} {"Шт."}");

            Console.WriteLine("Самая низкая цена");
            Specifications specifications6 = specifications.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{specifications6.Code}/ {specifications6.Brend}/ {specifications6.Processor}/ {specifications6.Frequency} {"МГц"}/ {specifications6.RamMemory}/ {specifications6.HdMemory}/ {specifications6.VideoCardMemory}/ {specifications6.Price} {"Руб."}/ {specifications6.Quantity} {"Шт."}");
           
            Console.WriteLine("Кол-во больше 30 Шт.");
            Console.WriteLine(specifications.Any(x=> x.Quantity>30));
            
            Console.ReadKey();
        }
        static void Print(List<Specifications> specifications) 
        {
            foreach (Specifications s in specifications) 
            {
            Console.WriteLine($"{s.Code}/ {s.Brend}/ {s.Processor}/ {s.Frequency} {"МГц"}/ {s.RamMemory}/ {s.HdMemory}/ {s.VideoCardMemory}/ {s.Price} {"Руб."}/ {s.Quantity} {"Шт."}");
            }
            Console.ReadKey();
        }
    }
}

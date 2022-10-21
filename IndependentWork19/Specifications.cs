using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork19
{
    internal class Specifications
    {
        public string Code { get; set; }    /*Код*/
        public string Brend { get; set; }    /*Бренд*/
        public string Processor { get; set; } /*Процессор*/
        public int Frequency { get; set; } /*Чистота процессора*/
        public string RamMemory { get; set; } /*Память Оперативная*/
        public string HdMemory { get; set; } /*Память Жесткого диска*/
        public string VideoCardMemory { get; set; } /*Память видеокарты*/
        public decimal Price { get; set; } /*Цена*/
        public int Quantity { get; set; } /*Количество*/


        
    }
}

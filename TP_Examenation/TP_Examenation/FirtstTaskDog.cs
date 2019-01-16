using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Examenation
{
   public class FirstTaskDog : Helper, Interface1
    {
        public int Mimimishnost { get; set; }

       
        //переопределяем метод наследуемого класса Helper
        public override string Display()
        {
            return "Hello from dogs and List of clases";

        }
        //реализуем метод интерфейса
        public string Sound()
        {
            return "Gav";
        }

    }

}



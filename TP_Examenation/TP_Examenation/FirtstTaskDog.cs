using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Examenation
{
    class FirstTaskDog : Helper, Interface1
    {
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



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Examenation
{
    //класс FirstTaskCat наследуемый от класса Helper и реализующий интерфейс Interface1
    public class FirstTaskCat : Helper, Interface1
    {

        //реализуем метод интерфейса
        public string Sound()
        {
            return "Myau";
        }
        //переопределяем метод наследуемого класса Helper
        public override string Display()
        {
            return base.Display();
        }

    }
}

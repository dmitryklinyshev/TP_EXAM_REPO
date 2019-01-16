using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Examenation
{
    public class Helper : IComparer
    {
        public int res;
      

        //создаем делегат
        delegate string Message();

        //метод с модификатором virtual, который переопределяет класс наследник
        public virtual string Display()
        {
            //Создаем переменную делегата
            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = GM; /*Присваиваем этой переменной адрес метода*/
            }
            else
            {
                mes = GE; /*Присваиваем этой переменной адрес метода*/
            }
            return mes(); /*Вызываем метод*/
        }
        private string GM()
        {
            return "Доброе утро из делегата";
        }
        private string GE()
        {
            return "Добрый вечер из делегата";
        }

        public int Compare(object cat, object dog)
        {

            if (new FirstTaskCat { Mimimishnost = 3 }.Mimimishnost > new FirstTaskDog { Mimimishnost = 5 }.Mimimishnost)
            {
                return res = -1;
            }
            else
            if
                (new FirstTaskDog { Mimimishnost = 5 }.Mimimishnost > new FirstTaskCat { Mimimishnost = 3 }.Mimimishnost)
            {
                return res = 1;
            }
            else
                return res = 0;

        }

      
    }

        
  }
    



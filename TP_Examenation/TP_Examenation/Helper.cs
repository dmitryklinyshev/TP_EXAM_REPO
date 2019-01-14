using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Examenation
{
    public class Helper
    {
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

        


        }
    }



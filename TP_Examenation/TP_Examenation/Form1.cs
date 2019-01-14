using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Examenation
{
    public partial class Form1 : Form
    {

        private Logger logger; /*создаем обьект логера*/

        public Form1()
        {
            InitializeComponent();

            logger = LogManager.GetCurrentClassLogger();

        }

        private void DogBtn_Click(object sender, EventArgs e)
        {
            FirstTaskDog dg = new FirstTaskDog();

            textBoxForAnim.Text = dg.Sound().ToString(); /*выводим сообщение из метода в текстбокс*/
            logger.Info("Собачий метод");
        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            FirstTaskCat ct = new FirstTaskCat();

            textBoxForAnim.Text = ct.Sound().ToString();/*выводим сообщение из метода в текстбокс*/
            logger.Info("Кошачий метод");
        }

        private void PoliBtn_Click(object sender, EventArgs e)
        {
            FirstTaskCat ct = new FirstTaskCat();
            textBoxForAnim.Text = ct.Display().ToString();/*выводим сообщение из метода наследуемого класса в текстбокс*/
            logger.Info("Полиморфный метод");
        }

        private void buttonShit_Click(object sender, EventArgs e)
        {
            var huinushu = new List<Helper> /*создаем список, содержащий в себе объекты разных классов.*/
            {
                new FirstTaskCat(),
              /*  new FirstTaskDog()*/ /*раскомментируйте и закомментируйте код выше, для того , чтобы вызывать этот обьект */
            };

            foreach (var huinushuka in huinushu) /*выводим каждый класс, одновременно выодится только один класс*/
            {
                textBoxForAnim.Text = huinushuka.Display().ToString();
            }
            logger.Info("лист обьектов");
        }

        private void EventBtn_Click(object sender, EventArgs e) /*клик создающий ивент*/
        {
            ClassCounter cc = new ClassCounter(); /*создаем обьект, который считает числа в цикле, как только цикл дойдет до 20, сработает событие*/
            EventTest et = new EventTest();

            cc.OnStart += et.eventTalk; /*прикрепление обработчика события с использованием делегата*/
            textBoxForAnim.Text = et.eventTalk().ToString();

            //отправляем красоту в файл txt
            using (FileStream fs = new FileStream(@"C:\Users\Элена\Documents\Programming\test.txt", FileMode.OpenOrCreate)) /*создаем файл с возможностью записи*/
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(et.eventTalk().ToString());

                fs.Write(array, 0, array.Length);

            }
            //то же самое, только с использованием StreamWriter(дописывает строчку в наш файл txt
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Элена\Documents\Programming\test.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(" Привет из StreamWriter ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            logger.Info("Создание файла, использование событий ");
        }

        private void Exceptions_Click(object sender, EventArgs e) /*обработчик эксепшенов*/ 
        {
            object w = "сюрприз";
            try
            {
                int n = 5;
                int m = n / 0;
                n = (int)w;

            }
            //-------------------------------------


            //Иерархия экспшенов такова, что класс Exception является родителем всех остальных классов ошибок 



            //----------------------------------------


            //используем классы, которые наследуются от класса Exception  */
            //catch (DivideByZeroException ex)
            //{
            //    MessageBox.Show(ex.Message, " Деление на ноль ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (InvalidCastException ex)
            //{
            //    MessageBox.Show(ex.Message, " Сюрприз не удался ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            catch (Exception ex) /*используем класс Exception*/
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}










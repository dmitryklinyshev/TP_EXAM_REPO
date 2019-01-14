using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Examenation
{
    class ClassCounter
    {
        public delegate string MethodContainer(); /*создаем делегат*/

        public event MethodContainer OnStart;/* создаем событие, возникающее при достижении 20 в методе Count*/

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 20)
                {
                    OnStart();
                }
            }
        }
    }
}

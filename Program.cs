using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_04_2023
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            List<Tovar> tovar = new List<Tovar>
            {
                new Tovar ("name1", 45, 9),
                new Tovar ("name2", 78, 19),
                new Tovar ("name3", 12, 3),
                new Tovar ("name4", 36, 17)
            };
        }
    }
}

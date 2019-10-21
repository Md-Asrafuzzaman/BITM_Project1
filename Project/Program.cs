using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
<<<<<<< HEAD
            Application.Run(new ProductUI());
=======
            Application.Run(new CustomerUI());
>>>>>>> 9c2437f503283cdaa051e149bb4df019ae1b3d1d
=======
            Application.Run(new CustomerUI());
=======
            Application.Run(new ProductUI());
>>>>>>> 7fce33d28d697f695796459a61e95f8d0b8decd3
>>>>>>> e1f0296e89276e597a12fc770e6717cf790659f2
        }
    }
}

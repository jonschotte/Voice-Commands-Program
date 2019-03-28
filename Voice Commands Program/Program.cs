using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Voice_Commands_Program
{
    class Program
    {

        
        [STAThread]
        static void Main()
        {
       


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
            






        }
    }
}

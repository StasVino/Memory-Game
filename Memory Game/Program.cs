using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// $G$ SFN-999 (-5) exception when exiting application from login screen



namespace Memory_Game
{
    // $G$ CSS-012 (-5) Access modifiers are missing.
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameManager game = new GameManager();
        }
    }
}


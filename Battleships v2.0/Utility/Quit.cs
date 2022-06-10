#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Battleships_v2._0 
{
    static class Quit 
    {
        public static void Exit() 
        {
            if (System.Windows.Forms.Application.MessageLoop) 
            {
                System.Windows.Forms.Application.Exit();
            }
            else 
            {
                Environment.Exit(1);
            }
        }
    }
}
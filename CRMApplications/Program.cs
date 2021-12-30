﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMApplications
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
            ProductsDataBase.Initialize();
            ClientsDataBase.Initialize();
            OrdersDataBase.Initialize();
            Application.Run(new MainForm());
        }
      
    }
}

﻿using Gtk;

namespace ${Namespace}
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();

            var win = new MainWindow();
            win.Show();

            Application.Run();
        }
    }
}


using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditor {
    static class Program {

        public static bool mouseDown;
        public static Point offset;

        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuickStart());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 【起始窗体】
            LoginForm loginForm = new LoginForm();

            // 打开的窗体会返回一个 DialogResult 值
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                if (MODEL.UserType.userType == "Admin")
                {
                    Application.Run(new AdminMainForm());    // 【主窗体】
                }
                else if (MODEL.UserType.userType == "Teacher")
                {
                    Application.Run(new TeacherMainForm());    // 【主窗体】
                }
                else if (MODEL.UserType.userType == "Student")
                {
                    Application.Run(new StudentMainForm());    // 【主窗体】
                }

            }
        }
    }
}

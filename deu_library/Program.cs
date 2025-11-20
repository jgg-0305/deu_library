using System;
using System.Windows.Forms;

namespace deu_library
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 로그인 창을 먼저 띄우고 승인되면 메인 뷰 실행
            using (var loginForm = new login())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Run(new MainView());
                }
                else
                {
                    // 로그인 실패/취소 시 애플리케이션 종료
                    return;
                }
            }
        }
    }
}

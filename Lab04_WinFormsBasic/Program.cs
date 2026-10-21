using DangKyHocPhan;
using PhieuNhapSanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinhBMI;

namespace Lab04_WinFormsBasic
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        [STAThread]
        static void Main(string[] args)
        {
            
            // Hiển thị console window
            AllocConsole();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("=== Chọn câu bài tập ===");
            Console.WriteLine("1 - Form1");
            Console.WriteLine("2 - Câu 7");
            Console.WriteLine("3 - Câu 8");
            Console.WriteLine("4 - Câu 9");
            Console.WriteLine("5 - Câu 10");
            Console.Write("Nhập lựa chọn (1-5): ");

            string choice = Console.ReadLine();

            // Xử lý null hoặc input rỗng
            if (string.IsNullOrWhiteSpace(choice))
            {
                MessageBox.Show("Vui lòng nhập một lựa chọn hợp lệ!");
                return;
            }

            switch (choice.Trim())
            {
                case "1":
                    Application.Run(new Form1());
                    break;
                case "2":
                    Application.Run(new cau7());
                    break;
                case "3":
                    Application.Run(new cau8());
                    break;
                case "4":
                    Application.Run(new cau9());
                    break;
                case "5":
                    Application.Run(new cau10());
                    break;

                default:
                    MessageBox.Show("Lựa chọn không hợp lệ. Vui lòng chọn lại (1-5).");
                    break;
            }

        }
    }
}

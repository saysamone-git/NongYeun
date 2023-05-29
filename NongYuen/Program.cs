using NongYuen.View;
using NongYuen.View.CassroomView;
using NongYuen.View.EvaluationView;
using NongYuen.View.StudentView;
using NongYuen.View.Teacher;
using NongYuen.View.Tuitionfee;

namespace NongYuen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn()) ;
        }
    }
}
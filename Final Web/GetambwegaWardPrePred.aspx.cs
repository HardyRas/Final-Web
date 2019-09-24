using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace Final_Web
{
    public partial class GetambwegaWardPrePred : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //[DllImport("user32.dll")]
        //static extern IntPtr SetParent(IntPtr hwc);
        protected void predictPrevalence_Click1(object sender, EventArgs e)
        {
            Process.Start(@"E:\Web\Final Web\CLIAPP1\bin\Debug\CLIAPP1.exe");
            ///*Process MalariaPrediction = */
            //Process.Start("calc.exe");
            ////Thread.Sleep(500);
            ////MalariaPrediction.WaitForInputIdle();
            ////SetParent(MalariaPrediction.MainWindowHandle);


        }
    }
}
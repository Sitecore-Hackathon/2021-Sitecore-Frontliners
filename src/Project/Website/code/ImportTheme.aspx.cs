using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SCFrontliners.Project.Website
{
    public partial class ImportTheme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var YourApplicationPath = AppDomain.CurrentDomain.BaseDirectory + "Themes\\BrandTheme\\uploadCSS.cmd";
            Process p = new Process();
            p.StartInfo.FileName = YourApplicationPath;
            p.StartInfo.WorkingDirectory = Path.GetDirectoryName(YourApplicationPath);
            // TODO : What is this?
            // It tries to find bundle_define.json from here - Confirm
            //p.StartInfo.Arguments = "-c ../StaticAssets -p " + siteType + " -a " + affiliateName + " -s";
            p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            p.Start();
            p.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();

            var exitCode = p.ExitCode;

            Response.Write("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Response.Write("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            p.Close();


            //using (PowerShell pshell = PowerShell.Create())
            //{
            //    string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //    pshell.AddScript(path + "\\psScript.ps1");//.AddParameter("param1", "paramvalue1");
            //    pshell.Invoke();
            //}

        }
    }
}
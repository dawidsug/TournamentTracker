using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Initialize the database connection - Sql or TextFile
            TrackerLibrary.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.Sql);
            Application.Run(new TournamentDashboard());

        }
    }
}

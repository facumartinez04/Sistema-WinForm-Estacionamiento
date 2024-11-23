using Dao.Implementations.SqlServer.Helpers;
using SERVICE.DAL.Implementations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICE.Services
{
    public class BackupService
    {

        public static void RealizarBackup(string connectionStringName, string rutaBackup)
        {
            BackupRepository.Current.RealizarBackup(connectionStringName, rutaBackup);
        }


        public static void RealizarRestore(string connectionStringName, string rutaBackup)
        {
            BackupRepository.Current.RestaurarBackup(connectionStringName, rutaBackup);
        }

        public static List<FileInfo> ListarBackups(string nombredb)
        {
            return BackupRepository.Current.ListarBackupsPorNombre(nombredb);
        }



    }
}

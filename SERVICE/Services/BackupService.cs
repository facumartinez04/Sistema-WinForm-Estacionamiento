using Dao.Implementations.SqlServer.Helpers;
using SERVICE.DAL.Implementations;
using SERVICE.Domain;
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
            BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Creo el backup de la base de datos {connectionStringName}"));
            BackupRepository.Current.RealizarBackup(connectionStringName, rutaBackup);
        }


        public static void RealizarRestore(string connectionStringName, string rutaBackup)
        {
            BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Realizo un restore del backup con la base de datos {connectionStringName}"));
            BackupRepository.Current.RestaurarBackup(connectionStringName, rutaBackup);
        }

        public static List<FileInfo> ListarBackups(string nombredb)
        {
            BitacoraService.RegistrarEvento(new Bitacora(SessionService.GetUsuario().UserName, $"Listo los backups"));
            return BackupRepository.Current.ListarBackupsPorNombre(nombredb);
        }



    }
}

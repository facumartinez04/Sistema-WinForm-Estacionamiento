using SERVICE.DAL.Contracts;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICE.DAL.Implementations
{
    public sealed class BackupRepository
    {


     
       #region singleton
            private readonly static BackupRepository _instance = new BackupRepository();

            public static BackupRepository Current
            {
                get
                {
                    return _instance;
                }
            }

            private BackupRepository()
            {
                //Implent here the initialization of your singleton
            }
        #endregion



        public  void RealizarBackup(string connectionStringName, string nombreArchivoBase)
        {
            try
            {
                string fecha = DateTime.Now.ToString("dd-MM-yyyy");
                string hora = DateTime.Now.ToString("HH-mm-ss");
                string nombreArchivo = $"Backup_{nombreArchivoBase}_{fecha}_{hora}.bak";

                string backupFolder = @"C:\Backup";
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                string ruta = Path.Combine(backupFolder, nombreArchivo);

                string query = $"BACKUP DATABASE [DBEstacionamiento] TO DISK = '{ruta}' WITH FORMAT, INIT;";

                string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception($"No se encontró la cadena de conexión con el nombre '{connectionStringName}'.");
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw new Exception($"Ocurrió un error al listar los backups para la base de datos : {ex.Message}");

            }
        }


        public List<FileInfo> ListarBackupsPorNombre(string nombreBaseDeDatos)
        {
            try
            {
                string backupFolder = @"C:\Backup";

                if (!Directory.Exists(backupFolder))
                {
                    throw new Exception($"La carpeta de backups '{backupFolder}' no existe.");
                }

                string[] backupFiles = Directory.GetFiles(backupFolder, $"Backup_{nombreBaseDeDatos}_*.bak");


                List<FileInfo> fileList = backupFiles.Select(file => new FileInfo(file)).ToList();

                return fileList;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw new Exception($"Ocurrió un error al listar los backups para la base de datos '{nombreBaseDeDatos}': {ex.Message}");

            }

        }


            public void RestaurarBackup(string connectionStringName, string rutaBackup)
        {
            try
            {
                if (!File.Exists(rutaBackup))
                {
                    throw new Exception($"El archivo de backup '{rutaBackup}' no existe.");
                }

                string connectionString = ConfigurationManager.ConnectionStrings[connectionStringName]?.ConnectionString;

                string masterConnectionString = connectionString.Replace("DBEstacionamiento", "master");


                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception($"No se encontró la cadena de conexión con el nombre '{connectionStringName}'.");
                }


                string query = $@"
            ALTER DATABASE [DBEstacionamiento] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [DBEstacionamiento] FROM DISK = '{rutaBackup}' WITH REPLACE;
            ALTER DATABASE [DBEstacionamiento] SET MULTI_USER;
        ";

                using (SqlConnection connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new BLLException(ex));
                throw new Exception($"Ocurrió un error al listar los backups para la base de datos : {ex.Message}");

            }
        }
    }


}

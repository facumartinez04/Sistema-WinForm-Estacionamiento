using Dao.Implementations.SqlServer.Helpers;
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



        public static void RealizarBackup(string connectionStringName, string nombreArchivoBase)
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

                throw new Exception($"Backup de la base de datos 'Estacionamiento' realizado exitosamente en: {ruta}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al realizar el backup: {ex.Message}");
            }
        }





        public static List<FileInfo> ListarBackupsPorNombre(string nombreBaseDeDatos)
        {
            try
            {
                string backupFolder = @"C:\Backup";

                if (!Directory.Exists(backupFolder))
                {
                    throw new Exception($"La carpeta de backups '{backupFolder}' no existe.");
                }

                string[] backupFiles = Directory.GetFiles(backupFolder, $"Backup_{nombreBaseDeDatos}_*.bak");

                if (backupFiles.Length == 0)
                {
                    throw new Exception($"No se encontraron archivos de backup para la base de datos '{nombreBaseDeDatos}' en la carpeta.");
                }

                List<FileInfo> fileList = backupFiles.Select(file => new FileInfo(file)).ToList();

                return fileList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error al listar los backups para la base de datos '{nombreBaseDeDatos}': {ex.Message}");
            }
        }


        public static void RestaurarBackup(string connectionStringName, string rutaBackup)
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

                MessageBox.Show($"Restauración de la base de datos desde el archivo '{rutaBackup}' completada exitosamente.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al restaurar la base de datos: {ex.Message}");
            }
        }

    }
}

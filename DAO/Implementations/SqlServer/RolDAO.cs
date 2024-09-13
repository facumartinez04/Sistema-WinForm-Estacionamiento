using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts;
using DAO.Implementations.SqlServer.Mappers;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer
{
    public class RolDAO : SqlTransactRepository, IRolDAO
    {
        public RolDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Rol] (descripcion) VALUES (@descripcion)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Rol] SET () WHERE idRol = @idRol";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Rol] WHERE idRol = @idRol";
        }

        private string SelectOneStatement
        {
            get => "SELECT ,  FROM [dbo].[Rol] WHERE idRol = @idRol";
        }

        private string SelectAllStatement
        {
            get => "SELECT +  FROM [dbo].[Rol]";
        }
        #endregion


        public void Add(Rol obj)
        {
            int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                              new SqlParameter[] { new SqlParameter("@descripcion", obj.descripcion)});

            if (esCargado == 0)
            {
                throw new Exception("No se pudo insertar el registro");
            }
        }

        public List<Rol> GetAll()
        {
            List<Rol> roles = new List<Rol>();
            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Rol rol = RolMapper.Current.Fill(data);
                    roles.Add(rol);
                }
            }
            return roles;

        }

        public Rol GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Rol obj)
        {
            throw new NotImplementedException();
        }
    }
}

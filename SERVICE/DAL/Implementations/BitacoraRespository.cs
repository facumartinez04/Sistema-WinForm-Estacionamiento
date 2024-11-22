using Dao.Implementations.SqlServer.Helpers;
using SERVICE.DAL.Contracts;
using SERVICE.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVICE.Domain.Composite;
using SERVICE.DAL.Implementations.Mappers;

namespace SERVICE.DAL.Implementations
{
    public sealed class BitacoraRespository : IBitacoraDAO
    {


         #region singleton
            private readonly static BitacoraRespository _instance = new BitacoraRespository();

            public static BitacoraRespository Current
            {
                get
                {
                    return _instance;
                }
            }

            private BitacoraRespository()
            {
                //Implent here the initialization of your singleton
            }
        #endregion


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Bitacora] (id_bitacora,usuario,fecha,accion,detalles) VALUES (@idbitacora,@usuario,@fecha,@accion,@detalles)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Bitacora] SET (id_bitacora,usuario,fecha,accion,detalles) WHERE id_bitacora = @id_bitacora";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Bitacora] WHERE id_bitacora = @id_bitacora";
        }

        private string SelectOneStatement
        {
            get => "SELECT id_bitacora,usuario,fecha,accion,detalles FROM [dbo].[Bitacora] WHERE id_bitacora = @id_bitacora";
        }

        private string SelectAllStatement
        {
            get => "SELECT id_bitacora,usuario,fecha,accion,detalles FROM [dbo].[Bitacora]";
        }

        private string SelectByUserStatement
        {
            get => "SELECT * FROM [dbo].[Bitacora] WHERE usuario = @usuario";
        }

        private string SelectByDateStatement
        {
            get => "SELECT * FROM [dbo].[Bitacora] WHERE CAST(fecha AS DATE) = @fecha;";
        }

        private string SelectByUserDateStatement
        {
            get => "SELECT id_bitacora,usuario,fecha,accion,detalles FROM [dbo].[Bitacora] WHERE usuario = @usuario AND fecha = @fecha";
        }



        #endregion



        public bool Add(Bitacora obj)
        {




            int data = SqlHelper.ExecuteNonQuery(InsertStatement, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@idbitacora", obj.idBitacora),
                                   new SqlParameter("@usuario", obj.usuario),
                                   new SqlParameter("@fecha", obj.fecha),
                                   new SqlParameter("@accion", obj.accion),
                                   new SqlParameter("@detalles", obj.detalles) });

            if (data < 0)
            {

                return true;
            }
            else
            {
                return false;
            }



        }

        public List<Bitacora> GetAll()
        {
            throw new NotImplementedException();
        }

        public Bitacora GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Bitacora obj)
        {
            throw new NotImplementedException();
        }

        public List<Bitacora> obtenerPorUsuario(string usuario)
        {

            try
            {
                List<Bitacora> bitacoras = new List<Bitacora>();

                using (var reader = SqlHelper.ExecuteReader(SelectByUserStatement, CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@usuario", usuario) }))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Bitacora bitacora = BitacoraMapper.Current.Fill(data);

                        bitacoras.Add(bitacora);
                    }
                }
                return bitacoras;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Bitacora> obtenerPorFecha(DateTime dateTime)
        {
            try
            {
                List<Bitacora> bitacoras = new List<Bitacora>();

                using (var reader = SqlHelper.ExecuteReader(SelectByDateStatement, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@fecha", dateTime.ToString("yyyy-MM-dd 00:00:00"))}))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Bitacora bitacora = BitacoraMapper.Current.Fill(data);

                        bitacoras.Add(bitacora);
                    }
                }

                return bitacoras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Bitacora> obtenerPorUsuarioFecha(string usuario, DateTime dateTime)
        {
            try
            {
                List<Bitacora> bitacoras = new List<Bitacora>();

                using (var reader = SqlHelper.ExecuteReader(SelectByUserDateStatement, CommandType.Text,
                    new SqlParameter[] { new SqlParameter("@usuario", usuario),
                    new SqlParameter("@fecha", dateTime) }))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        Bitacora bitacora = BitacoraMapper.Current.Fill(data);

                        bitacoras.Add(bitacora);
                    }
                }


                return bitacoras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

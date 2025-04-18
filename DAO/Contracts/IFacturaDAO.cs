﻿using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Contracts
{
    /// <summary>
    /// La interfaz IFacturaDAO contiene los métodos que implementará la clase FacturaDAO
    /// </summary>
    public interface IFacturaDAO : IGenericDao<Factura>
    {
        Factura obtenerPorID(int ID);

        List<Factura> obtenerPorPatente(string patente);


        List<Factura> obtenerPorFecha(DateTime fechaDesde, DateTime fechaHasta);
    }
}

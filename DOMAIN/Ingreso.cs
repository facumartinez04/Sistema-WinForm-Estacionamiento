﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Ingreso
    {
        public Guid idIngreso { get;set; }

        public Cliente cliente { get; set; }

        public Vehiculo vehiculo { get; set; }

        public TipoTarifa objTipoTarifa { get; set; }
        public DateTime fechaIngreso { get; set; }

        public DateTime? fechaEgreso { get; set; }
        
        public Estado estado { get; set; }

        public enum Estado { Ingresado = 1, Pago = 2, EsperandoPago = 3, Inactivo = 4 }
    }
}

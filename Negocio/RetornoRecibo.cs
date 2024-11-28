﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    /// <summary>
    /// Objeto de Retorno - Devolución de Recibo al sistema Invoices.
    /// </summary>
    public class RetornoRecibo
    {
        public string COD_CLIENT = "";
        public string N_COMP = "";
        public string FECHA_EMIS = "";
        public string IMPORTE = "";
        public string MON_CTE = "";
        public string COTIZ = "";
        public string N_COMP_REL = "";
        public string T_COMP_CAN = "";
        public string IMPORTE_CAN = "";
        public string T_RETEN = "";
        public string IMPORTE_RETEN = "";

        public string error = "";
        public bool estado = false;
    }
}

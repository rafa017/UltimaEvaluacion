using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIEv3
{
    public class ErrorResponse
    {
        public string tipo { get; set; }
        public string mensaje { get; set; }
        public string traza { get; set; }

        public ErrorResponse(Exception ex)
        {
            tipo = ex.GetType().Name;
            mensaje = ex.Message;
            traza = ex.ToString();
        }
    }
}
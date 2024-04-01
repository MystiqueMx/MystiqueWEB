﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MystiqueMcApi.Models.Entradas
{
    public class RequestUsuario : RequestBase
    {
    }

    public class RequestUsuarioRecuperarPassword
    {
        public string email { get; set; }
        public int empresaId { get; set; }
    }


    public class RequestUsuarioRegistrar
    {
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public string userName { get; set; }
        public int? sexo { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string colonia { get; set; }
        public string facebookId { get; set; }
        public int? coloniaId { get; set; }
        public int empresaId { get; set; }
        public int tipoAutentificacionId { get; set; }

    }
}
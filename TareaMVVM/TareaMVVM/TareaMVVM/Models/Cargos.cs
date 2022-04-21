using System;
using System.Collections.Generic;
using System.Text;

namespace TareaMVVM.Models
{
    public class Cargos
    {
        public string Cargo { get; set; }
        public static List<Cargos> GetCargos()
        {
            var cargo = new List<Cargos>()
            {
                new Cargos(){ Cargo ="Cajero" },
                new Cargos(){ Cargo ="IT" },
                new Cargos(){ Cargo ="Auditor" },
                new Cargos(){ Cargo ="Gerente" },
                new Cargos(){ Cargo ="Supervisor" }
            };
            return cargo;
        }
    }
}

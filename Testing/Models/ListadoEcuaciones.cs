using Capa_Entidades;
using Capa_Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testing.Models
{
    public class ListadoEcuaciones
    {
        public int id { get; set; }
        public IEnumerable<SelectListItem> comboEcuaciones { get; set; }

        public ListadoEcuaciones()
        {
            this.comboEcuaciones = new EcuacionServices().FillCombobox();
        }
    }
}
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capa_Servicios
{
    public class EcuacionServices
    {
        private MatematicaEntities context = new MatematicaEntities();

        public void SaveToDatabase(ecuacion eq)
        {            
            context.ecuacions.Add(eq);
            context.SaveChanges();
        }

        public ecuacion GetFirstEquation()
        {
            var ecuacion = context.ecuacions.FirstOrDefault(e => e.id == 1);
            return ecuacion;
        }

        public ecuacion SearchEquation(int id)
        {
            var ecuacion = context.ecuacions.FirstOrDefault(e => e.id == id);
            return ecuacion;
        }

        public IEnumerable<SelectListItem> FillCombobox()
        {            
            List<SelectListItem> combo = new List<SelectListItem>();
            List<ecuacion> ecuacionesAlmacenadas =  context.ecuacions.ToList();

            foreach (var opcion in ecuacionesAlmacenadas)
            {
                combo.Add(new SelectListItem() { Value = opcion.id.ToString(), Text = opcion.id.ToString() });
            }

            return combo;
        }
    }
}

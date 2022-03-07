using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2019GV601_2019MH603.Modelos
{
      
    public class detalle_pedidos
    {
        public int id { get; set; }

        public int id_departamento { get; set; }

        public int id_producto { get; set; }

        public int cantidad { get; set; }
    }
}

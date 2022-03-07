using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace _2019GV601_2019MH603.Modelos
{
    public class pedidos
    {
        public int id { get; set; }

        public int id_cliente { get; set; }

        public DateOnly fecha_pedido { get; set; }
    }
}

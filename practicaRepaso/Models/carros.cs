using System.ComponentModel.DataAnnotations;
namespace practicaRepaso.Models
{
    public class carros
    {
        [Key]
        public int id_carros { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int? tipo_carro_id { get; set; }
        public int? marca_id { get; set; }
        public string modelo { get; set; }
        public int? anio_compra { get; set;}
        public decimal costo { get; set; }
        public int? vida_util { get; set; }
        public int? estado_carro_id { get; set;}
        public string estado { get; set; }
    }
}

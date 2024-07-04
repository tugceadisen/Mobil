using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobil1.Models
{
    public class Fatura_Bilgi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FaturaBilgi_Id { get; set; }
        public string KDV_Orani { get; set; }
        public string Fatura_Tipi { get; set; }
        public string SirketAdresi { get; set; }
        public string SirketTelefon { get; set; }
    }
}

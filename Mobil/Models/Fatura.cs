using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mobil1.Models
{
    public class Fatura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Fatura_Id { get; set; }
        public string Fatura_Numarasi { get; set; }
        public string Sirket_Adi { get; set; }
        public float Toplam_Tutar { get; set; }
        public string Onay_Durumu { get; set; }

        public int FaturaBilgi_Id { get; set; }
        public Fatura_Bilgi Fatura_Bilgi { get; set; }
    }
}
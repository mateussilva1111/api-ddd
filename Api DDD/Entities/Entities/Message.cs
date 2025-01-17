using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities
{
    [Table("TB_Message")]
    public class Message
    {
        [Column("MSN_ID")]
        [MaxLength(255)]
        public int Id { get; set; }

        [Column("MSN_TITULO")]
        [MaxLength(255)]
        public string Titulo { get; set; }

        [Column("MSN_ATIVO")]
        [MaxLength(255)]
        public bool Ativo { get; set; }

        [Column("MSN_DATA_CADASTRO")]
        [MaxLength(255)]
        public DateTime Datacadastro { get; set; }

        [Column("MSN_DATA_ALETRACAO")]
        [MaxLength(255)]
        public DateTime DataAlteracao { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}

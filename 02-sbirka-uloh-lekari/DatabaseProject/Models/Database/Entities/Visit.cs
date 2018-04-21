using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApplication1.Models.Database.Entities
{
    [Table("prg_hosp_Visits")]
    public class Visit
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("patientId")]
        public int PatientId { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("message")]
        public string Message { get; set; }

        [Column("medicaments")]
        public string Medicaments { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("modifiedAt")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
    }
}

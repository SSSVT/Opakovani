using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApplication1.Models.Database.Entities
{
    [Table("prg_hosp_Specializations")]
    public class Specialization
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("modifiedAt")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

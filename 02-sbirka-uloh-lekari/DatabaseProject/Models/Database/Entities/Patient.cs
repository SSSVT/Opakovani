using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApplication1.Models.Database.Entities
{
    [Table("prg_hosp_Patients")]
    public class Patient
    {
        [Browsable(false)]
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Jméno")]
        [Column("firstName")]
        public string FirstName { get; set; }

        [DisplayName("Příjmení")]
        [Column("lastName")]
        public string LastName { get; set; }

        [DisplayName("Rodné číslo")]
        [Column("personaId")]
        public string PersonalId { get; set; }

        [DisplayName("Adresa")]
        [Column("address")]
        public string Address { get; set; }

        [DisplayName("Číslo pojišťovny")]
        [Column("insuranceCompany")]
        public int InsuranceCompany { get; set; }

        [Browsable(false)]
        [Column("doctorId")]
        public int DoctorId { get; set; }

        [Browsable(false)]
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Browsable(false)]
        [Column("modifiedAt")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Browsable(false)]
        [Column("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        [DisplayName("Doktor")]
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }

        [Browsable(false)]
        public virtual ICollection<Visit> Visits { get; set; }

        public override string ToString()
        {
            return $"{this.LastName}, {this.FirstName}";
        }
    }
}

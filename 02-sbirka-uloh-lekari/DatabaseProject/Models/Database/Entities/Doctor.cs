using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApplication1.Models.Database.Entities
{
    [Table("prg_hosp_Doctors")]
    public class Doctor
    {
        [Column("id"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("firstName")]
        public string FirstName { get; set; }

        [Column("lastName")]
        public string LastName { get; set; }

        [Column("birthdate")]
        public DateTime Birthdate { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("mobileNumber")]
        public string MobileNumber { get; set; }

        [Column("specialization")]
        public int IdSpecialization { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("modifiedAt")]
        public DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("deletedAt")]
        public DateTime? DeletedAt { get; set; }


        [ForeignKey("IdSpecialization")]
        public virtual Specialization Specialization { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public override string ToString()
        {
            return $"{this.LastName}, {this.FirstName}";
        }
    }
}
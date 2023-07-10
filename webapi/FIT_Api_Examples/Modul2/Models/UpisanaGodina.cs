using FIT_Api_Examples.Migrations;
using FIT_Api_Examples.Modul3_MaticnaKnjiga.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIT_Api_Examples.Modul2.Models
{
    public class UpisanaGodina
    {
        [Key]
        public int Id { get; set; } 
        public DateTime datumUpisa { get; set; }     
        public int godinaStudija { get; set; }
        [ForeignKey("akademskaId")]
        public int? akademskaId { get; set; }
        public AkademskaGodina akademskaGodina { get; set; }
        [ForeignKey("studentId")]
        public int? studentId { get; set; }
        public Student student { get; set; }
        public float cijenaSkolarine { get; set; }
        public bool obnova { get; set; }
        public DateTime? datumOvjere { get; set; }
        public string napomena { get; set; }
    }
}

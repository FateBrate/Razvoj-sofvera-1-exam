using FIT_Api_Examples.Modul2.Models;
using FIT_Api_Examples.Modul3_MaticnaKnjiga.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace FIT_Api_Examples.Modul2.ViewModels
{
    public class UpisanaGodinaAddVM
    {
       
        public int Id { get; set; } 
        public DateTime datumUpisa { get; set; }
        public int godinaStudija { get; set; }
        public int akademskaId { get; set; }
        public int studentId { get; set; }   
        public float cijenaSkolarine { get; set; }
        public bool obnova { get; set; }
        public DateTime datumOvjere { get; set; }
        public string napomena { get; set; }
    }
}

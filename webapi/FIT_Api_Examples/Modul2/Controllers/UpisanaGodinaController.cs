using FIT_Api_Examples.Data;
using FIT_Api_Examples.Modul2.Models;
using FIT_Api_Examples.Modul2.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FIT_Api_Examples.Modul2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpisanaGodinaController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public UpisanaGodinaController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpPost]
        public ActionResult<UpisanaGodina>Add(UpisanaGodinaAddVM x)
        {
            var _student = _dbContext.Student.Find(x.studentId);
            var _akademska=_dbContext.AkademskaGodina.Find(x.akademskaId);
            var upisana = new UpisanaGodina
            {
                datumUpisa = x.datumUpisa,          
                cijenaSkolarine=x.cijenaSkolarine,
                obnova=x.obnova,
                godinaStudija=x.godinaStudija,
                student=_student,
                akademskaGodina=_akademska,
                

            };
            _dbContext.UpisanaGodina.Add(upisana);
            _dbContext.SaveChanges();
            return Ok(upisana);
        }
        [HttpGet]
        public ActionResult<List<UpisanaGodina>>GetAll(int id) 
        {
            var data = _dbContext.UpisanaGodina.Include(x => x.student).Include(x => x.akademskaGodina).Where(x => x.studentId == id).ToList();
            return Ok(data);
        }
        [HttpPut]
        public ActionResult<UpisanaGodina>Ovjeri(UpisanaGodinaUpVM x) 
        {
            var thisGodina = _dbContext.UpisanaGodina.Find(x.id);
            if (thisGodina == null)
                return BadRequest("Greska !");
            thisGodina.datumOvjere = x.datumOvjere;
            thisGodina.napomena = x.napomena;
            _dbContext.UpisanaGodina.Update(thisGodina);
            _dbContext.SaveChanges();
            return Ok(thisGodina);
        }
    }
}

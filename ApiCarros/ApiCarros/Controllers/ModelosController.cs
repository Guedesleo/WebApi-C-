using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCarros.DataBase;
using ApiCarros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCarros.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        private dbAdo db;
        [HttpGet]
        public List<Modelo> Get()
        {
            db = new dbAdo();
            List<Modelo> Modelos = db.Modelo();
            return Modelos;
        }
    }
}

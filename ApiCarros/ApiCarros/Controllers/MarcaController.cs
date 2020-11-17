using System;
using System.Collections.Generic;
using ApiCarros.DataBase;
using ApiCarros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;

namespace ApiCarros.Controllers
{
    

    [ApiController]
    [Route("[controller]")]
    public class MarcaController : ControllerBase
    {
        private dbAdo db;
        [HttpGet]
        public List<Marca> Get()
        {
            db = new dbAdo();
            List<Marca> marcas = db.Marca();
            return marcas;
        }
    }
}

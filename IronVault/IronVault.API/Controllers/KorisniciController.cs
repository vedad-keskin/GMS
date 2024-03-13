﻿using IronVault.Model;
using IronVault.Model.Requests;
using IronVault.Services;
using IronVault.Services.Database;
using Microsoft.AspNetCore.Mvc;


namespace IronVault.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        protected IKorisnikService _service;

        public KorisniciController(IKorisnikService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Korisnik> GetList()
        {
            return _service.GetList();
        }

        [HttpPost]
        public Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            return _service.Insert(request);
        }


    }
}

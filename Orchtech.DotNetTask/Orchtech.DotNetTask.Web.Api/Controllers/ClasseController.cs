using Microsoft.AspNetCore.Mvc;
using Orchtech.DotNetTask.Common.Repository;
using Orchtech.DotNetTask.Domain;
using Orchtech.DotNetTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Orchtech.DotNetTask.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClasseController : ControllerBase
    {
        private readonly IRepository _repository;
        public ClasseController(ApplicationDbContext context, IRepository repository)
        {
            _repository = repository;
        }


        // GET: ClasseController/GetAll
        public async Task<ActionResult<List<Classe>>> GetAll()
        {
            return await _repository.GetAll<Classe>();
        }


        // GET: ClassController/Find/00000-0000-0000-0000
        //public async Task<ActionResult<Classe>> Find(Guid id)
        //{
        //    var classe = await _repository.Find<Classe>(id);

        //    if (classe == null)
        //    {
        //        return NotFound();
        //    }

        //    return classe;
        //}


        // POST: ClassController/Update/5
        [HttpPut("{id}")]
        [ValidateAntiForgeryToken]
        public async Task<Boolean> Update( Classe classe)
        {
            await _repository.UpdateAsync<Classe>(classe);
            return true;
        }

    
        // POST: ClasseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(Classe Classe)
        {
            await _repository.CreateAsync<Classe>(Classe);
            return CreatedAtAction("Find", new { id = Classe.Id }, Classe);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Classe>> Delete(Guid id)
        {
            var model = await _repository.Find<Classe>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<Classe>(model);

            return model;
        }
    }
}


    


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
    public class EnrolmentController : ControllerBase
    {
        private readonly IRepository _repository;
        public EnrolmentController(ApplicationDbContext context, IRepository repository)
        {
            _repository = repository;
        }


        // GET: EnrolmentController/GetAll
        public async Task<ActionResult<List<Enrolment>>> GetAll()
        {
            return await _repository.GetAll<Enrolment>();
        }


        // GET: ClassController/Find/00000-0000-0000-0000
        //public async Task<ActionResult<Enrolment>> Find(Guid id)
        //{
        //    var Enrolment = await _repository.Find<Enrolment>(id);

        //    if (Enrolment == null)
        //    {
        //        return NotFound();
        //    }

        //    return Enrolment;
        //}


        // POST: ClassController/Update/5
        [HttpPut("{id}")]
        [ValidateAntiForgeryToken]
        public async Task<Boolean> Update( Enrolment Enrolment)
        {
            await _repository.UpdateAsync<Enrolment>(Enrolment);
            return true;
        }

    
        // POST: EnrolmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(Enrolment Enrolment)
        {
            await _repository.CreateAsync<Enrolment>(Enrolment);
            return CreatedAtAction("Find", new { id = Enrolment.Id }, Enrolment);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Enrolment>> Delete(Guid id)
        {
            var model = await _repository.Find<Enrolment>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<Enrolment>(model);

            return model;
        }
    }
}


    


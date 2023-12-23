using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class DonorController : ApiController
    {
        DonorRepository repository = new DonorRepository();

        public IHttpActionResult GetAll()
        {
            return Ok(repository.DonorList);
        }

        public IHttpActionResult Get (int id)
        {
            return Ok (repository.GetById(id));
        }

        public IHttpActionResult Post (Donor c)
        {
            repository.Save (c);
            return Ok();
        }

        public IHttpActionResult Put(Donor c)
        {
            repository.Update(c);
            return Ok();
        }

        public IHttpActionResult Delete (int id)
        {
            repository.Delete(id);
            return Ok();
        }

    }
}

using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace ApiEventos.Controllers
{
    [RoutePrefix("API/USER")]
    public class UserController : ApiController
    {
        UserBusiness _UserBusiness = new UserBusiness();

        [Route("ADD")]
        [HttpPost]
        public IHttpActionResult Add([FromBody]User pUser)
        {
            _UserBusiness.Add(pUser);

            return Content(HttpStatusCode.NotImplemented, pUser);
        }

        [Route("GETALL")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            IList<User> Users = _UserBusiness.GetAll();

            return Content(HttpStatusCode.OK, Users);
        }

        //[Route("{id}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            User User = _UserBusiness.GetByID(id);

            return Content(HttpStatusCode.OK, User);
        }

        [Route("DELETE")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _UserBusiness.Delete(new User { ID = id });

            return Content(HttpStatusCode.OK, "Deleted");
        }

        

    }
}
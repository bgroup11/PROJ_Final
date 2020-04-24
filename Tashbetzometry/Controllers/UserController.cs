using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tashbetzometry.Models;

namespace Tashbetzometry.Controllers
{
	public class UserController : ApiController
	{
		// GET api/User/mail/password
		[HttpGet]
		[Route("api/User/{mail}")]
		public User Get(string mail)
		{
			User u = new User();
			return u.GetForgetPassFromDB(mail);
		}

		// GET api/User/mail/password
		[HttpGet]
		[Route("api/User/{mail}/{password}")]
		public User Get(string mail, string password)
		{
			User u = new User();
			return u.GetUserFromDB(mail, password);
		}

		// POST api/<controller>
		public void Post([FromBody]User user)
		{
			User u = new User();
			u.InsertUserToServer(user);
		}

		// PUT api/<controller>/5
		public void Put([FromBody]User user)
		{
			User u = new User();
			u.UpdatePasswordDB(user);
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}
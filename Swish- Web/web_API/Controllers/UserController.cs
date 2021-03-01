using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DATA;
using web_API.DTO;

namespace web_API.Controllers
{
   //[RoutePrefix("api/routing")]
    public class UserController : ApiController
    {
        swishDBContext db = new swishDBContext();
        // GET api/<controller>
        public List<UserDTO> Get()
        {
            var users = db.S_User.Select(x => new UserDTO()
            {
                id = x.id,
                firstName = x.firstName,
                lastName= x.lastName,
                phoneNumber= x.phoneNumber,
                password= x.password,
                birthDate= x.birthDate,
                residence= x.residence,
                radius= x.radius,
                email=x.email,
                profilePicture=x.profilePicture,
                itemViewingMethod= x.itemViewingMethod
                
            }).ToList();

            return users;
        }

        //public void Post(S_User user)
        //{

        //}

        // POST api/<controller>
        public HttpResponseMessage Post(UserDTO userDTO)
        {
            swishDBContext db = new swishDBContext();
            S_User user = new S_User();

            user.firstName = userDTO.firstName;
            user.lastName = userDTO.lastName;
            user.birthDate = userDTO.birthDate;
            user.phoneNumber = userDTO.phoneNumber;
            user.email = userDTO.email;
            user.password = userDTO.password;
            user.residence = userDTO.residence;
            user.radius = userDTO.radius;
            user.profilePicture = userDTO.profilePicture;
            user.itemViewingMethod = userDTO.itemViewingMethod;

            try
            {
                db.S_User.Add(user);
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateResponse(HttpStatusCode.Conflict, "נא לנסות שוב");
            }
            
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotImplemented, ex.Message);
            }
            return Request.CreateResponse(HttpStatusCode.OK, "משתמש נוסף בהצלחה");
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
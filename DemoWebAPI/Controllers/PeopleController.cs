using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    /// <summary>
    /// This is where I set the info
    /// </summary>

    public class PeopleController : ApiController
    {

        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Bagins", Id = 3 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }
        //[Route("api/People/GetFirstNames/{userId:int}/{age:int}")]


        /// <summary>
        /// Het first name description
        /// </summary>
        /// <returns>
        /// something else
        /// </returns>

        [Route("api/People/GetFirstNames")]
        [HttpGet]
        //public List<string> GetFirstNames(userId, age)
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();
            foreach (var person in people)
            {
                output.Add(person.FirstName);
            }
            return output;
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }



        // DELETE: api/People/5
        public void Delete(int id)
        {
            people.Remove(people.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}

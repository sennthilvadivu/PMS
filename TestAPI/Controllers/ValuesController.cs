using PMS.Core.Domain;
using PMS.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestAPI.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            using (var unitOfWork = new UnitOfWork(new PMSContext()))
            {
                // Example1
                var course = unitOfWork.Ventures.Get(1);

                // Example2
                //var courses = unitOfWork.Courses.GetCoursesWithAuthors(1, 4);

                // Example3
                //var author = unitOfWork.Authors.GetAuthorWithCourses(1);
                //unitOfWork.Courses.RemoveRange(author.Courses);
                //unitOfWork.Authors.Remove(author);
                //unitOfWork.Complete();

                var venture = new Venture()
                {
                    Name = "Insert One",
                    City = "Delhi",
                    IsDeleted = false,
                    Status = "Start",
                    CreatedBy = "KS",
                    CreatedOn = DateTime.UtcNow,
                    Properties = null
                };
                unitOfWork.Ventures.Add(venture);
                unitOfWork.Complete();
            }
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

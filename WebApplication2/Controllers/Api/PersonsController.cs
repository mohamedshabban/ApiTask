﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers.Api
{
    public class PersonsController : ApiController
    {
        private readonly AppDbContext _context;
        static readonly IPersonRepository studentRepository = new PersonRepository();
        public PersonsController()
        {
            _context = new AppDbContext();
        }
        // GET api/<controller>
        // GET /api/customers
        public Person GetPerson(string name)
        {
            
            //var person = 
            //    _context.Persons.Include(c => c.Hoppies)
            //    .SingleOrDefault(c => c.Name == name);
            //if (person == null)
            //    throw new HttpResponseException(HttpStatusCode.NotFound);

            var person = studentRepository.GetAllPersons()
                .First(c => c.Name == name);
            if (person == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return person;
        }

    }
}

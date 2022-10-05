using System;
using System.Collections.Generic;
using Challenge.Repositories;

namespace Challenge.Services
{
    public class PersonInfoServices
    {
        private readonly PersonInfoRepository _PIRepo;

        public PersonInfoServices(PersonInfoRepository pIRepo)
        {
            _PIRepo = pIRepo;
        }

        internal List<PersonInfo> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
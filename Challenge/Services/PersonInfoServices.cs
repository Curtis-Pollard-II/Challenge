using System.Collections.Generic;
using Challenge.Models;
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
            return _PIRepo.GetAll();
        }
    }
}
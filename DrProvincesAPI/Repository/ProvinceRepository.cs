using DrProvincesAPI.Data;
using DrProvincesAPI.Models;
using DrProvincesAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrProvincesAPI.Repository
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProvinceRepository(ApplicationDbContext db)
        {
            _dbContext = db;
        }
        public Province GetProvince(int provinceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Province> GetProvinces()
        {
            throw new NotImplementedException();
        }

        public bool CreateProvince(Province province)
        {
            _dbContext.Provinces.Add(province);
            
            return Save();
        }
        bool UpdateProvince(Province province)
        {
            _dbContext.Provinces.Update(province);

            return Save();
        }

        public bool DeleteProvince(Province province)
        {
            _dbContext.Provinces.Remove(province);

            return Save();
        }



        public bool ProvinceExists(string name)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

       
    }
}

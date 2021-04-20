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

            return _dbContext.Provinces.FirstOrDefault(prov => prov.Id == provinceId); ;
        }

        public ICollection<Province> GetProvinces()
        {
            return _dbContext.Provinces.OrderBy(x => x.Name).ToList();
        }

        public bool CreateProvince(Province province)
        {
            _dbContext.Provinces.Add(province);
            return Save();
        }

        public bool UpdateProvince(Province province)
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
            return _dbContext.Provinces.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() >= 0 ? true : false;
        }
    }
}

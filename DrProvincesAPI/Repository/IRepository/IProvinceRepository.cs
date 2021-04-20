using DrProvincesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrProvincesAPI.Repository.IRepository
{
    public interface IProvinceRepository
    {
        ICollection<Province> GetProvinces();
        Province GetProvince(int provinceId);
        bool ProvinceExists(string name);
        bool CreateProvince(Province province);
        bool UpdateProvince(Province province);
        bool DeleteProvince(Province province);
        bool Save();

    }
}

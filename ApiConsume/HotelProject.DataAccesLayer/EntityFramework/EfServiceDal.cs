using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.Entitylayer.Concrete;

namespace HotelProject.DataAccesLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServicesDal

    {
        public EfServiceDal(Context context) : base(context)
        { 
        }
    }
}

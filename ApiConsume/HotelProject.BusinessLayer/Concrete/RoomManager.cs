using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Delete(Room t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Room t)
        {
            _roomDal.Delete(t);
        }

        public List<Room> TGetAll()
        {
            return _roomDal.GetAll();
        }

        public Room TGetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}

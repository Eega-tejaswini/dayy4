using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayy6
{
    internal class Hotel : IRoomm<RoomAC> , IRoomm<RoonNonAc>
    {
        List<RoomAC> lstrooms = new List<RoomAC>()
        {
            new RoomAC(){RoomNo=111,RoomType="Single",Price=5000},
            new RoomAC(){RoomNo=113,RoomType="Single",Price=5000},
        };
        
        public void AddRoom(RoomAC item)
        {
            lstrooms.Add(item);

        }
        public IEnumerable<RoomAC> GetAll()
        {
            return lstrooms;
        }

        List<RoonNonAc> lstnonacrooms = new List<RoonNonAc>()
        {
            new RoonNonAc(){RoomNo=111,RoomType="Single",Price=5000},
            new RoonNonAc(){RoomNo=113,RoomType="Single",Price=5000},
        };

       public  void AddRoom(RoonNonAc item)
        {
            lstnonacrooms.Add(item);

        }
        IEnumerable<RoonNonAc> IRoomm<RoonNonAc>.GetAll()
        {
            return lstnonacrooms;
        }


    }
}

using dayy6;

Console.WriteLine("Hello, World!");

Hotel htl = new Hotel();
IEnumerable<RoomAC> result = htl.GetAll();

foreach (RoomAC r in result)
{
    Console.WriteLine(r.RoomNo + " " + r.RoomType + " " + r.Price);
}

htl.AddRoom(new RoomAC() { RoomNo = 115, RoomType = "Double", Price = 8000 });

IEnumerable<RoonNonAc> resultn = ((IRoomm<RoonNonAc>)htl).GetAll();

foreach (RoonNonAc r in resultn)
{
    Console.WriteLine(r.RoomNo + " " + r.RoomType + " " + r.Price);
}


htl.AddRoom(new RoonNonAc() { RoomNo = 115, RoomType = "Double", Price = 8000 });

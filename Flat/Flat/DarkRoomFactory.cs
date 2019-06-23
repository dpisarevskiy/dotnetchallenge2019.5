namespace Flat
{
    public class DarkRoomFactory : IRoomFactory
    {
        public Room CreateRoom()
        {
            Room room = new Room();
            room.Chandelier = new DarkChandelier();
            room.Wallpaper = new DarkWallpaper();

            return room;
        }

        public Balcony CreateBalcony()
        {
            return new Balcony()
            {
                WindowsColor = "Dark"
            };
        }
    }
}
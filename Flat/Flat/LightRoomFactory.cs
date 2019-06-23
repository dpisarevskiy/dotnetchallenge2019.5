namespace Flat
{
    public class LightRoomFactory : IRoomFactory
    {
        public Room CreateRoom()
        {
            Room room = new Room();
            room.Chandelier = new LightChandelier();
            room.Wallpaper = new LightWallpaper();

            return room;
        }

        public Balcony CreateBalcony()
        {
            return new Balcony()
            {
                WindowsColor = "Light"
            };
        }
    }
}
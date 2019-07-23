namespace Messenger
{
    class TelecomStation
    {
        public static void Connect(IMessenger from, IMessenger to)
        {
            UncleMajorMessenger temp = new UncleMajorMessenger(to);
            from.Connect(temp);
        }
    }
}
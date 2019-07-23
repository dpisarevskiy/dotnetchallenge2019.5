namespace Messenger
{
    class TelecomStation
    {
        public static void Connect(IMessenger from, IMessenger to)
        {
            from.Connect(to);
        }
    }
}
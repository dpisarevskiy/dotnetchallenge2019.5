    using System;
    namespace game{
    public class Style1:IStyle{
        public ConsoleColor ForegroundColor(){
            return ConsoleColor.White;
        }
        public ConsoleColor BackgroundColor(){
            return ConsoleColor.Green;
        }
    }
    }
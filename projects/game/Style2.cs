    using System;
    namespace game{
    public class Style2:IStyle{
        public ConsoleColor ForegroundColor(){
            return ConsoleColor.White;
        }
        public ConsoleColor BackgroundColor(){
            return ConsoleColor.Red;
        }
    }
    }
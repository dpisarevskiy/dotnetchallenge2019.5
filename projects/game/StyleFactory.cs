using System;
namespace game{
    public class StyleFactory:IStyleFactory{
        public IStyle GetStyle(string s){
            switch(s){
            case "Style1": return new Style1();
            case "Style2": return new Style2();
            default:       return new Style1();
            }
        }
    }
}
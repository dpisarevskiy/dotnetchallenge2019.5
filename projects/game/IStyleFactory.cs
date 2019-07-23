using System;
namespace game{
    public interface IStyleFactory{
        IStyle GetStyle(string s);
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace proxy
{
    public abstract class Loggers{
       public abstract void Write(string str);
    }

    public class FileLogger:Loggers{
        //private StreamWriter textWriter;
        private string textFile;
        public FileLogger(string f){
            textFile = Combine(CurrentDirectory, f);
        }
        public override void Write(string str){
            using (StreamWriter sw = new StreamWriter(textFile, true)) 
            {
                sw.WriteLine($"{DateTime.Now} FileLogger write: {str}");
            }
            Console.WriteLine($"{DateTime.Now} FileLogger write: {str}");
        }
    }

    public class ConsoleLogger:Loggers{
        public override void Write(string str){
            Console.WriteLine($"{DateTime.Now} Console Logger write: {str}");
        }
    }

public class Proxy: Loggers{
    private List<Loggers> loggers;
    private string configFile;
    public void LoggersInit(){
        //Lazy init
        if(loggers == null) {
            loggers = new List<Loggers>();

            using (StreamReader sr = new StreamReader(configFile)) 
            {
                while (sr.Peek() >= 0) 
                {
                    switch(sr.ReadLine()){
                        case "Console":
                            loggers.Add(new ConsoleLogger());
                            break;
                        case "File":
                            loggers.Add(new FileLogger("FileLogger.txt"));
                            break;
                        default:
                        Console.WriteLine("Logger not defined");
                        break;
                    }
                }
            }
        }
    }
    public Proxy(string configFilePath){
        configFile = configFilePath;//Combine(CurrentDirectory, configFileName);
    }

    public override void Write(string str){
        LoggersInit();
        //Console.WriteLine($"{DateTime.Now} Console Logger write: {str}");
        foreach(Loggers l in loggers){
            l.Write(str);
        }
    }
}

    class Program
    {
        static void Main(string[] args)
        {

        string configFilePath = Combine(CurrentDirectory, "config.txt");

        if (File.Exists(configFilePath)) 
            {
                File.Delete(configFilePath);
            }

        using (StreamWriter sw = new StreamWriter(configFilePath)) 
            {
                sw.WriteLine("Console");
                sw.WriteLine("File");
            }

            Loggers logger = new Proxy(configFilePath);
            logger.Write("test1");
            logger.Write("test2");
        }
    }
}

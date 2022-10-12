using System;

namespace BackendSpace
{
    public class Log
    {
        private string filename;
        private string initialpath;
        private string newpath;
        Log(string initialpath):filename(""), initialpath(initialpath), newpath("") { }
    }

    public class LogManager
    {
        Log* logs;
        LogManager(int length, string initialpath)
        {
            Log=new Log(initialpath)[length]
        }
    }

    public interface Backend
    {
        public LogManager cleanFolder(string path);
        public void analysis();
        //이거 2개는 진행 정도를 표시해야 하는데 어떻게 해야 할지 잘 모르겠다
    }

    public class BackTemp : Backend
    {
        public override LogManager cleanfolder(string path)
        {
            return new LogManager(1, path);
        }
        public override void analysis() { }
    }
}
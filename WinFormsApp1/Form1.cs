using BackendSpace;
using System.CodeDom.Compiler;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string path = "NONE";
        
        public Form1()
        {
            InitializeComponent();
        }

        private BackTemp bT = new BackTemp();

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Select(object sender, EventArgs e)
        {
            folderBrowserDialog1_HelpRequest(new object(), e);
            this.path=folderBrowserDialog.SelectedPath;
        }

        private LogManager? start(object sender, EventArgs e)
        {
            if (path == "NONE")
            {
                MessageBox.Show("정리할 폴더를 선택하세요", "폴더를 선택하지 않음");
                return null;
            }
            else return this.bT.cleanFolder(this.path);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            folderBrowserDialog.Reset();
            folderBrowserDialog.ShowDialog();
        }

        private void analysis(object sender, EventArgs e)
        {
            this.bT.analysis();
        }
    }
}

//뭔가 잘 안 되는 것 같아서 일단 한 파일에 만들었어요
namespace BackendSpace
{
    public class Log
    {
        private string filename;
        private string initialpath;
        private string newpath;
        public Log(string initialpath)
        {
            this.filename = "";
            this.initialpath = initialpath;
            this.newpath = "";
        }
    }

    public class LogManager
    {
        //포인터와 고정 크기 버퍼는 안전하지 않은 컨텍스트에서만 사용할 수 있습니다
        //왜인지는 모르겠지만 포인터를 선언할 수 없다고 한다
        private Log* logs;
        LogManager(int length, string initialpath)
        {
            //LogManager를 정리 후에 반환하도록 할 예정
            //length 길이만큼 initialpath를 매개변수에 넣고 싶은데 방법
            logs = new Log[length](initialpath);
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
        //왜 재정의할 적절한 메서드를 찾을 수 없을까
        public override LogManager cleanFolder(string path)
        {
            //일단 임시로 만들어둔 반환하는 LogManager
            return new LogManager(1, path);
        }
        public override void analysis() { }
    }
}
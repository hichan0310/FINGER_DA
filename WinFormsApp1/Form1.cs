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
                MessageBox.Show("������ ������ �����ϼ���", "������ �������� ����");
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

//���� �� �� �Ǵ� �� ���Ƽ� �ϴ� �� ���Ͽ� ��������
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
        //�����Ϳ� ���� ũ�� ���۴� �������� ���� ���ؽ�Ʈ������ ����� �� �ֽ��ϴ�
        //�������� �𸣰����� �����͸� ������ �� ���ٰ� �Ѵ�
        private Log* logs;
        LogManager(int length, string initialpath)
        {
            //LogManager�� ���� �Ŀ� ��ȯ�ϵ��� �� ����
            //length ���̸�ŭ initialpath�� �Ű������� �ְ� ������ ���
            logs = new Log[length](initialpath);
        }
    }

    public interface Backend
    {
        public LogManager cleanFolder(string path);
        public void analysis();
        //�̰� 2���� ���� ������ ǥ���ؾ� �ϴµ� ��� �ؾ� ���� �� �𸣰ڴ�
    }

    public class BackTemp : Backend
    {
        //�� �������� ������ �޼��带 ã�� �� ������
        public override LogManager cleanFolder(string path)
        {
            //�ϴ� �ӽ÷� ������ ��ȯ�ϴ� LogManager
            return new LogManager(1, path);
        }
        public override void analysis() { }
    }
}
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Select(object sender, EventArgs e)
        {

        }

        private void start(object sender, EventArgs e)
        {

        }
    }
}

public interface backend
{
    //������ ������ �ȿ� �� �� �ִ���
    public int getFileAmount();

    public void cleanFolder(string path);
    public void analysis();
    //�̰� 2���� ���� ������ ǥ���ؾ� �ϴµ� ��� �ؾ� ���� �� �𸣰ڴ�
}
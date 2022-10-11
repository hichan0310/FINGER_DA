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
    //정리할 파일이 안에 몇 개 있는지
    public int getFileAmount();

    public void cleanFolder(string path);
    public void analysis();
    //이거 2개는 진행 정도를 표시해야 하는데 어떻게 해야 할지 잘 모르겠다
}
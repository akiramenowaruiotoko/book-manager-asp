namespace BookManagerWinForm
{
    public partial class Home : Form
    {
        private int empNum = 0;
        private bool isEditor = false;
        private readonly DatabaseManager dbManager;

        public Home()
        {
            InitializeComponent();
            // �f�[�^�x�[�X�}�l�[�W���[�̏�����
            dbManager = new DatabaseManager();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // ���[�U�[�����͂����]�ƈ��ԍ��ƃp�X���[�h���擾
            empNum = int.Parse(textBoxEmpNum.Text);
            string empPass = textBoxEmpPass.Text;

            // �f�[�^�x�[�X�Ƃ̔�r���s��
            if (dbManager.CheckCredentials(empNum, empPass, out isEditor))
            {
                // �F�ؐ������̓��C�����j���[��ʂ�\��
                MainMenu form = new MainMenu(empNum, isEditor, this);
                form.Show();
                // ���O�C����ʂ��\��
                this.Hide();
            }
            else
            {
                // �F�؎��s���̓G���[���b�Z�[�W��\��
                MessageBox.Show("���[�U�[�ԍ��܂��̓p�X���[�h������������܂���B");
            }
        }
    }
}

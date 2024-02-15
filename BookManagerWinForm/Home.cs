using System;
using System.Windows.Forms;

namespace BookManagerWinForm
{
    public partial class Home : Form
    {
        private DatabaseManager dbManager;

        public Home()
        {
            InitializeComponent();
            // �f�[�^�x�[�X�}�l�[�W���[�̏�����
            dbManager = new DatabaseManager();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // ���[�U�[�����͂����]�ƈ��ԍ��ƃp�X���[�h���擾
            string empNum = textBoxEmpNum.Text;
            string empPass = textBoxEmpPass.Text;

            // �f�[�^�x�[�X�Ƃ̔�r���s��
            if (dbManager.CheckCredentials(empNum, empPass))
            {
                // �F�ؐ������̓��C�����j���[��ʂ�\��
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
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

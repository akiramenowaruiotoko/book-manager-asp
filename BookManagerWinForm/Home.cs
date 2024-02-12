using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BookManagerWinForm
{
    public partial class Home : Form
    {
        private string connectionString;

        public Home()
        {
            InitializeComponent();
            // �f�[�^�x�[�X�ڑ���������擾
            connectionString = ConfigurationManager.ConnectionStrings["sqlsvr"].ConnectionString;
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            // ���[�U�[�����͂����]�ƈ��ԍ��ƃp�X���[�h���擾
            string empNum = textBoxEmpNum.Text;
            string empPass = textBoxEmpPass.Text;

            // �f�[�^�x�[�X�Ƃ̔�r���s��
            if (CheckCredentials(empNum, empPass))
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

        private bool CheckCredentials(string empNum, string empPass)
        {
            // �f�[�^�x�[�X�Ƃ̐ڑ�
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // �N�G���̍쐬
                string query = "SELECT COUNT(*) FROM View_employees WHERE employee_number = @EmpNum AND employee_password = @EmpPass";

                // SqlCommand �̍쐬
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // �p�����[�^�̐ݒ�
                    command.Parameters.AddWithValue("@EmpNum", empNum);
                    command.Parameters.AddWithValue("@EmpPass", empPass);

                    // �R�l�N�V�����̃I�[�v��
                    connection.Open();
                    // �N�G���̎��s
                    int count = (int)command.ExecuteScalar();
                    // ���[�U�[�������������ǂ�����Ԃ�
                    return count > 0;
                }
            }
        }
    }
}

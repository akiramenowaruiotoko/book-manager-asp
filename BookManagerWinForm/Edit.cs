namespace BookManagerWinForm
{
    public partial class Edit : Form
    {
        private int empNum;
        private bool isEditor;
        private MainMenu mainMenuForm;

        public Edit(int empNum, bool isEditor, MainMenu mainMenu)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenu;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee form = new(empNum, isEditor, this);
            form.Show();
            this.Hide();
        }
    }
}
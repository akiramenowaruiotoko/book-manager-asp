namespace BookManagerWinForm
{
    public partial class Edit : Form
    {
        private int empNum;
        private bool isEditor;
        private MainMenu mainMenuForm;
        private DatabaseManager dbManager;

        public Edit(int empNum, bool isEditor, MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenuForm;
            dbManager = new DatabaseManager();
        }

        private void buttonBackPurchase_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }
    }
}

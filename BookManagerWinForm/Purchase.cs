namespace BookManagerWinForm
{
    public partial class Purchase : Form
    {
        private int empNum;
        private bool isEditor;
        private MainMenu mainMenuForm;
        private DatabaseManager dbManager;
        private string viewName;

        public Purchase(int empNum, bool isEditor, MainMenu mainMenuForm)
        {
            InitializeComponent();
            this.empNum = empNum;
            this.isEditor = isEditor;
            this.mainMenuForm = mainMenuForm;
            dbManager = new DatabaseManager();
            viewName = "View_all";
        }

        private void buttonBackPurchase_Click(object sender, EventArgs e)
        {
            mainMenuForm.Show();
            this.Close();
        }

        private void buttonApplication_Click(object sender, EventArgs e)
        {

        }
    }
}

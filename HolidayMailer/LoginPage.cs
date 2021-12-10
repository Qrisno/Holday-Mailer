namespace HolidayMailer
{
    public partial class LoginPage : Form
    {
        List <PersonModel> persons =  new List <PersonModel> ();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoadPeople()
        {
            persons = SqliteDataAccess.LoadPeople();
        }
    }
}


using BaseCleanArchProject.Presentation.controllers.user_controller;

namespace BaseCleanArchProject
{
    public partial class User : Form
    {
        User_controller uC = new User_controller();
        public User()
        {
            InitializeComponent();
        }

        private void b_Signup_Click(object sender, EventArgs e)
        {
            uC.Signup("user0", tB_userName.Text, "email@mail.com", "secure_password");
        }
    }
}
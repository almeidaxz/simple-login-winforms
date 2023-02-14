namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "user@user.com";
            string password = "bestuser";

            if(btnLogin.Text == "Sair")
            {
                lblLoginTitle.Text = "Login";
                txtUser.Enabled = true;
                txtPass.Enabled = true;
                txtUser.Text = "";
                txtPass.Text = "";
                btnLogin.Text = "Acessar";
                return;
            }

            if(string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Preencha todos os dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtUser.Text != user || txtPass.Text != password )
            {
                MessageBox.Show("Usuário ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLoginTitle.Text = "Logado";
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            btnLogin.Text = "Sair";
        }
    }
}
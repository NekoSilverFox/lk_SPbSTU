using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = this.txtLogin.Text.Trim();
            string pwd = this.txtPwd.Text.Trim();

            BLL.AccountManger accountManger = new BLL.AccountManger();
            MODEL.tb_Account account = accountManger.Login(login);

            if (account == null)
            {
                MessageBox.Show("Login does not exist");
            }
            else
            {
                if (pwd == account.Passwd)
                {
                    // 说明系统中存在这个用户，接下来应该判断用户的类型是什么
                    int account_id = account.IDAccount;
                    BLL.UserTypeManger userTypeManger = new BLL.UserTypeManger();
                    MODEL.UserType userType = userTypeManger.GetUserType(account_id);
                    MODEL.UserType.userType = userType.AccountUserType;
                    MODEL.tb_Account.accountIDNow = account.IDAccount;
                    MODEL.tb_Account.accountLoginNow = account.Login;

                    MessageBox.Show("Login successful\n" +
                        "Welcome: " + account.Login + "\n" +
                        "You are: " + userType.AccountUserType);

                    // 使用 ShowDialog方式打开的窗体，只要你能给其一个除了 None 之外的 DialogResult 值，那么窗体就可以关闭！
                    //this.Close();   // 【重点】将这个窗体关闭，会关闭由这个窗体打开的所有其他的窗体，不只是当前窗体！

                    // 应该按照一下方式关闭窗体
                    // this.DialogResult 保存了窗体的状态是。默认是 None
                    // 窗体的默认状态是 None（无法关闭窗体），如果登陆成功就把窗体状态设置为 OK 则可以关闭
                    // 然后在 Program.cs 中打开新的窗体，关闭当前的窗体
                    this.DialogResult = DialogResult.OK;

                    // 打开新的窗体
                    //MainForm mainForm = new MainForm();
                    //mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong passward");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

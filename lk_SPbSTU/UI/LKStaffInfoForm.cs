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
    public partial class LKStaffInfoForm : Form
    {
        public LKStaffInfoForm()
        {
            InitializeComponent();
        }

        private void LKStaffInfoForm_Load(object sender, EventArgs e)
        {
            // 获取这个员工的账号用于显示
            BLL.AccountManger accountManger = new BLL.AccountManger();
            MODEL.tb_Account account = accountManger.Login(MODEL.tb_Account.accountLoginNow);

            // 从Staff表中获取他的具体信息
            BLL.StaffManger staffManger = new BLL.StaffManger();
            MODEL.tb_Staff staff = staffManger.getStaffInfo(account.IDAccount);

            this.txtID.Text = account.IDAccount.ToString();
            this.txtLogin.Text = account.Login;
            this.txtName.Text = staff.NameStaff;
            this.txtGender.Text = staff.StrGender;
            this.dtpBirthday.Value = staff.Birthday;
            this.txtPhone.Text = staff.Phone.Trim();
            this.txtEmail.Text = staff.Email;
            this.txtHiredate.Text = Convert.ToDateTime(staff.Hiredate.ToString()).Year.ToString()
                + "-" + Convert.ToDateTime(staff.Hiredate.ToString()).Month.ToString()
                + "-" + Convert.ToDateTime(staff.Hiredate.ToString()).Day.ToString();
            this.txtPost.Text = staff.StrPost.Trim();
            this.txtInstitulate.Text = staff.StrInstitute.Trim();


        }


    }
}

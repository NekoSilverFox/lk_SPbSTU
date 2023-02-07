using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 正则表达式
using System.Text.RegularExpressions;

namespace UI
{
    public partial class AdminStudentForm : Form
    {
        /// <summary>
        /// 全局的 Institute 表业务层处理对象
        /// 用于加载下拉列表中的内容！！！
        /// </summary>
        BLL.InstituteManger instituteManger = new BLL.InstituteManger();

        /// <summary>
        /// 全局的 professionManger 表业务层处理对象
        /// </summary>
        BLL.ProfessionManger professionManger = new BLL.ProfessionManger();

        /// <summary>
        /// 全局的 professionManger 表业务层处理对象
        /// </summary>
        BLL.GroupManger groupManger = new BLL.GroupManger();

        BLL.StudentManger studentManger = new BLL.StudentManger();


        public AdminStudentForm()
        {
            InitializeComponent();

            // 如果没有绑定的列不会自动生成显示
            this.dgvList.AutoGenerateColumns = false;
        }

        private void AdminStudentForm_Load(object sender, EventArgs e)
        {

            // 绑定学院下拉列表数据
            this.cboInstitute.DisplayMember = "ShortNameInst";      // 显示的值
            this.cboInstitute.ValueMember = "IDInstitute";              // 注意这里，绑定实际的值
            this.cboInstitute.DataSource = instituteManger.GetAllInstituteList();  // 绑定集合

            // 绑定方向下拉列表数据
            this.cboProfession.DisplayMember = "NameProfession";
            this.cboProfession.ValueMember = "IDProfession";              // 注意这里，绑定实际的值
            //this.cboProfession.DataSource = professionManger.GetAllProfessionList();  // 绑定集合


            this.cboGroup.DisplayMember = "NameGroup";
            this.cboGroup.ValueMember = "IDGroup";


            // 绑定学院下拉列表数据
            this.cboAddInstitute.DisplayMember = "ShortNameInst";      // 显示的值
            this.cboAddInstitute.ValueMember = "IDInstitute";              // 注意这里，绑定实际的值
            this.cboAddInstitute.DataSource = instituteManger.GetAllInstituteList();  // 绑定集合

            // 绑定方向下拉列表数据
            this.cboAddProfession.DisplayMember = "NameProfession";
            this.cboAddProfession.ValueMember = "IDProfession";              // 注意这里，绑定实际的值
            //this.cboProfession.DataSource = professionManger.GetAllProfessionList();  // 绑定集合


            this.cboAddGroup.DisplayMember = "NameGroup";
            this.cboAddGroup.ValueMember = "IDGroup";
        }

        private void cboInstitute_SelectedIndexChanged(object sender, EventArgs e)
        {
            int instutiteID = (this.cboInstitute.SelectedItem as MODEL.tb_Institute).IDInstitute;

            // 【重点】先清空！！！
            //this.cboProfession.Items.Clear();

            List<MODEL.tb_Profession> professionsList = professionManger.GetAllProfessionList();
            List<MODEL.tb_Profession> showProfessionsList = new List<MODEL.tb_Profession>();
            foreach (MODEL.tb_Profession profession in professionsList)
            {
                if (profession.InstituteID == instutiteID)
                {
                    showProfessionsList.Add(profession);
                }
            }

            this.cboProfession.DataSource = showProfessionsList;
        }

        private void cboAddInstitute_SelectedIndexChanged(object sender, EventArgs e)
        {
            int instutiteID = (this.cboAddInstitute.SelectedItem as MODEL.tb_Institute).IDInstitute;

            // 【重点】先清空！！！
            //this.cboProfession.Items.Clear();

            List<MODEL.tb_Profession> professionsList = professionManger.GetAllProfessionList();
            List<MODEL.tb_Profession> showProfessionsList = new List<MODEL.tb_Profession>();
            foreach (MODEL.tb_Profession profession in professionsList)
            {
                if (profession.InstituteID == instutiteID)
                {
                    showProfessionsList.Add(profession);
                }
            }

            this.cboAddProfession.DataSource = showProfessionsList;
        }

        private void cboProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int professionID = (this.cboProfession.SelectedItem as MODEL.tb_Profession).IDProfession;

            // 【重点】先清空！！！
            //this.cboProfession.Items.Clear();

            List<MODEL.tb_Group> groupList = groupManger.GetAllGroupList();
            List<MODEL.tb_Group> showGroupList = new List<MODEL.tb_Group>();
            foreach (MODEL.tb_Group group in groupList)
            {
                if (group.IDProfession == professionID)
                {
                    showGroupList.Add(group);
                }
            }

            this.cboGroup.DataSource = showGroupList;
        }

        private void cboAddProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            int professionID = (this.cboAddProfession.SelectedItem as MODEL.tb_Profession).IDProfession;

            // 【重点】先清空！！！
            //this.cboProfession.Items.Clear();

            List<MODEL.tb_Group> groupList = groupManger.GetAllGroupList();
            List<MODEL.tb_Group> showGroupList = new List<MODEL.tb_Group>();
            foreach (MODEL.tb_Group group in groupList)
            {
                if (group.IDProfession == professionID)
                {
                    showGroupList.Add(group);
                }
            }

            this.cboAddGroup.DataSource = showGroupList;
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            if (cboGroup.SelectedItem == null)
            {
                MessageBox.Show("Please chose a group");
            }

            int idGroup = (cboGroup.SelectedItem as MODEL.tb_Group).IDGroup;

            List<MODEL.tb_Student> studentListByGroupID = studentManger.GetStudentListByGroupID(idGroup);

            if (studentListByGroupID.Count == 0)
            {
                MessageBox.Show("Do not have any student in this group");
                return;
            }

            this.dgvList.DataSource = studentListByGroupID;
        }

        private void tsmiAddInstitue_Click(object sender, EventArgs e)
        {
            gpAdd.Visible = true;
            gpAdd.Text = "Добавление";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 隐藏面板
            this.gpAdd.Visible = false;
            this.txtLogin.Text = this.txtPwd.Text = this.txtName.Text = this.txtPhone.Text = this.txtEmail.Text = "";
            this.cboAddInstitute.SelectedIndex = this.cboAddProfession.SelectedIndex = this.cboAddGroup.SelectedIndex = 0;

        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvList.SelectedRows.Count == 0)
            {
                return;
            }
            gpAdd.Visible = true;
            gpAdd.Text = "Изменение";

            // 获取绑定项
            MODEL.tb_Student student = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Student;

            // 将绑定项中的内容显示在修改窗口上
            this.txtLogin.Text = student.Login;
            this.txtPwd.Text = student.Passwd;
            this.txtName.Text = student.NameStudent;

            rdoMam.Checked = student.Gender;
            rdoWoman.Checked = !student.Gender;

            this.dtpBirthday.Value =  student.Birthday;

            this.txtPhone.Text = student.Phone.ToString();
            this.txtEmail.Text = student.Email;

            this.dtpEnrollTime.Value = student.EnrollTime;

            this.cboAddInstitute.DataSource = this.cboAddInstitute.DataSource;
            this.cboAddInstitute.SelectedIndex = this.cboAddInstitute.SelectedIndex;

            this.cboAddProfession.DataSource = this.cboProfession.DataSource;
            this.cboAddProfession.SelectedIndex = this.cboProfession.SelectedIndex;

            this.cboAddGroup.DataSource = this.cboGroup.DataSource;
            this.cboAddGroup.SelectedValue = this.cboGroup.SelectedValue;
        }

        #region + 新增/修改 列表点击 OK 按钮
        /// <summary>
        /// 新增/修改 列表点击 OK 按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidataUser())
            {
                return;
            }

            MODEL.tb_Student newStudent = null;

            if (gpAdd.Text == "Добавление")
            {
                newStudent = new MODEL.tb_Student();
            }
            else
            {
                newStudent = this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Student;
            }

            // ----------------------------------------------------------------------------------------------------------
            newStudent.Login = this.txtLogin.Text.ToString().Trim();
            newStudent.Passwd = this.txtPwd.Text.ToString().Trim();
            newStudent.Passwd = BLL.CommonHelper.GetMD5(newStudent.Passwd);
            newStudent.NameStudent = this.txtName.Text.ToString().Trim();
            newStudent.Gender = this.rdoMam.Checked ? true : false;
            newStudent.Birthday = this.dtpBirthday.Value;
            newStudent.Phone = this.txtPhone.Text.ToString().Trim();
            newStudent.Email = this.txtEmail.Text.ToString().Trim();
            newStudent.EnrollTime = this.dtpEnrollTime.Value;
            newStudent.GroupID = (this.cboAddGroup.SelectedItem as MODEL.tb_Group).IDGroup;
            // ----------------------------------------------------------------------------------------------------------

            if (gpAdd.Text == "Добавление")
            {
                if (studentManger.InsertStudent(newStudent) != 0)
                {
                    MessageBox.Show("Successfully added new Student");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = studentManger.GetStudentListByGroupID(newStudent.GroupID);
                }
                else
                {
                    MessageBox.Show("Failed to add new Student");
                }
            }
            else
            {
                if (studentManger.UpdateStudent(newStudent) != 0)
                {
                    MessageBox.Show("Successfully change Student");

                    // 【重点】添加成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = studentManger.GetStudentListByGroupID(newStudent.GroupID);
                }
                else
                {
                    MessageBox.Show("Failed to change Student");
                }
            }
        }
        #endregion


        #region 用户信息输入检测+bool ValidataUser()
        /// <summary>
        /// 用户信息输入检测
        /// </summary>
        /// <returns></returns>
        bool ValidataUser()
        {
            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtLogin.Text.Trim()))
            {
                MessageBox.Show("Please enter a legal login");

                // 【重点】定位光标
                txtLogin.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtPwd.Text.Trim()))
            {
                MessageBox.Show("Password can not be empty");

                // 【重点】定位光标
                txtPwd.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter a legal name");

                // 【重点】定位光标
                txtName.Focus();
                return false;
            }

            // 如果为空，或者有非法字符
            if (string.IsNullOrEmpty(this.txtPhone.Text.Trim()) || Regex.IsMatch(txtPhone.Text.Trim(), @"\W"))
            {
                MessageBox.Show("Please enter a legal phone number");

                // 【重点】定位光标
                txtPhone.Focus();
                return false;
            }

            // 填了邮箱就判断邮箱格式是否正确
            if (!string.IsNullOrEmpty(this.txtEmail.Text.Trim()))
            {
                if (!Regex.IsMatch(txtEmail.Text.Trim(), @"\w+[@]\w+[.]\w+"))
                {
                    MessageBox.Show("Please enter a legal Email");
                    txtEmail.Focus();
                    return false;
                }
            }

            // 没有选中所有的下拉列表
            if (cboAddInstitute.SelectedItem == null ||
                cboAddProfession.SelectedItem == null ||
                cboAddGroup.SelectedItem == null)
            {
                MessageBox.Show("Please choose all items");

                return false;
            }

            return true;
        }
        #endregion

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvList.SelectedRows.Count == 0)
            {
                return;
            }

            int id = (this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Student).IDStudent;
            int groupID = (this.dgvList.CurrentRow.DataBoundItem as MODEL.tb_Student).GroupID;

            if (MessageBox.Show("Are you sure to delete this student？", "WANNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (studentManger.DeleteStudent(id) == 1)
                {
                    MessageBox.Show("Successfully delete");

                    // 【重点】删除成功后记得刷新！！！！也就是重新加载一下
                    this.dgvList.DataSource = studentManger.GetStudentListByGroupID(groupID);
                }
                else
                {
                    MessageBox.Show("Failed to delete");
                }
            }
        }
    }
}

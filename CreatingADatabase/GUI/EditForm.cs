using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreatingADatabase.DBAccess;
using CreatingADatabase.Objects;

namespace CreatingADatabase.GUI
{
    public partial class EditForm : Form
    {
        private Database db = MainApp.Db;
        ProjectDBAccess pdbAccess = new ProjectDBAccess(MainApp.Db);
        public EditForm()
        {
            InitializeComponent();  
            pdbAccess.GetAllProjects();
            List<Project> projects = pdbAccess.GetProjectObjectList();
            foreach (Project p in projects)
            {
                comboBoxSelectProj.Items.Add(p.ProjectCode + "-" + p.ProjectName);
            }
        }

        private void btnEditProj_Click(object sender, EventArgs e)
        {
            bool valid = true;
            ProjectDBAccess p = new ProjectDBAccess(db);
            Project project = new Project();
            project.ProjectCode = Convert.ToInt32(txtBoxProjID.Text);
            project.ProjectName = txtBoxProjTitle.Text;
            try
            {
                project.ManagerName = txtBoxProjManager.Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            project.ProjectBudget = Convert.ToDecimal(txtBoxProjBudget.Text);
            try
            {
                project.ProjectStartDate = calendarStartDate.SelectionStart;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            try
            {
                project.ProjectEndDate = calendarEndDate.SelectionStart;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            project.ProjectCompleted = checkBoxProjCompleted.Checked;
            if (valid)
            {
                p.UpdateProject(project);
                MessageBox.Show("Project Updooted!");
                ClearAllFields();
            }

        }

        private void comboBoxSelectProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectProj.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected a project!");
            }
            else
            {
                string[] selectedProject = new string[2];
                selectedProject = comboBoxSelectProj.SelectedItem.ToString().Split('-');
                int projectCode = Convert.ToInt32(selectedProject[0]);
                pdbAccess.GetProjectsWithID(projectCode);
                Project result = pdbAccess.GetProjectObject();
                txtBoxProjID.Text = result.ProjectCode.ToString();
                txtBoxProjTitle.Text = result.ProjectName;
                txtBoxProjManager.Text = result.ManagerName;
                txtBoxProjBudget.Text = result.ProjectBudget.ToString();
                calendarStartDate.SetDate(result.ProjectStartDate);
                calendarEndDate.SetDate(result.ProjectEndDate);
                checkBoxProjCompleted.Checked = result.ProjectCompleted;
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            txtBoxProjID.Text = "";
            txtBoxProjTitle.Text = "";
            txtBoxProjManager.Text = "";
            txtBoxProjBudget.Text = "";
            calendarStartDate.SelectionStart = DateTime.Now;
            calendarEndDate.SelectionStart = DateTime.Now;
            checkBoxProjCompleted.Checked = false;
        }
    }
}

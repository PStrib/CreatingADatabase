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
    public partial class AddProjectForm : Form
    {
        private Database db = MainApp.Db;
        ProjectDBAccess pdbAccess = new ProjectDBAccess(MainApp.Db);
        public AddProjectForm()
        {
            InitializeComponent();  
            pdbAccess.GetAllProjects();
            PopulateAvailableEmployees();
        }

        private void PopulateAvailableEmployees()
        {
            EmployeeDBAccess e = new EmployeeDBAccess(db);
            e.GetAllEmployees();
            List<Employee> employees = e.GetEmployeeObjectList();
            foreach(Employee emp in employees)
            {
                lboxAvailableEmployees.Items.Add(emp.EmployeeName);
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e){}

        private void btnEditProj_Click(object sender, EventArgs e){}

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            txtBoxProjTitle.Text = "";
            txtBoxProjManager.Text = "";
            txtBoxProjBudget.Text = "";
            calendarStartDate.SelectionStart = DateTime.Now;
            calendarEndDate.SelectionStart = DateTime.Now;
        }

        private void checkBoxProjCompleted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProj_Click(object sender, EventArgs e)
        {
            bool valid = true;
            ProjectDBAccess p = new ProjectDBAccess(db);
            Project project = new Project();

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
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            try
            {
                project.ProjectEndDate = calendarEndDate.SelectionStart;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); valid = false; }

            project.ProjectCompleted = checkBoxProjCompleted.Checked;
            if (valid)
            {
                EmployeeDBAccess eDBAccess = new EmployeeDBAccess(db);
                ProjectEmployeeDBAccess peDBAccess = new ProjectEmployeeDBAccess(db);
                p.AddNewProject(project);
                int projectID = pdbAccess.GetLastProjectID();
                foreach (var employee in lboxSelectedEmployees.Items)
                {
                    eDBAccess.GetEmployeesByName(employee.ToString());
                    Employee emp = eDBAccess.GetEmployeeObject();
                    int employeeID = emp.EmployeeNo;
                    ProjectEmployee projectEmployee = new ProjectEmployee(projectID, employeeID);
                    peDBAccess.AddNewProjectEmployee(projectEmployee);
                }
                MessageBox.Show("Project Added!");
                ClearAllFields();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (lboxAvailableEmployees.SelectedIndex == -1)
                    throw new Exception("No employee selected");
                lboxSelectedEmployees.Items.Add(lboxAvailableEmployees.SelectedItem.ToString());
                lboxAvailableEmployees.Items.Remove(lboxAvailableEmployees.SelectedItem.ToString());
                lboxSelectedEmployees.Sorted = true;
                lboxAvailableEmployees.Sorted = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            try
            {
                if (lboxSelectedEmployees.SelectedIndex == -1)
                    throw new Exception("No employee selected");
                lboxAvailableEmployees.Items.Add(lboxSelectedEmployees.SelectedItem.ToString());
                lboxSelectedEmployees.Items.Remove(lboxSelectedEmployees.SelectedItem.ToString());
                lboxSelectedEmployees.Sorted = true;
                lboxAvailableEmployees.Sorted = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

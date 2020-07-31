using Caliburn.Micro;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ThirdCaliburnApp.Models;

namespace ThirdCaliburnApp.ViewModels
{
    public class MainViewModel :Conductor<object>,IHaveDisplayName 
    {
        #region 속성 영역
        int id;
        string empName;
        decimal salary;
        string deptName;
        string destination;
        public MainViewModel()
        {
            GetEmployees();
        }

        #endregion

        #region 생성자 영역
        
        public void NewEmployee()
        {
            Id = 0;
            EmpName = string.Empty;
            Salary = 0;
            DeptName = string.Empty;
            Destination = string.Empty;
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
                NotifyOfPropertyChange(() => Id);
                NotifyOfPropertyChange(() => CanDeleteEmployee);
            }
        }
        public string EmpName
        { get => empName;
            set
            {
                empName = value;
                NotifyOfPropertyChange(() => EmpName);
                NotifyOfPropertyChange(() => CanSaveEmployee);
            }
        }
        public decimal Salary
        {
            get => salary;
            set
            {
                salary = value;
                NotifyOfPropertyChange(() => Salary);
                NotifyOfPropertyChange(() => CanSaveEmployee);
            }
        }
        public string DeptName
        {
            get => deptName;
            set
            {
                deptName = value;
                NotifyOfPropertyChange(() => DeptName);
                NotifyOfPropertyChange(() => CanSaveEmployee);
            }
        }
        public string Destination
        {
            get => destination;
            set
            {
                destination = value;
                NotifyOfPropertyChange(() => Destination);
                NotifyOfPropertyChange(() => CanSaveEmployee);
            }
        }

        // 전체 Employees 리스트
        BindableCollection<EmployeesModel> employees;
        public BindableCollection<EmployeesModel> Employees 
        { 
            get => employees;
            set
            {
                employees = value;
                NotifyOfPropertyChange(() => Employees);
            } 
        }

        // 리스트 중 선택된 하나의 Employees
        EmployeesModel selectedEmployee;

        public EmployeesModel SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;

                Id = value.Id;
                EmpName = value.EmpName;
                Salary = value.Salary;
                DeptName = value.DeptName;
                Destination = value.Destination;
                NotifyOfPropertyChange(() => SelectedEmployee);
            }
        }

        #endregion


        private void GetEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(EmployeesTbl.SELECT_EMPLOYEES, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Employees = new BindableCollection<EmployeesModel>();
                while (reader.Read())
                {
                    var temp = new EmployeesModel
                    {
                        Id = (int)reader["id"],
                        EmpName = reader["EmpName"].ToString(),
                        Salary = (decimal)reader["Salary"],
                        DeptName = reader["DeptName"].ToString(),
                        Destination = reader["Destination"].ToString()
                    };
                    Employees.Add(temp);
                }
            }
        }

        public bool CanSaveEmployee
        {
            get => !(string.IsNullOrEmpty(EmpName) ||
                     string.IsNullOrEmpty(DeptName) ||
                     string.IsNullOrEmpty(Destination) ||
                     Salary == 0);
        }

        public void SaveEmployee()
        {
            int resultRow = 0;
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                if (Id == 0)
                    cmd.CommandText = EmployeesTbl.INSERT_EMPLOYEE;
                else
                    cmd.CommandText = EmployeesTbl.UPDATE_EMPLOYEE;


                MySqlParameter paramEmpName = new MySqlParameter("@EmpName", MySqlDbType.VarChar, 45);
                paramEmpName.Value = EmpName;
                cmd.Parameters.Add(paramEmpName);
                MySqlParameter paramSalary = new MySqlParameter("@Salary", MySqlDbType.Decimal);
                paramSalary.Value = Salary;
                cmd.Parameters.Add(paramSalary);
                MySqlParameter paramDeptName = new MySqlParameter("@DeptName", MySqlDbType.VarChar, 45);
                paramDeptName.Value = DeptName;
                cmd.Parameters.Add(paramDeptName);
                MySqlParameter paramDestination = new MySqlParameter("@Destination", MySqlDbType.VarChar, 45);
                paramDestination.Value = Destination;
                cmd.Parameters.Add(paramDestination);

                if (Id != 0)
                {
                    MySqlParameter paramId = new MySqlParameter("@id", MySqlDbType.Int32);
                    paramId.Value = Id;
                    cmd.Parameters.Add(paramId);
                }
                resultRow = cmd.ExecuteNonQuery();
            }
            if (resultRow >0)
            {
                MessageBox.Show("저장했습니다");
                NewEmployee();
                GetEmployees();
            }
        }

        public bool CanDeleteEmployee
        {
            get => !(Id == 0);
        }

        public void DeleteEmployee()
        {
            int resultRow = 0;

            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = EmployeesTbl.DELETE_EMPLOYEE;
                
                MySqlParameter paramId = new MySqlParameter("@id", MySqlDbType.Int32);
                paramId.Value = Id;
                cmd.Parameters.Add(paramId);

                resultRow = cmd.ExecuteNonQuery();
            }
            if (resultRow >0)
            {
                MessageBox.Show("삭제했습니다");
                NewEmployee();
                GetEmployees();
            }
                
        }
    }
}

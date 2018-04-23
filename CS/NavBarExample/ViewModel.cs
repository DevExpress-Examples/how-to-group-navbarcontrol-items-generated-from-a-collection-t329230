using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace NavBarExample
{
    public class ViewModel
    {
        public ObservableCollection<Employee> Employees
        {
            get;
            set;
        }

        public ViewModel()
        {
            Employees = new ObservableCollection<Employee>() {
            new Employee(){Name="Alex", Department="Management"},
            new Employee(){Name="Paul", Department="Logistics"},
            new Employee(){Name="Peter", Department="Logistics"},
            new Employee(){Name="Mary", Department="Management"},
            new Employee(){Name="John", Department="Sales"},
            new Employee(){Name="Mark", Department="Sales"},
            new Employee(){Name="Kumar", Department="Advertisement"},
            new Employee(){Name="Janet", Department="Logistics"},
            new Employee(){Name="Tom", Department="Advertisement"},};
        }
    }

    public class Employee
    {
        public string Name
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
    }
}

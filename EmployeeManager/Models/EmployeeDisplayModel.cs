using EmployeeManager.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Models
{
    public class EmployeeDisplayModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
    }
}
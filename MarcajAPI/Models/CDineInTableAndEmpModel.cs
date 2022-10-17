using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
namespace MarcajAPI.Models
{
    public partial class CDineInTableAndEmpModel
    {
        private string _EmpId;
        private DineInTable _DineIn;
        public DineInTable DineIn { get { return _DineIn; } set { _DineIn = value; } }
        public string EmpName { get { return _EmpId; } set { _EmpId = value; } }
    }
}
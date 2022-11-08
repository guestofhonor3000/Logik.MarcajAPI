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
        private bool _Opened;
        private DateTime _TimeOpened;

        public DateTime TimeOpened { get { return _TimeOpened; } set { _TimeOpened = value; } }
        public bool Opened { get { return _Opened; } set { _Opened = value; } }
        public DineInTable DineIn { get { return _DineIn; } set { _DineIn = value; } }
        public string EmpName { get { return _EmpId; } set { _EmpId = value; } }
    }
}
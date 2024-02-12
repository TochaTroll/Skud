using SKUD.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUD.ViewModels
{
    public class ViewAdmissionTeacher
    {
        public string FullName { get; set; } = null!;
        public int CabinetNumber { get; set; } 
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string State { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKUD.ViewModels
{
    public class ViewAdmission
    {     
        public string FullName { get; set; } = null!;

        public string Documents { get; set; } = null!;

        public string DocumentNumber { get; set; } = null!;

        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string State { get; set; } = null!;
    }
}

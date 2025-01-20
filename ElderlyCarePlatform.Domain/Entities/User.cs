using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElderlyCarePlatform.Domain.Entities
{
    public class User
    {
        public string? FullName { get; set; }
        public string? Preferences { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
    }
}

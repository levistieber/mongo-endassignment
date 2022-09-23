using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workPls
{
    public class UserModel
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string birthdate { get; set; }
        public bool activated { get; set; }
        public int wrongAttempts { get; set; }
        public string blockedSince { get; set; }
    }
}

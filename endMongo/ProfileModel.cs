using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workPls
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public int age { get; set; }
        public Language languageID { get; set; }
    }

    public class Language
    {
        public int Id { get; set; }
        public string name  { get; set; }
    }
}

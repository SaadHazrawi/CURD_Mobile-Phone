using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDomin
{
    public class Specifications
    {
        public int Id { get; set; }
        public string Descraption { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public MobilePhone MobilePhone { get; set; } = new MobilePhone();
        public int MobilePhoneId { get; set; }

    }
}

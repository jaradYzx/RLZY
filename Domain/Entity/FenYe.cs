using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class FenYe<T>
    {
        public List<T> data { get; set; }

        public int rows { get; set; }
    }
}

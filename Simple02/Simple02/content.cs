using System;
using System.Collections.Generic;
using System.Text;

namespace Simple02
{
    public class content
    {
        public int id { get; set; }

        public string title { get; set; }

        public string contents { get; set; }

        public int status { get; set; }

        public DateTime add_time { get; set; } = DateTime.Now;

        public DateTime? modify_time { get; set; }
    }
}

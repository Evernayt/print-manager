using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Manager
{
    public class printersFlyoutMenuItem
    {
        public printersFlyoutMenuItem()
        {
            TargetType = typeof(printersFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
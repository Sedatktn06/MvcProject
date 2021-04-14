using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; } //Kategorileri silmek yerine pasif ya da aktif duruma alacağız.Bu property'de bunu gösterecek bize.
        public ICollection<Heading> Headings { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LipraryMVP.Views.Interface
{
     interface ICategory
    {
         int ID { get; set; }
         string CatName { get; set; }
    }
}

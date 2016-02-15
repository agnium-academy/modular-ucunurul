using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcWidgetBuilder.Models
{
    public interface ISubWidget
    {
        string Topic { get; set; }
        string Description { get; set; }
        
    }
}

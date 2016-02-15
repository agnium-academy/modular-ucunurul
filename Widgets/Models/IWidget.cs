﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcWidgetBuilder.Models
{
  public  interface IWidget
    {
        int SortOrder { get; set; }
        string ClassName { get; set; }
        string FooterText { get; set; }
        string HeaderText { get; set; }        
        ISubWidget SubWidget { get; set; }
    }
}

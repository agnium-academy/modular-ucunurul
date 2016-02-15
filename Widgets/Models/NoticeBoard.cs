using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWidgetBuilder.Models
{
    public class NoticeBoard : IWidget
    {
        public int SortOrder { get; set; }
        public string ClassName { get; set; }    
        public string FooterText { get; set; }    
        public string HeaderText { get; set; }    
        public ISubWidget SubWidget { get; set; }

    }
}
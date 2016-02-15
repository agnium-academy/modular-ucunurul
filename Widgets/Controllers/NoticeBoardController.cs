using MvcWidgetBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWidgetBuilder.Controllers
{
    public class NoticeBoardController : Controller
    {
        //
        // GET: /Widget/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyNoticeBoard()
        {
            ViewBag.Widgets = GetWidgetData();
            return View();
        }


        public List<IWidget> GetWidgetData()
        {
            var noticeboardWidget = new List<IWidget>
            {
                new NoticeBoard()
                {
                 SortOrder = 1, ClassName = "high", HeaderText = "Day 1", FooterText = "" ,
                SubWidget = new SubWidget { Topic = "Widget Concept ", Description = "What is Widget? Why it's so necessary? How the old-school web development and see the difference." },
                },
                 new NoticeBoard()
                {
               SortOrder = 4, ClassName = "medium", HeaderText = "Day 2", FooterText = "" ,
                SubWidget = new SubWidget { Topic = "JSON & Basic JavaScript", Description = "What is JSON? Relate to Map in Java, tell the main difference between Java & JS." },
                },
                new NoticeBoard()
                {
                 SortOrder = 8, ClassName = "low", HeaderText = "Day 3", FooterText = "" ,
                SubWidget = new SubWidget { Topic = "HTML & CSS", Description = "Learn how these two core items can generate reach UI with JS Combination." },
                },              
                new NoticeBoard()
                {
                 SortOrder = 2, ClassName = "high", HeaderText = "Day 4", FooterText = "" ,
                 SubWidget = new SubWidget { Topic = "Synchronous & Asynchronous", Description = "What's the main concept of these two things in a real world. Why these such things are exist in programming as well." },
                },
                 new NoticeBoard()
                {
               SortOrder = 5, ClassName = "medium", HeaderText = "Day 5", FooterText = "" ,
                SubWidget = new SubWidget { Topic = "Callback Function", Description = "Understand its concept and easy implementation on JS. Relate to Sync and Async from previous meeting." },
                },
               // new NoticeBoard()
               // {
               //  SortOrder = 7, ClassName = "low", HeaderText = "Notice Board", FooterText = "" ,
               // SubWidget = new SubWidget { Topic = "HoliDay Notice", Description = "We shifted our holiday leave for 1 day" },
               // },              
                 
               //  new NoticeBoard()
               // {
               //  SortOrder = 3, ClassName = "high", HeaderText = "Notice Board", FooterText = "" ,
               // SubWidget = new SubWidget { Topic = "Vacancy", Description = "We need a sound asp.net developer with C#" },
               // },
               //  new NoticeBoard()
               // {
               //SortOrder = 6, ClassName = "medium", HeaderText = "Notice Board", FooterText = "" ,
               // SubWidget = new SubWidget { Topic = "HR Notice", Description = "Visiting cards proof send to you mail please check" },
               // },
                          
            };

            return noticeboardWidget.OrderBy(p=>p.SortOrder).ToList();
        }
    }
}

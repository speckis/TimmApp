using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TimmApp.Models.Event;
using DayPilot.Web.Mvc;
using DayPilot.Web.Mvc.Events.Calendar;
using TimmApp.Models;
using DayPilot.Web.Mvc.Enums;
using DayPilot.Web.Mvc.Json;
using DayPilot.Web.Mvc.Data;
using DayPilot.Web.Mvc.Enums;
namespace TimmApp.Controllers
{
    public class EventController : Controller
    {
        //
        // GET: /Calendar/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Backend()
        {
            return new Dpc().CallBack(this);
        }

        class Dpc : DayPilotCalendar
        {
            TimmDbContext db = new TimmDbContext();

            protected override void OnInit(InitArgs e)
            {
                Events = from ev in db.events select ev;

                DataIdField = "id";
                DataTextField = "employee";
                DataStartField = "eventstart";
                DataEndField = "eventend";

                Update();
            }

            protected override void OnEventResize(EventResizeArgs e)
            {
                var toBeResized = (from ev in db.events where ev.id == Convert.ToInt32(e.Id) select ev).First();
                toBeResized.eventStart = e.NewStart;
                toBeResized.eventEnd = e.NewEnd;
                db.SubmitChanges();
                Update();
            }

            protected override void OnEventMove(EventMoveArgs e)
            {
                var toBeResized = (from ev in db.events where ev.id == Convert.ToInt32(e.Id) select ev).First();
                toBeResized.eventStart = e.NewStart;
                toBeResized.eventEnd = e.NewEnd;
                db.SubmitChanges();
                Update();
            }

            protected override void OnTimeRangeSelected(TimeRangeSelectedArgs e)
            {
                var toBeCreated = new Event
                {
                    eventStart = e.Start,
                    eventEnd = e.End,
                    employee = (string)e.Data["name"]
                };
                db.events.InsertOnSubmit(toBeCreated);
                db.SubmitChanges();
                Update();
            }

            protected override void OnFinish()
            {
                if (UpdateType == CallBackUpdateType.None)
                {
                    return;
                }

                Events = from ev in db.events select ev;

                DataIdField = "id";
                DataTextField = "text";
                DataStartField = "eventstart";
                DataEndField = "eventend";
            }
        }
	}
}
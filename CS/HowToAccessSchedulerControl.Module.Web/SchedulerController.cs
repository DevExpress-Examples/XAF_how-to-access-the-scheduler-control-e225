using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

using DevExpress.ExpressApp.Scheduler.Web;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;

using DevExpress.Persistent.Base.General;

namespace HowToAccessSchedulerControl.Module.Web {
    public class SchedulerController : ObjectViewController<ListView, IEvent> {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            ASPxSchedulerListEditor listEditor = View.Editor as ASPxSchedulerListEditor;
            if (listEditor != null) {
                ASPxScheduler scheduler = listEditor.SchedulerControl;
                scheduler.Views.DayView.VisibleTime =
                    new TimeOfDayInterval(new TimeSpan(6, 0, 0), new TimeSpan(11, 0, 0));
            }
        }
    }
}

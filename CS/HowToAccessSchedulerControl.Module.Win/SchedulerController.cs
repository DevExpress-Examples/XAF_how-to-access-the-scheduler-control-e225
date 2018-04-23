using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Scheduler.Win;
using DevExpress.Persistent.Base.General;
using DevExpress.XtraScheduler;

namespace HowToAccessSchedulerControl.Module.Win {
    public class SchedulerController : ObjectViewController<ListView, IEvent> {
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            SchedulerListEditor listEditor = View.Editor as SchedulerListEditor;
            if (listEditor != null) {
                SchedulerControl scheduler = listEditor.SchedulerControl;
                scheduler.Views.DayView.VisibleTime =
                    new TimeOfDayInterval(new TimeSpan(6, 0, 0), new TimeSpan(11, 0, 0));
            }
        }
    }
}

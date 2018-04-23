Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base

Imports DevExpress.ExpressApp.Scheduler.Web
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.XtraScheduler

Imports DevExpress.Persistent.Base.General

Namespace HowToAccessSchedulerControl.Module.Web
    Public Class WebSchedulerController
        Inherits ObjectViewController(Of ListView, IEvent)

        Protected Overrides Sub OnViewControlsCreated()
            MyBase.OnViewControlsCreated()
            Dim listEditor As ASPxSchedulerListEditor = TryCast(View.Editor, ASPxSchedulerListEditor)
            If listEditor IsNot Nothing Then
                Dim scheduler As ASPxScheduler = listEditor.SchedulerControl
                scheduler.Views.DayView.VisibleTime = New TimeOfDayInterval(New TimeSpan(8, 0, 0), New TimeSpan(17, 0, 0))
            End If
        End Sub
    End Class
End Namespace

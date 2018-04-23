Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Scheduler.Win
Imports DevExpress.Persistent.Base.General
Imports DevExpress.XtraScheduler

Namespace HowToAccessSchedulerControl.Module.Win
    Public Class SchedulerController
        Inherits ObjectViewController(Of ListView, IEvent)

        Protected Overrides Sub OnViewControlsCreated()
            MyBase.OnViewControlsCreated()
            Dim listEditor As SchedulerListEditor = TryCast(View.Editor, SchedulerListEditor)
            If listEditor IsNot Nothing Then
                Dim scheduler As SchedulerControl = listEditor.SchedulerControl
                scheduler.Views.DayView.VisibleTime = New TimeOfDayInterval(New TimeSpan(6, 0, 0), New TimeSpan(11, 0, 0))
            End If
        End Sub
    End Class
End Namespace

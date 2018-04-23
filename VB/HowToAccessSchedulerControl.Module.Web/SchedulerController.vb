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

Public Class SchedulerController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

	End Sub

    Private Sub SchedulerController_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      If View.ObjectTypeInfo.Implements(Of IEvent)() Then
         AddHandler View.ControlsCreated, AddressOf View_ControlsCreated
      End If
    End Sub
    Private Sub View_ControlsCreated(ByVal sender As Object, ByVal e As EventArgs)
        ' Access the current List View
        Dim currentView As ListView = CType(View, ListView)
        ' Access the View's List Editor as a SchedulerListEditor
        Dim listEditor As SchedulerListEditor = CType(currentView.Editor, SchedulerListEditor)
        '  Access the LOist Editor's ScheudlerControl  
        Dim scheduler As ASPxScheduler = CType(listEditor.Scheduler, ASPxScheduler)
        ' Set the desired time to be visible
        If Not scheduler Is Nothing Then
            scheduler.Views.DayView.VisibleTime = _
               New TimeOfDayInterval(New TimeSpan(6, 0, 0), New TimeSpan(23, 0, 0))
        End If
    End Sub
End Class

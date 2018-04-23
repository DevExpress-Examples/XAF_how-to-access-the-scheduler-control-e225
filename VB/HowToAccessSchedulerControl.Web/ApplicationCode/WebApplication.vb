Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace HowToAccessSchedulerControl.Web
   Partial Public Class HowToAccessSchedulerControlAspNetApplication
	   Inherits WebApplication
	  Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
	  Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
	  Private module3 As HowToAccessSchedulerControl.Module.HowToAccessSchedulerControlModule
	  Private module4 As HowToAccessSchedulerControl.Module.Web.HowToAccessSchedulerControlAspNetModule
	  Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
	  Private securitySimple1 As DevExpress.ExpressApp.Security.SecuritySimple
	  Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
	  Private authenticationActiveDirectory1 As DevExpress.ExpressApp.Security.AuthenticationActiveDirectory
	  Private sqlConnection1 As System.Data.SqlClient.SqlConnection
	  Private schedulerAspNetModule1 As DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule
	  Private schedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
	  Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

	  Public Sub New()
		 InitializeComponent()
	  End Sub

	  Private Sub HowToAccessSchedulerControlAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
		 If System.Diagnostics.Debugger.IsAttached Then
			e.Updater.Update()
			e.Handled = True
		 Else
			Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & "The automatical update is disabled, because the application was started without debugging." & Constants.vbCrLf & "You should start the application under Visual Studio, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database with the help of the 'DBUpdater' tool.")
		 End If
	  End Sub

	  Private Sub InitializeComponent()
		 Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
		 Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
		 Me.module3 = New HowToAccessSchedulerControl.Module.HowToAccessSchedulerControlModule()
		 Me.module4 = New HowToAccessSchedulerControl.Module.Web.HowToAccessSchedulerControlAspNetModule()
		 Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
		 Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
		 Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
		 Me.securitySimple1 = New DevExpress.ExpressApp.Security.SecuritySimple()
		 Me.authenticationActiveDirectory1 = New DevExpress.ExpressApp.Security.AuthenticationActiveDirectory()
		 Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
		 Me.schedulerAspNetModule1 = New DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule()
		 Me.schedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
		 CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		 ' 
		 ' module3
		 ' 
		 Me.module3.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Event))
		 ' 
		 ' module5
		 ' 
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
		 Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
		 ' 
		 ' securitySimple1
		 ' 
		 Me.securitySimple1.Authentication = Me.authenticationActiveDirectory1
		 Me.securitySimple1.UserType = GetType(DevExpress.Persistent.BaseImpl.BasicUser)
		 ' 
		 ' authenticationActiveDirectory1
		 ' 
		 Me.authenticationActiveDirectory1.CreateUserAutomatically = True
		 Me.authenticationActiveDirectory1.UserType = GetType(DevExpress.Persistent.BaseImpl.BasicUser)
		 ' 
		 ' sqlConnection1
		 ' 
		 Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=HowToAccessSchedulerControl;Integrated Securi" & "ty=SSPI;Pooling=false"
		 Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
		 ' 
		 ' schedulerAspNetModule1
		 ' 
		 Me.schedulerAspNetModule1.Description = "Uses the ASPxScheduler controls suite to display DevExpress.Persistent.Base.IEven" & "t objects in Web XAF applications."
		 Me.schedulerAspNetModule1.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.SystemModule.SystemModule))
		 Me.schedulerAspNetModule1.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Scheduler.SchedulerModuleBase))
		 ' 
		 ' HowToAccessSchedulerControlAspNetApplication
		 ' 
		 Me.ApplicationName = "HowToAccessSchedulerControl"
		 Me.Connection = Me.sqlConnection1
		 Me.Modules.Add(Me.module1)
		 Me.Modules.Add(Me.module2)
		 Me.Modules.Add(Me.module6)
		 Me.Modules.Add(Me.module3)
		 Me.Modules.Add(Me.module4)
		 Me.Modules.Add(Me.module5)
		 Me.Modules.Add(Me.securityModule1)
		 Me.Modules.Add(Me.schedulerModuleBase1)
		 Me.Modules.Add(Me.schedulerAspNetModule1)
		 Me.Security = Me.securitySimple1
'		 Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.HowToAccessSchedulerControlAspNetApplication_DatabaseVersionMismatch);
		 CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	  End Sub
   End Class
End Namespace

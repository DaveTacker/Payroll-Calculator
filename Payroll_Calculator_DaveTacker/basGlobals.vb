' ######################################################
' Some Globals which are used across the application
' ######################################################
Module Globals
    ' A structure for pay rates and jobs
    Public Structure PayRates
        Public Job As String
        Public PayRate As Double
    End Structure

    ' Make them accessable to the rest of the application
    Public arrPayRates() As PayRates

    ' Declare some constants and assign them. (they are percentages)
    Public Const INCOME_TAX As Decimal = CDec(0.18)
    Public Const MEDICARE As Decimal = CDec(0.0145)
    Public Const SOCIAL_SECURITY As Decimal = CDec(0.062)
End Module

' ######################################################
' A public class object, used to create new Payrates. Usage:
' Dim job As String = InputBox("Enter a job code")
' Dim NewJob As New PayRatesDuece
' NewJob.Job = job
' NewJob.PayRate = InputBox("And the pay rate for " + job + "?")
' ######################################################
Public Class PayRatesDuece
    Private _Job As String
    Private _PayRate As String
    Private _GoodData As Boolean

    Public Property Job() As String
        ' Returns the _Job property
        Get
            Return _Job
        End Get

        Set(value As String)
            ' Has the _Job property already been set? If so, exit.
            If _Job <> "" Then
                Exit Property
            End If

            Dim strNewJob As String = DoubleCheckJob(value)

            Select Case strNewJob
                Case "" ' The user clicked cancel on the inputbox.
                    _GoodData = False
                    Exit Property
                Case Else
                    ' Set the job Value
                    _Job = strNewJob
            End Select

        End Set
    End Property

    Public Property PayRate() As String
        ' Returns the _PayRate property
        Get
            Return _PayRate
        End Get

        Set(value As String)
            ' Has the _PayRate property already been set? If so, exit.
            If _PayRate <> "" Then
                Exit Property
            End If

            ' Nag the user until they input the correct dollar value
            While Not IsNumeric(value)
                ' Did the user click cancel?
                If value = "" Then
                    _GoodData = False
                    Exit Property
                End If

                value = InputBox("Sorry, make sure you enter numbers only into this area. ex: 9.50")
            End While

            ' Set the _PayRate value
            _PayRate = value
        End Set
    End Property

    Public Sub New()
        _GoodData = True
    End Sub

    Public ReadOnly Property GoodData As Boolean
        Get
            Return _GoodData
        End Get
    End Property
End Class

' ######################################################
' This Module contains a class which is used to easily populate
' an Employees.xml file and create an array: arrEmployeeList
' IMPORTANT!!!!! Be sure to put the ID as the second argument, this is how I'm deleting entries.
' Usage: EmployeeCollection.Add(New Employee(ID, firstName, lastName, Address, City, State, ZipCode, JobCode), ID)
' ######################################################
Module Xml
    ' The collection which we will store all Employees in
    Public EmployeeCollection As New Collection

    ' An Employee class, making it MUCH easier to add new employees to the array
    Class Employee
        Public Sub New(ByVal ID As String, _
                       ByVal firstName As String, _
                       ByVal lastName As String, _
                       ByVal Address As String, _
                       ByVal City As String, _
                       ByVal State As String, _
                       ByVal ZipCode As Integer, _
                       ByVal JobCode As String)

            ' Set the fields of the Employee class
            Me._ID = ID
            Me._firstName = firstName
            Me._lastName = lastName
            Me._Address = Address
            Me._City = City
            Me._State = State
            Me._ZipCode = ZipCode
            Me._JobCode = JobCode
        End Sub

        ' The storage of the employee data across the application
        Public _ID As String
        Public _firstName As String
        Public _lastName As String
        Public _Address As String
        Public _City As String
        Public _State As String
        Public _ZipCode As Integer
        Public _JobCode As String

    End Class
End Module
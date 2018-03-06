Imports System.Collections.Generic
Imports System.IO
Imports System.Timers
Module Module1
    Dim aTimer As New System.Timers.Timer
    Dim p() As Process
    Private eventlog As List(Of String)
    Private nEventsFired As Integer = 0
    Sub Main()
        eventlog = New List(Of String)()
        aTimer.AutoReset = True
        aTimer.Interval = 2000 '2 seconds
        AddHandler aTimer.Elapsed, AddressOf tick
        aTimer.Start()
        Console.WriteLine("Press the Enter key to exit the program... ")
        Console.ReadLine()
        For Each item In eventlog
            Console.WriteLine(item)
        Next
        Console.WriteLine("Terminating the application...")
    End Sub
    Private Sub tick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        p = Process.GetProcessesByName("TRACERT")
        If p.Count < 1 Then
            Console.WriteLine(" TRACERT Çalıştı..")
            Process.Start("C:\sysnet.cmd")
        End If
    End Sub
End Module

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim LOG_FILE As String = "logs\latest.log"

        If System.IO.File.Exists(LOG_FILE) = True Then
            Process.Start(LOG_FILE)
        Else
            MsgBox("Log file not found, make sure you are running this program in the same folder as the server.")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BAT_FILE As String = "run.bat"
        If System.IO.File.Exists(BAT_FILE) = True Then
            System.Diagnostics.Process.Start("run.bat")
        Else
            MsgBox("Startup .bat file not found, make sure it's in the server directory.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim credits As New AboutBox1()
        credits.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

   
 

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class



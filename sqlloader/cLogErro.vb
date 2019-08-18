Imports System.IO
Public Class cLogErro
    Const DefaultLogFile As String = "C:\SQLLOADER\logerro.txt"
    Shared Sub criaLog(ByVal msg As String)
        Dim Data_hoje As DateTime = DateTime.Now

        Dim objLogFile As StreamWriter
        Try
            If IO.File.Exists(DefaultLogFile) Then
                objLogFile = File.AppendText(DefaultLogFile)
            ElseIf Directory.Exists(Path.GetDirectoryName(DefaultLogFile)) Then
                objLogFile = File.CreateText(DefaultLogFile)
            Else
                objLogFile = File.AppendText(DefaultLogFile)
            End If

            msg = CStr(FormatDateTime(Data_hoje, DateFormat.GeneralDate)) & " - " & msg
            objLogFile.WriteLine(msg)
            objLogFile.Flush()
            objLogFile.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Shared Sub apagaLog()
        If IO.File.Exists(DefaultLogFile) Then
            File.Delete(DefaultLogFile)
        End If
    End Sub
End Class


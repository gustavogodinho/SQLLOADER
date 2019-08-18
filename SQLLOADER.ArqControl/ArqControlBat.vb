Public Class ArqControlBat
    Public Function CreateArqControlBat(sUser As String, cmbDataBase As String, sPwd As String, DefaultContrlFile As String, cmbIntoTable As String, sRowsCommit As Integer) As String

        Dim sLinhaComando As String
        Dim sArqControlBat As String = String.Empty

        sLinhaComando = "sqlldr userid=" + sUser + "@" & cmbDataBase & "/" + sPwd + " control='" & DefaultContrlFile & "' log='" & "C:\SQLLOADER\control_" & cmbIntoTable & ".log'"
        sArqControlBat &= sLinhaComando
        sArqControlBat += "bindsize=512000 readsize=1024000 direct=True rows=" + sRowsCommit + vbCrLf
        sArqControlBat += "%systemroot%\notepad.exe """ & "C:\SQLLOADER\control_" & cmbIntoTable & ".log"""


        Return sArqControlBat
    End Function

End Class

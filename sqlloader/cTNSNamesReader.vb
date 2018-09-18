Imports Microsoft.Win32
Imports System.Text.RegularExpressions
Imports System.IO

Public Class cTNSNamesReader

    Private strOracleHome As String = ""
    Public strTNSNAMESORAFilePath As String = ""
    Dim gPathgeral As String = ""

    Public Function LoadTNSNames(ByVal TNSNAMES As String) As ArrayList
        Dim sTNSNames As String = TNSNAMES
        Dim sDir As String = ""
        Dim s_TnsNames As String = ""
        Dim DBNamesCollection As New ArrayList
        Dim RegExPattern As String = "[\n][\s]*[^\(][a-zA-Z0-9_.]+[\s]*=[\s]*\("

10:
        ''Verifica existência do TNSNAMES"
        'If (System.IO.File.Exists(sTNSNames) <> True) Then
        '    Throw (New System.IO.FileNotFoundException("TNSNAMES não está nesse dir: " + sDir + ""))
        '    MessageBox.Show("TNSNAMES não está nesse dir: " + sDir + "")
        '    Exit Function
        'End If

20:
        'Adicionando una línea en blanco a la collection
        DBNamesCollection.Add("")
        If Not sTNSNames = "" Then
            Try
30:
                '//check out that file does physically exists
                Dim fiTNS As New System.IO.FileInfo(sTNSNames)
                If (fiTNS.Exists) Then
                    If (fiTNS.Length > 0) Then
                        '//read tnsnames.ora file
                        Dim iCount As Integer
40:
                        Try
                            For iCount = 0 To Regex.Matches(My.Computer.FileSystem.ReadAllText(fiTNS.FullName), RegExPattern).Count - 1
                                ' s_TnsNames = fRetiraCaracter(Regex.Matches(My.Computer.FileSystem.ReadAllText(fiTNS.FullName), RegExPattern).Item(iCount).Value.Trim.Substring(0, Regex.Matches(My.Computer.FileSystem.ReadAllText(fiTNS.FullName), RegExPattern).Item(iCount).Value.Trim.IndexOf(" "))).Trim

                                s_TnsNames = fRetiraCaracter(Regex.Matches(My.Computer.FileSystem.ReadAllText(fiTNS.FullName), RegExPattern).Item(iCount).Value.Trim)

                                If s_TnsNames <> "" Then
                                    DBNamesCollection.Add(s_TnsNames)
                                End If
                            Next
                        Catch ex As Exception
                            Throw New Exception(ex.Message)
                        End Try
                    End If
                End If
            Catch ex As Exception
                cLogErro.criaLog("[cTNSNamesReader].[LoadTNSNames][Bloco " & Erl() & "].[" & ex.Message & "]")

            End Try
        End If
        DBNamesCollection.Sort()
        Return DBNamesCollection
    End Function


    Private Function fRetiraCaracter(ByVal sTnsNames As String) As String
        Dim iTam As Integer = sTnsNames.Length
        Dim sTnsNameLimpo As String = ""
        Dim sTnsNameLimpo2 As String = ""
        Dim sTnsNameLimpo3 As String = ""
        Dim sCaracter As String = ""

        Dim i As Integer = 0
        For i = 0 To iTam - 1
            sCaracter = sTnsNames.Substring(i, 1).Trim
            If sCaracter Like "[A-Za-z0-9_.,]" Then
                sTnsNameLimpo = sTnsNameLimpo + sCaracter
            End If
        Next

        sTnsNameLimpo2 = sTnsNameLimpo.Replace("WORLD", "").Replace(".", "").Replace("world", "")


        Return sTnsNameLimpo2
    End Function


End Class

Public Class FileControlLoader

    Private sTam As Object
    Private sPrec As Object
    Private sMontaValorDefault As String
    Private sInt As Integer
    Private sMontaMaskNumber As Object
    Private sCampo3 As String
    Public Property SArqControl As String
    Public Property SNomeArqs As String
    Public Property SCampo1 As String
    Public Property SCampo2 As Object

    Public Function CreateFileControlLoaderPOSITION(sNroErro As Integer, checkedItems As Object, txtInfile As String, cmbDataBase As String, cmbIntoTable As String, drc As Object) As String
        Dim sConta As Integer = 1
        Dim slinhaPOS As String = "(" & vbCrLf

        SArqControl = "OPTIONS (ERRORS=" & sNroErro & ", SILENT=(FEEDBACK))" & vbCrLf
        SArqControl &= "LOAD DATA" & vbCrLf

        For Each itemChecked In checkedItems
            SNomeArqs = SNomeArqs & "INFILE '" & txtInfile & itemChecked.ToString().Trim & "'" & vbCrLf
        Next

        SArqControl &= SNomeArqs
        SArqControl += "BADFILE '" & "C:\SQLLOADER\bad_file_" & cmbDataBase & ".bad'" & vbCrLf
        SArqControl += SArqControl & "DISCARDFILE '" & "C:\SQLLOADER\descarte_file_" & cmbDataBase & ".dsc'" & vbCrLf
        SArqControl += "APPEND" & vbCrLf
        SArqControl += "PRESERVE BLANKS" & vbCrLf
        SArqControl += "INTO TABLE " & cmbIntoTable & vbCrLf
        SArqControl += "TRAILING NULLCOLS" & vbCrLf


        For i As Integer = 0 To drc.Count - 1
            SCampo1 = drc(i).Cells(0).Value
            SCampo2 = drc(i).Cells(1).Value
            Try
                sTam = drc(i).Cells(2).Value
            Catch ex As Exception
                sTam = 0
            End Try
            Try
                sPrec = drc(i).Cells(3).Value
            Catch ex As Exception
                sPrec = 0
            End Try
70:

            If SCampo2.ToUpper = "VARCHAR2" Then
                SCampo2 = "CHAR" & " " & sMontaValorDefault
            ElseIf SCampo2.ToUpper = "NUMBER" Then
                If sPrec.Trim = "" Then sPrec = "0"
                sInt = CInt(sTam) - CInt(sPrec)
                sMontaMaskNumber = " ""TO_CHAR(:" & SCampo1 & "," & FMontaMascara(sInt, CInt(sPrec)) & ")"""
                SCampo2 = "CHAR" & sMontaMaskNumber & " " & sMontaValorDefault
            End If

            If SCampo2 = "DATE" Then
                sCampo3 = "8"
            Else
                sCampo3 = drc(i).Cells(2).Value
            End If

            slinhaPOS = slinhaPOS & SCampo1 & " POSITION (" & sConta.ToString & ":" & (sCampo3 + sConta) - 1 & ") " & SCampo2.ToString & "," & vbCrLf
            sConta += CInt(sCampo3)
            sMontaValorDefault = ""
        Next
80:
        slinhaPOS = slinhaPOS.Trim
        slinhaPOS = slinhaPOS.Substring(0, slinhaPOS.Length - 1) & vbCrLf
        slinhaPOS &= ")"

        SArqControl &= slinhaPOS

        Return SArqControl

    End Function

    Public Function CreateFileControlLoaderFieldsTerminated(sNroErro As Integer, checkedItems As Object, txtInfile As String, cmbDataBase As String, cmbIntoTable As String, drc As Object) As String
        Dim sConta As Integer = 1
        Dim slinhaPOS As String = "(" & vbCrLf

        SArqControl = "OPTIONS (ERRORS=" & sNroErro & ", SILENT=(FEEDBACK))" & vbCrLf
        SArqControl &= "LOAD DATA" & vbCrLf

        For Each itemChecked In checkedItems
            SNomeArqs = SNomeArqs & "INFILE '" & txtInfile & itemChecked.ToString().Trim & "'" & vbCrLf
        Next

        SArqControl &= SNomeArqs
        SArqControl += "BADFILE '" & "C:\SQLLOADER\bad_file_" & cmbDataBase & ".bad'" & vbCrLf
        SArqControl += SArqControl & "DISCARDFILE '" & "C:\SQLLOADER\descarte_file_" & cmbDataBase & ".dsc'" & vbCrLf
        SArqControl += "APPEND" & vbCrLf
        SArqControl += "PRESERVE BLANKS" & vbCrLf
        SArqControl += "INTO TABLE " & cmbIntoTable & vbCrLf
        SArqControl += "TRAILING NULLCOLS" & vbCrLf


        For i As Integer = 0 To drc.Count - 1
            SCampo1 = drc(i).Cells(0).Value
            SCampo2 = drc(i).Cells(1).Value
            Try
                sTam = drc(i).Cells(2).Value
            Catch ex As Exception
                sTam = 0
            End Try
            Try
                sPrec = drc(i).Cells(3).Value
            Catch ex As Exception
                sPrec = 0
            End Try
70:

            If SCampo2.ToUpper = "VARCHAR2" Then
                SCampo2 = "CHAR" & " " & sMontaValorDefault
            ElseIf SCampo2.ToUpper = "NUMBER" Then
                If sPrec.Trim = "" Then sPrec = "0"
                sInt = CInt(sTam) - CInt(sPrec)
                sMontaMaskNumber = " ""TO_CHAR(:" & SCampo1 & "," & FMontaMascara(sInt, CInt(sPrec)) & ")"""
                SCampo2 = "CHAR" & sMontaMaskNumber & " " & sMontaValorDefault
            End If

            If SCampo2 = "DATE" Then
                sCampo3 = "8"
            Else
                sCampo3 = drc(i).Cells(2).Value
            End If

            slinhaPOS = slinhaPOS & SCampo1 & " POSITION (" & sConta.ToString & ":" & (sCampo3 + sConta) - 1 & ") " & SCampo2.ToString & "," & vbCrLf
            sConta += CInt(sCampo3)
            sMontaValorDefault = ""
        Next
80:
        slinhaPOS = slinhaPOS.Trim
        slinhaPOS = slinhaPOS.Substring(0, slinhaPOS.Length - 1) & vbCrLf
        slinhaPOS &= ")"

        SArqControl &= slinhaPOS

        Return SArqControl

    End Function


    Public Function FMontaMascara(ByVal iNroInt As Integer, ByVal iNroPrec As Integer) As String
        Dim i As Integer
        Dim sStrInt As String = ""
        Dim sStrPrec As String = ""
        For i = 1 To iNroInt
            sStrInt &= "9"
        Next
        If iNroPrec <> 0 Then
            For i = 1 To iNroPrec
                sStrPrec &= "9"
            Next
        End If

        If iNroPrec <> 0 Then
            FMontaMascara = "'" & sStrInt & "," & sStrPrec & "'"
        Else
            FMontaMascara = "'" & sStrInt & "'"
        End If
    End Function
End Class

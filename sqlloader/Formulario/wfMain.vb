Imports System.Data.OleDb
Imports System.IO
Imports System.Threading
Imports SQLLOADER.FileControl

Public Class wfMain
    ReadOnly sFuncao As New CFuncoes
    Dim sVBanco As String
    Dim sTable As String
    Private sSelect As String

    Private sUser As String
    Private sPwd As String
    Dim dtSource As DataTable

    Private Sub BtnInfile_Click(sender As Object, e As EventArgs) Handles btnInfile.Click
        Try
10:
            'Define as propriedades do controle FolderBrowserDialog
            fbdDiretorio.Description = "Selecione a pasta de arquivos"
            fbdDiretorio.RootFolder = Environment.SpecialFolder.MyComputer
            fbdDiretorio.ShowNewFolderButton = False
20:
            'Exibe a caixa de diálogo
            If fbdDiretorio.ShowDialog = Windows.Forms.DialogResult.OK Then

                'Exibe a pasta selecionada
                txtInfile.Text = fbdDiretorio.SelectedPath

            End If

30:
            Dim sDir As Directory = Nothing
            Dim sValor As ArrayList = New ArrayList()
            Dim sArqs() As String = Directory.GetFiles(Me.txtInfile.Text, "*")
            Dim i As Integer
40:
            For i = 0 To sArqs.Length - 1 Step i + 1
                Dim sNomeArq As String = sArqs(i)

                sNomeArq = sNomeArq.Replace(Me.txtInfile.Text, "")
                sValor.Add(sNomeArq)
            Next
            clbArquivos.DataSource = sValor


        Catch ex As Exception
            cLogErro.apagaLog()
            cLogErro.criaLog("[CargaArquivos.vb].[btnDir_Click][Bloco " & Erl() & "].[" & ex.Message & "]")


        End Try
    End Sub

    Private Sub CheckBoxAll_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAll.CheckedChanged
10:
        '  Dim Filtro As String = Trim(txtFiltro.Text)

        Try
            Dim j As Integer = 0


            If CheckBoxAll.Checked Then
20:
                ' If Me.txtFiltro.Text.Trim <> "" Then
                For j = 0 To clbArquivos.Items.Count - 1
                    'If (CheckedListArquivos.Items(j).ToString.ToUpper Like "*" & Me.txtFiltro.Text.ToUpper & "*") Then
                    clbArquivos.SetItemChecked(j, True)
                    'End If
                Next
                ' Else
30:
                For j = 0 To clbArquivos.Items.Count - 1
                    clbArquivos.SetItemChecked(j, True)
                Next
                ' End If
            Else
40:
                For j = 0 To clbArquivos.Items.Count - 1
                    clbArquivos.SetItemChecked(j, False)
                Next
            End If

        Catch ex As Exception
            cLogErro.apagaLog()
            cLogErro.criaLog("[CargaArquivos.vb].[cbTodos_CheckedChanged][Bloco " & Erl() & "].[" & ex.Message & "]")
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")

        End Try

    End Sub

    Private Sub WfMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '------------------>>>>Verifica se a aplicação já esta aberta <<<<-----------------------------
        Dim objMutex As Mutex

        objMutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")

        If objMutex.WaitOne(0, False) = False Then

            objMutex.Close()


            MessageBox.Show("Já existe uma instancia rodando desta aplicaçao.", ":: Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
            Exit Sub

        End If

        '------------------------------------------------------------ > 


        rdFieldsTerminated.Checked = True


        Me.txtError.Text = "100"
        Me.txtDelimitador.Text = "|"
        Me.txtRows.Text = "50000"

10:
        cLogErro.apagaLog()


        sUser = Me.txtUser.Text.Trim
        sPwd = Me.txtPassword.Text.Trim

        '----Cria dir padrão se não existir----'
        Dim sDir As String = "C:\SQLLOADER"
        Dim sPath As String = "C:\SQLLOADER\tns.ini"
        Dim sPath2 As String = "C:\SQLLOADER\User.ini" 'Grava o Ultimo usuario que conectou na ferramenta

        Dim sFluxoTexto As IO.StreamReader
        Dim sLinhaTexto As String




20:
        Try
            If Not Directory.Exists(sDir) Then
                Directory.CreateDirectory(sDir)
            End If

30:

            If IO.File.Exists(sPath) Then

                sFluxoTexto = New IO.StreamReader(sPath)
                sLinhaTexto = sFluxoTexto.ReadLine
                Me.txtTnsNames.Text = sLinhaTexto
                sFluxoTexto.Close()

                '----carrega a combo Banco----'
                Dim sCaminhoTNS = txtTnsNames.Text
                Dim TNSNamesReader As New CTNSNamesReader()
                Me.cmbDataBase.DataSource = TNSNamesReader.LoadTNSNames(sCaminhoTNS)

            End If


            'Grava Usuario 
            If IO.File.Exists(sPath2) Then

                sFluxoTexto = New IO.StreamReader(sPath2)
                sLinhaTexto = sFluxoTexto.ReadLine
                Me.txtUser.Text = sLinhaTexto
                sFluxoTexto.Close()


            End If



40:
            '----Inicia DataGrid----'
            sFuncao.IniciaDataGrid(Me.DataGridTabela)

        Catch ex As Exception
            cLogErro.apagaLog()
            cLogErro.criaLog("[CargaArquivos].[CargaArquivos_Load][Bloco " & Erl() & "].[" & ex.Message & "]")

            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")

        End Try




    End Sub

    Private Sub BtnTnsNames_Click(sender As Object, e As EventArgs) Handles btnTnsNames.Click
10:
        '------Limpa DataGrid------'
        DataGridTabela.DataSource = Nothing

        Dim oSeleciona As New OpenFileDialog
        Try

            With oSeleciona
                .InitialDirectory = "C:\"
                .Title = "Procurar tnsnames"
                .Filter = "Arquivos Texto|*.ora"
                .ShowDialog()
                txtTnsNames.Text = .FileName()
            End With
20:
            '----carrega a combo Banco----'
            Dim sCaminhoTNS = txtTnsNames.Text
            Dim TNSNamesReader As New CTNSNamesReader()
            Me.cmbDataBase.DataSource = TNSNamesReader.LoadTNSNames(sCaminhoTNS)

        Catch ex As Exception
            cLogErro.apagaLog()
            cLogErro.criaLog("[CargaArquivos.vb].[btnTnsNames_Click][Bloco " & Erl() & "].[" & ex.Message & "]")
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")

        End Try
    End Sub

    Private Sub CmbDataBase_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDataBase.SelectedValueChanged
10:
        Dim sRetornoErro As String = ""
        sUser = Me.txtUser.Text.Trim.ToUpper
        sPwd = Me.txtPassword.Text.Trim
        Try


20:
            '----carrega combo Tables-----'
            sVBanco = Me.cmbDataBase.SelectedValue

            If sVBanco = "" Or sPwd = "" Then
                Exit Sub
            End If
30:
            sSelect = "SELECT table_name FROM all_all_tables where owner = '" + sUser + "' order by 1"
            cmbIntoTable.Items.Clear()
            Call sFuncao.CarregaCombo(Me.cmbIntoTable, sSelect, sVBanco, sRetornoErro, sUser, sPwd)
40:
            If Me.cmbIntoTable.Text <> "" And sRetornoErro = "" Then

            Else
                MsgBox("Erro" + sSelect, MsgBoxStyle.Exclamation, ":: Aviso")
            End If

        Catch ex As Exception
            cLogErro.apagaLog()
            cLogErro.criaLog("[CargaArquivos.vb].[cmbDataBase_SelectedValueChanged][Bloco " & Erl() & "].[" & ex.Message & "]")
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")

        Finally

        End Try
    End Sub

    Private Sub WfMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Dim sPath As String = "C:\SQLLOADER\tns.ini"
        Dim sPath2 As String = "C:\SQLLOADER\User.ini"
        Dim sArquivo As System.IO.FileStream
        Dim sFluxoTexto As IO.StreamWriter



10:     Try

            If IO.File.Exists(sPath2) Then

                File.Delete(sPath2)

            End If


            If IO.File.Exists(sPath) Then

                File.Delete(sPath)

            End If
20:
            sArquivo = File.Create(sPath)
            sFluxoTexto = New IO.StreamWriter(sArquivo)
            sFluxoTexto.WriteLine(Me.txtTnsNames.Text)
            sFluxoTexto.Close()

            '==================================================== Grava o Usuario 
            sArquivo = File.Create(sPath2)
            sFluxoTexto = New IO.StreamWriter(sArquivo)
            sFluxoTexto.WriteLine(Me.txtUser.Text)
            sFluxoTexto.Close()


        Catch ex As Exception
            cLogErro.apagaLog()
            cLogErro.criaLog("[wfMain].[wfMain_FormClosed][Bloco " & Erl() & "].[" & ex.Message & "]")
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")

        End Try

    End Sub


    Private Sub BtnCarrega_Click(sender As Object, e As EventArgs) Handles btnCarrega.Click


        If Me.txtUser.Text = "" Then
            MsgBox("ORA-01017:senha/nome do usuário inválido; logon negado", MsgBoxStyle.Information, ":: Aviso")
            Me.txtUser.Focus()


        ElseIf Me.txtPassword.Text = "" Then
            MsgBox("ORA-01005: senha nula fornecida;logon negado", MsgBoxStyle.Information, ":: Aviso")
            Me.txtPassword.Focus()

        ElseIf Me.cmbDataBase.Text.Trim = Nothing Then
            MsgBox("Informe a Data Base!", MsgBoxStyle.Information, ":: Aviso")
            Me.cmbDataBase.Focus()

        ElseIf Me.cmbIntoTable.Text = Nothing Then
            MsgBox("Informe a Tabela", MsgBoxStyle.Information, ":: Aviso")
            Me.cmbIntoTable.Focus()

        ElseIf Me.txtDelimitador.Text = "" Then
            MsgBox("Informe o Delimitador!", MsgBoxStyle.Information, ":: Aviso")
            Me.txtDelimitador.Focus()

        ElseIf Me.txtInfile.Text = "" Then
            MsgBox("Informe o Arquivo a ser carregado!", MsgBoxStyle.Information, ":: Aviso")
            Me.txtInfile.Focus()

        Else

            '----apaga Bad_file se não existir----'
            Dim sDir As String = "C:\SQLLOADER\bad_file_" & Me.cmbDataBase.SelectedValue & ".bad"
            If File.Exists(sDir) Then
                File.Delete(sDir)
            End If

            Dim drc As DataGridViewRowCollection = DataGridTabela.Rows
            Dim DefaultContrlFile As String = "C:\SQLLOADER\control_" & Me.cmbIntoTable.SelectedValue & ".ctl"
            Dim DefaultContrlFileBAT As String = "C:\SQLLOADER\control_" & Me.cmbIntoTable.SelectedValue & ".bat"
            Dim sNomeArqs As String = ""
            Dim sArqControl As String = String.Empty
            Dim sNroErro As String = Me.txtError.Text.Trim
            Dim sCampo1 As String
            Dim sCampo2 As String
            Dim sCampo3 As String
            Dim sRowsCommit As String = Me.txtRows.Text.Trim
            Dim sLayout As String
20:

            Dim checkedItems As CheckedListBox.CheckedItemCollection = clbArquivos.CheckedItems

            Try
                Dim sArqControlBat As String
                If rbPOSITION.Checked = True Then

                    Dim drcCount As Object = drc

                    Dim arqControlLoader As New FileControlLoader
                    sArqControl = arqControlLoader.CreateFileControlLoaderPOSITION(sNroErro,
                                                                                  checkedItems,
                                                                                  Me.txtInfile.Text,
                                                                                  Me.cmbDataBase.SelectedValue,
                                                                                  Me.cmbIntoTable.SelectedValue,
                                                                                  drcCount)
                    Dim objLogFile As StreamWriter
                    Dim objLogFileBat As StreamWriter

                    If Directory.Exists(Path.GetDirectoryName(DefaultContrlFile)) Then
                        objLogFile = File.CreateText(DefaultContrlFile)
                    Else
                        objLogFile = File.AppendText(DefaultContrlFile)
                    End If

                    objLogFile.WriteLine(sArqControl)
                    objLogFile.Flush()
                    objLogFile.Close()
100:

                    Dim createArqControlBat As New FileControlBat
                    sArqControlBat = createArqControlBat.CreateFileControlBat(sUser,
                                                                             Me.cmbDataBase.SelectedValue,
                                                                             sPwd,
                                                                             DefaultContrlFile,
                                                                             "C:\SQLLOADER\control_" & Me.cmbIntoTable.SelectedValue,
                                                                             sRowsCommit)

                    If Directory.Exists(Path.GetDirectoryName(DefaultContrlFileBAT)) Then
                        objLogFileBat = File.CreateText(DefaultContrlFileBAT)
                    Else
                        objLogFileBat = File.AppendText(DefaultContrlFileBAT)
                    End If

                    objLogFileBat.WriteLine(sArqControlBat)
                    objLogFileBat.Flush()
                    objLogFileBat.Close()
110:
                    Process.Start(DefaultContrlFileBAT)



                ElseIf rdFieldsTerminated.Checked = True Then

                    For Each itemChecked In clbArquivos.CheckedItems
                        sNomeArqs = sNomeArqs & "INFILE '" & Me.txtInfile.Text & itemChecked.ToString().Trim & "'" & vbCrLf
                    Next
120:
                    sArqControl &= sNomeArqs
                    sArqControl = sArqControl & "BADFILE '" & "C:\SQLLOADER\bad_file_" & cmbDataBase.SelectedValue & ".bad'" & vbCrLf
                    sArqControl = sArqControl & "DISCARDFILE '" & "C:\SQLLOADER\descarte_file_" & cmbDataBase.SelectedValue & ".dsc'" & vbCrLf
                    sArqControl = sArqControl & "APPEND INTO TABLE " & cmbIntoTable.SelectedValue & vbCrLf
                    sArqControl = sArqControl & "FIELDS TERMINATED BY '" & txtDelimitador.Text.Trim & "'" & vbCrLf
                    sArqControl = sArqControl & "OPTIONALLY ENCLOSED BY '" & """'" & vbCrLf
                    sArqControl = sArqControl & "TRAILING NULLCOLS" & vbCrLf

130:
                    Dim sSoma As Integer = 0

                    sLayout = "("
                    For i As Integer = 0 To drc.Count - 1
                        sCampo1 = drc(i).Cells(0).Value
                        sCampo2 = drc(i).Cells(1).Value
                        If sCampo2.ToUpper <> "DATE" Then
                            Try
                                sCampo3 = drc(i).Cells(2).Value
                            Catch ex As Exception
                                sCampo3 = "28"
                            End Try
                        Else
                            sCampo3 = ""
                        End If
                        If sCampo2.ToUpper = "VARCHAR2" Then
                            sCampo2 = "CHAR(" & sCampo3 & ")"
                        ElseIf (sCampo2.ToUpper) = "NUMBER" Then
                            sCampo2 = "CHAR(" & sCampo3 & ")"
                        End If

                        sLayout = sLayout & sCampo1 & " " & sCampo2 & "," & vbCrLf
                    Next
140:
                    sLayout = sLayout.Substring(0, sLayout.Trim.Length - 1)
                    sLayout = sLayout & ")" & vbCrLf
                    sArqControl &= sLayout

150:
                    Dim objLogFile As StreamWriter
                    Dim objLogFileBat As StreamWriter

                    If Directory.Exists(Path.GetDirectoryName(DefaultContrlFile)) Then
                        objLogFile = File.CreateText(DefaultContrlFile)
                    Else
                        objLogFile = File.AppendText(DefaultContrlFile)
                    End If

                    objLogFile.WriteLine(sArqControl)
                    objLogFile.Flush()
                    objLogFile.Close()
160:

                    Dim createArqControlBat As New FileControlBat
                    sArqControlBat = createArqControlBat.CreateFileControlBat(sUser,
                                                                             Me.cmbDataBase.SelectedValue,
                                                                             sPwd,
                                                                             DefaultContrlFile,
                                                                             "C:\SQLLOADER\control_" & Me.cmbIntoTable.SelectedValue,
                                                                             sRowsCommit)

                    If Directory.Exists(Path.GetDirectoryName(DefaultContrlFileBAT)) Then
                        objLogFileBat = File.CreateText(DefaultContrlFileBAT)
                    Else
                        objLogFileBat = File.AppendText(DefaultContrlFileBAT)
                    End If

                    objLogFileBat.WriteLine(sArqControlBat)
                    objLogFileBat.Flush()
                    objLogFileBat.Close()
170:
                    Process.Start(DefaultContrlFileBAT)

                End If


            Catch ex As Exception
                cLogErro.apagaLog()
                cLogErro.criaLog("[CargaArquivos].[btnCargaArquivo_Click][Bloco " & Erl() & "].[" & ex.Message & "]")
                MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")

            Finally

            End Try



        End If

    End Sub

    Private Sub ExibeDados(ByVal selectCommand As String, ByVal sBanco As String)

10:
        Dim strConn As String = "Provider=OraOLEDB.Oracle;Data Source=" + sBanco + ";User ID=" + sUser + ";Password=" + sPwd
        Dim cnn As New OleDbConnection(strConn)
        Dim cmd As OleDbCommand

        cnn.Open()
        cmd = New OleDbCommand(selectCommand, cnn)

        Dim da As New OleDbDataAdapter(cmd)
        Dim commandBuilder As New OleDbCommandBuilder(da)

        ' Preenche um novo data table e vincula ao BindingSource.
        Dim table As New DataTable()
20:
        Try
            table.Locale = Globalization.CultureInfo.InvariantCulture
            da.Fill(table)
            bsCargaTables.DataSource = table

            '-------apaga conteudo da table nova--------'
            dtSource = Nothing

            '-------transfere source do bs para a table dtsource, para que possa ser manipulado as rows no dtgv------'
            '-------as rows só podem ser manipuladas se se o dtgv estiver descon do banco-------'
            dtSource = bsCargaTables.DataSource
            DataGridTabela.DataSource = dtSource

            '-------Fecha conexão-------'
            cnn.Close()

        Catch ex As OleDbException
            cLogErro.apagaLog()
            cLogErro.criaLog("[CargaArquivos].[exibeDados][Bloco " & Erl() & "].[" & ex.Message & "]")
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")

        Finally


        End Try

    End Sub


    Private Sub LogDeErroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogDeErroToolStripMenuItem.Click

        Dim DefaultLogFile As String = "C:\SQLLOADER\logerro.txt"

        Try
            Shell("notepad.exe " + DefaultLogFile, AppWinStyle.MaximizedFocus)

        Catch ex As Exception

            MsgBox("Log não encontrado!", MsgBoxStyle.Exclamation, ":: Aviso")
            Exit Sub

        End Try

    End Sub


    Private Sub CmbIntoTable_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbIntoTable.SelectedValueChanged

10:

        Try
20:
            sTable = Me.cmbIntoTable.SelectedValue.ToString
            If sTable = "" Then
                Exit Sub
            End If
30:
            Dim sSql As String = "SELECT COLUNAS.COLUMN_NAME AS COLUNA," &
            "COLUNAS.DATA_TYPE AS TIPO," &
            "DECODE(COLUNAS.DATA_PRECISION, NULL, COLUNAS.CHAR_COL_DECL_LENGTH, COLUNAS.DATA_PRECISION)  AS TAMANHO," &
            "COLUNAS.DATA_SCALE as PRECISAO," &
            "COLUNAS.NULLABLE AS EH_NULO" &
    " FROM USER_TABLES TABELAS, USER_TAB_COLUMNS COLUNAS" &
    " WHERE TABELAS.TABLE_NAME = COLUNAS.TABLE_NAME" &
    " AND TABELAS.TABLE_NAME = '" & sTable & "' order by COLUNAS.column_id"

40:
            ExibeDados(sSql, cmbDataBase.SelectedValue.ToString)

        Catch ex As Exception
            If Not ex.Message = "A conversão do tipo 'DataRowView' no tipo 'String' não é válida." Then
                cLogErro.apagaLog()
                cLogErro.criaLog("[CargaArquivos.vb].[cmbIntoTable_SelectedValueChanged][Bloco " & Erl() & "].[" & ex.Message & "]")
                MsgBox(ex.ToString, MsgBoxStyle.Exclamation, ":: Aviso")
            End If
        End Try


    End Sub

    Private Sub RbPOSITION_CheckedChanged(sender As Object, e As EventArgs) Handles rbPOSITION.CheckedChanged

        If rbPOSITION.Checked = True Then
            txtDelimitador.Enabled = False


        End If

    End Sub

    Private Sub RdFieldsTerminated_CheckedChanged(sender As Object, e As EventArgs) Handles rdFieldsTerminated.CheckedChanged

        If rdFieldsTerminated.Checked = True Then
            txtDelimitador.Enabled = True
        End If

    End Sub
End Class

Imports System.Data
Imports System.Data.OleDb

Public Class cFuncoes
    Public Sub CarregaCombo(ByVal cbo As ComboBox, ByVal strsql As String, ByVal sBanco As String, ByRef sRet As String, sUser As String, sPwd As String)

10:

        sRet = ""
        Dim strConn As String = "Provider=OraOLEDB.Oracle;Data Source=" + sBanco + ";User ID=" + sUser + ";Password=" + sPwd
        Dim cnn As New OleDbConnection(strConn)
        Dim cmd As OleDbCommand
        Dim dt As New DataTable

        Cursor.Current = Cursors.WaitCursor

        Try
20:
            cnn.Open()
            cmd = New OleDbCommand(strsql, cnn)
            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(dt)
30:
            With cbo
                .DataSource = Nothing  'para limpar se for recarregada                
                .DataSource = dt
                .ValueMember = dt.Columns(0).ToString
                .DisplayMember = dt.Columns(0).ToString
            End With

40:
            da = Nothing
            cnn.Close()

        Catch ex As OleDbException
            If ex.Message = "ORA-12541: TNS:não há listener" Then
                MessageBox.Show("Banco inválido!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error)

                cbo.DataSource = Nothing
                cbo.Items.Clear()
                wfMain.DataGridTabela.DataSource = Nothing
            Else
                cLogErro.criaLog("[cFuncoes].[CarregaCombo][Bloco " & Erl() & "].[" & ex.Message & "]")

                sRet = ex.Message
            End If

        Finally

            '---------Apagando objeto da memoria---------'
            dt = Nothing
            cnn = Nothing
            cmd = Nothing

        End Try

    End Sub

    Public Sub IniciaDataGrid(ByVal sNomeDataGrid As System.Windows.Forms.DataGridView)

10:
        Try

            With sNomeDataGrid
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .CellBorderStyle = DataGridViewCellBorderStyle.Single
                .BorderStyle = BorderStyle.Fixed3D
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = True
                .ReadOnly = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
                .AllowUserToResizeColumns = False
                .ColumnHeadersHeightSizeMode = _
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .AllowUserToResizeRows = False
                .RowHeadersWidthSizeMode = _
                DataGridViewRowHeadersWidthSizeMode.DisableResizing
                .DefaultCellStyle.SelectionBackColor = Color.Blue
                .DefaultCellStyle.SelectionForeColor = Color.White
                .RowHeadersDefaultCellStyle.SelectionBackColor = Color.Blue
                '.RowsDefaultCellStyle.BackColor = Color.LightGray
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                '.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray
                '.RowHeadersDefaultCellStyle.BackColor = Color.Gray
                .DefaultCellStyle.Font = New Font(sNomeDataGrid.DefaultCellStyle.Font.FontFamily, 10)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            End With

        Catch ex As Exception
            cLogErro.criaLog("[cFuncoes].[IniciaDataGrid][Bloco " & Erl() & "].[" & ex.Message & "]")


        Finally

        End Try


    End Sub
End Class

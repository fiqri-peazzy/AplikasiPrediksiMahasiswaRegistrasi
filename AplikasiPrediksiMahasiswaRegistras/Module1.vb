Imports System.Data.Odbc
Imports System.Text
Imports System.Security.Cryptography
Module Module1
    Public cn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public rd As OdbcDataReader
    Public rd2 As OdbcDataReader
    Public cmd As OdbcCommand
    Public nJmUser As Integer
    Public cLevelUser, cUserld, mPath, cNamaUser, cld_Dataset, cKode_prodi, cid_periode As String
    Public tblEdit, Valid As Boolean

    Public Sub koneksi()
        mPath = Application.StartupPath & "\"
        Try
            cn = New OdbcConnection("dsn=dsn_mhs_regis;MultipleActiveResultSets=True")
            If cn.State = ConnectionState.Closed Then
                cn.Open()

            End If
        Catch ex As Exception
            MsgBox("Koneksi Database Gagagal", vbExclamation, "koneksi Gagal")
        End Try
    End Sub

    Public Sub hitungData()
        cmd = New OdbcCommand("select count(*) as jml from tb_user", cn)
        rd = cmd.ExecuteReader
        rd.Read()
        nJmUser = rd.Item(0)

    End Sub

    Public Function StripNonAlphaNum(ByRef sText As String) As String
        Dim strRegex As String = "[^a-zA-Z0-9-]"
        Dim rgx As New System.Text.RegularExpressions.Regex(strRegex)
        Return rgx.Replace(sText, "")
    End Function

    Public Function SHA256(ByVal Content As String) As String
        Dim MoleCul3 As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MoleCul3.ComputeHash(ByteString)

        Dim Finalstring As String = Nothing
        For Each bt As Byte In ByteString
            Finalstring &= bt.ToString("x2")

        Next
        Return Finalstring
    End Function
End Module

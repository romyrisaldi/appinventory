Imports System.Data
Imports System.Data.SqlClient
Public Class formbarang
    Public koneksi As String
    Public sql1, sql2 As String
    Public conn As SqlClient.SqlConnection = Nothing
    Public cmd As SqlClient.SqlCommand = Nothing
    Public dtadapter As New SqlClient.SqlDataAdapter
    Public dttable As New DataTable
    Public listdata As String


    '@author : Romy Aziz Risaldi'
    'Note : Jangan Asal Copas Woyy Modif dikit dong'

    Private Sub formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PERINTAH KONEKSI DATABASE DISIMPAN 1 BARIS
        koneksi = "Data Source= localhost\sqlexpress;Initial Catalog=Barang;Integrated Security=True"
        conn = New SqlClient.SqlConnection(Koneksi)
        conn.Open()
        daftar()
    End Sub
    Sub bersih()
        Me.txtkode_barang.Focus()
        Me.txtkode_barang.Text = ""
        Me.txtnama_barang.Text = ""
        Me.cbjenis_barang.Text = ""
        Me.txtstock_barang.Text = ""
        Me.txtharga_barang.Text = ""
    End Sub

    Sub simpan()
        'PERINTAH sql1 DISIMPAN 1 BARIS
        sql1 = "Insert into DataBarang values('" &
        Me.txtkode_barang.Text & "','" & Me.txtnama_barang.Text & "','" &
        Me.cbjenis_barang.Text & "','" & Me.txtstock_barang.Text & "','" &
        Me.txtharga_barang.Text & "')"
        cmd = New SqlClient.SqlCommand(sql1)
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        simpan()
        daftar()
        bersih()
        MsgBox("Data Sudah Disimpan", MsgBoxStyle.Information,
        "Perhatian")
    End Sub

    Private Sub btcancel_Click(sender As Object, e As EventArgs) Handles btcancel.Click
        bersih()
        MsgBox("Data Sudah digagalkan", MsgBoxStyle.Information,
        "Perhatian")
    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        bersih()
        MsgBox("Data Baru", MsgBoxStyle.Information, "Perhatian")
    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Sub daftar()
        sql2 = "select * from DataBarang"
        dtadapter = New SqlDataAdapter(sql2, conn) 'dibuat satu baris
        Dim BRG As New DataTable
        BRG.Clear()
        dtadapter.Fill(BRG)
        dgvbarang.DataSource = BRG
    End Sub
End Class

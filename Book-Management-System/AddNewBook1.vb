Imports System.Data.SqlClient

Public Class frmAddNewBook
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ds As BMS1.DataSet1
    Friend WithEvents sda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents scon As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtPublication As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents txtBookname As System.Windows.Forms.TextBox
    Friend WithEvents txtBookid As System.Windows.Forms.TextBox
    Friend WithEvents txtPages As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ds = New BMS1.DataSet1()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.scon = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPublication = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookname = New System.Windows.Forms.TextBox()
        Me.txtBookid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ds
        '
        Me.ds.DataSetName = "DataSet1"
        Me.ds.Locale = New System.Globalization.CultureInfo("en-US")
        Me.ds.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(25, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Add New Book"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sda
        '
        Me.sda.DeleteCommand = Me.SqlDeleteCommand1
        Me.sda.InsertCommand = Me.SqlInsertCommand1
        Me.sda.SelectCommand = Me.SqlSelectCommand1
        Me.sda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblBookDetails1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("bookid", "bookid"), New System.Data.Common.DataColumnMapping("bookname", "bookname"), New System.Data.Common.DataColumnMapping("author", "author"), New System.Data.Common.DataColumnMapping("publication", "publication"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("tpages", "tpages"), New System.Data.Common.DataColumnMapping("groups", "groups")})})
        Me.sda.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM tblBookDetails1 WHERE (bookid = @Original_bookid) AND (author = @Orig" & _
        "inal_author OR @Original_author IS NULL AND author IS NULL) AND (bookname = @Ori" & _
        "ginal_bookname OR @Original_bookname IS NULL AND bookname IS NULL) AND (groups =" & _
        " @Original_groups OR @Original_groups IS NULL AND groups IS NULL) AND (price = @" & _
        "Original_price OR @Original_price IS NULL AND price IS NULL) AND (publication = " & _
        "@Original_publication OR @Original_publication IS NULL AND publication IS NULL) " & _
        "AND (tpages = @Original_tpages OR @Original_tpages IS NULL AND tpages IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.scon
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bookid", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookid", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_author", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bookname", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_groups", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "groups", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_publication", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "publication", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tpages", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpages", System.Data.DataRowVersion.Original, Nothing))
        '
        'scon
        '
        Me.scon.ConnectionString = "data source=reception;initial catalog=master;persist security info=False;user id=" & _
        "sa;pwd=aptech;workstation id=FORTUNE11;packet size=4096"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO tblBookDetails1(bookid, bookname, author, publication, price, tpages," & _
        " groups) VALUES (@bookid, @bookname, @author, @publication, @price, @tpages, @gr" & _
        "oups); SELECT bookid, bookname, author, publication, price, tpages, groups FROM " & _
        "tblBookDetails1 WHERE (bookid = @bookid)"
        Me.SqlInsertCommand1.Connection = Me.scon
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bookid", System.Data.SqlDbType.VarChar, 10, "bookid"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bookname", System.Data.SqlDbType.VarChar, 70, "bookname"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@author", System.Data.SqlDbType.VarChar, 70, "author"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@publication", System.Data.SqlDbType.VarChar, 70, "publication"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Int, 4, "price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tpages", System.Data.SqlDbType.Int, 4, "tpages"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@groups", System.Data.SqlDbType.VarChar, 70, "groups"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT bookid, bookname, author, publication, price, tpages, groups FROM tblBookD" & _
        "etails1"
        Me.SqlSelectCommand1.Connection = Me.scon
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE tblBookDetails1 SET bookid = @bookid, bookname = @bookname, author = @auth" & _
        "or, publication = @publication, price = @price, tpages = @tpages, groups = @grou" & _
        "ps WHERE (bookid = @Original_bookid) AND (author = @Original_author OR @Original" & _
        "_author IS NULL AND author IS NULL) AND (bookname = @Original_bookname OR @Origi" & _
        "nal_bookname IS NULL AND bookname IS NULL) AND (groups = @Original_groups OR @Or" & _
        "iginal_groups IS NULL AND groups IS NULL) AND (price = @Original_price OR @Origi" & _
        "nal_price IS NULL AND price IS NULL) AND (publication = @Original_publication OR" & _
        " @Original_publication IS NULL AND publication IS NULL) AND (tpages = @Original_" & _
        "tpages OR @Original_tpages IS NULL AND tpages IS NULL); SELECT bookid, bookname," & _
        " author, publication, price, tpages, groups FROM tblBookDetails1 WHERE (bookid =" & _
        " @bookid)"
        Me.SqlUpdateCommand1.Connection = Me.scon
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bookid", System.Data.SqlDbType.VarChar, 10, "bookid"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bookname", System.Data.SqlDbType.VarChar, 70, "bookname"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@author", System.Data.SqlDbType.VarChar, 70, "author"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@publication", System.Data.SqlDbType.VarChar, 70, "publication"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Int, 4, "price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tpages", System.Data.SqlDbType.Int, 4, "tpages"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@groups", System.Data.SqlDbType.VarChar, 70, "groups"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bookid", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookid", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_author", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "author", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bookname", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bookname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_groups", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "groups", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_publication", System.Data.SqlDbType.VarChar, 70, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "publication", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tpages", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tpages", System.Data.DataRowVersion.Original, Nothing))
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "&Quit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPages, Me.txtPrice, Me.Label6, Me.Label5, Me.txtGroup, Me.Label8, Me.txtPublication, Me.txtAuthor, Me.txtBookname, Me.txtBookid, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 272)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtPages
        '
        Me.txtPages.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tblBookDetails1.tpages"))
        Me.txtPages.Location = New System.Drawing.Point(248, 224)
        Me.txtPages.Name = "txtPages"
        Me.txtPages.Size = New System.Drawing.Size(64, 23)
        Me.txtPages.TabIndex = 35
        Me.txtPages.Text = ""
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tblBookDetails1.price"))
        Me.txtPrice.Location = New System.Drawing.Point(104, 224)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(64, 23)
        Me.txtPrice.TabIndex = 34
        Me.txtPrice.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Pages"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Price"
        '
        'txtGroup
        '
        Me.txtGroup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tblBookDetails1.groups"))
        Me.txtGroup.Location = New System.Drawing.Point(104, 184)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(208, 23)
        Me.txtGroup.TabIndex = 31
        Me.txtGroup.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Group"
        '
        'txtPublication
        '
        Me.txtPublication.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tblBookDetails1.publication"))
        Me.txtPublication.Location = New System.Drawing.Point(104, 144)
        Me.txtPublication.Name = "txtPublication"
        Me.txtPublication.Size = New System.Drawing.Size(208, 23)
        Me.txtPublication.TabIndex = 27
        Me.txtPublication.Text = ""
        '
        'txtAuthor
        '
        Me.txtAuthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tblBookDetails1.author"))
        Me.txtAuthor.Location = New System.Drawing.Point(104, 104)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(208, 23)
        Me.txtAuthor.TabIndex = 26
        Me.txtAuthor.Text = ""
        '
        'txtBookname
        '
        Me.txtBookname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tblBookDetails1.bookname"))
        Me.txtBookname.Location = New System.Drawing.Point(104, 64)
        Me.txtBookname.Name = "txtBookname"
        Me.txtBookname.Size = New System.Drawing.Size(208, 23)
        Me.txtBookname.TabIndex = 25
        Me.txtBookname.Text = ""
        '
        'txtBookid
        '
        Me.txtBookid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds, "tblBookDetails1.bookid"))
        Me.txtBookid.Location = New System.Drawing.Point(104, 24)
        Me.txtBookid.Name = "txtBookid"
        Me.txtBookid.Size = New System.Drawing.Size(64, 23)
        Me.txtBookid.TabIndex = 24
        Me.txtBookid.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Publication"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Book ID"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(176, 328)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(263, 328)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        '
        'frmAddNewBook
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(346, 363)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCancel, Me.btnSave, Me.GroupBox1, Me.Label7})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmAddNewBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Entry"
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cn As SqlConnection
    Dim adap As SqlDataAdapter
    Dim ds1 As DataSet

    Dim Id As Integer

    'Close application
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If IsNumeric(Me.txtPrice.Text) = True Then
            If IsNumeric(Me.txtPages.Text) = True Then
                'Putting data on the objects on database
                Dim dr As DataRow = ds1.Tables("tblbookdetails1").NewRow
                dr(0) = Me.txtBookid.Text
                dr(1) = Me.txtBookname.Text
                dr(2) = Me.txtAuthor.Text
                dr(3) = Me.txtPublication.Text

                Try
                    dr(4) = Double.Parse(Me.txtPrice.Text)
                    dr(5) = Integer.Parse(Me.txtPages.Text)
                Catch ee As System.FormatException

                End Try


                dr(6) = Me.txtGroup.Text
                ds1.Tables("tblbookdetails1").Rows.Add(dr)
                Dim cmdbld As New SqlCommandBuilder(adap)


                adap.Update(ds1, "tblbookdetails1")
                MessageBox.Show("Record Added Sucessfully", "Add New Book", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If MessageBox.Show("Do you want to add another Record", "Book Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    If MessageBox.Show("Do You want to Refresh Data", "Book Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        'flag = True
                        isRefresh = True
                    End If
                    Me.Close()
                Else
                    MakeClear()
                    Call AutoID()
                    Me.txtBookname.Focus()
                End If
            Else
                MsgBox("Your Price or Page value is not numeric")
            End If
        End If

    End Sub

    Sub MakeClear()
        Me.txtBookid.Clear()
        Me.txtBookname.Clear()
        Me.txtGroup.Clear()
        Me.txtPages.Clear()
        Me.txtPrice.Clear()
        Me.txtAuthor.Clear()
        Me.txtPublication.Clear()
    End Sub


    Private Sub frmAddNewBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Server=HOME-EMJKYXXGTL;uid=sa;pwd=aptech;database=master")
        cn.Open()
        adap = New SqlDataAdapter("Select * from tblbookdetails1", cn)
        ds1 = New DataSet()
        adap.Fill(ds1, "tblbookdetails1")
        Call AutoID()
    End Sub

    Sub AutoID()
        Dim i As Integer
        Id = ds1.Tables("tblbookdetails1").Rows.Count
        Me.txtBookid.Text = Id + 1
        Me.txtBookname.Focus()

    End Sub


    Private Sub txtPages_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPages.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(sender, e)
        End If

    End Sub
    Private Sub txtBookid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBookid.KeyUp
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Add Full Record", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtBookname_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBookname.KeyUp
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Add Full Record", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtAuthor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAuthor.KeyUp
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Add Full Record", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtPublication_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPublication.KeyUp
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Add Full Record", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtGroup_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGroup.KeyUp
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Add Full Record", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtPrice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrice.KeyUp
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Enter Full Record", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
End Class

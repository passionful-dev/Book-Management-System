Imports System.Data.SqlClient
Public Class frmLogin
    Inherits System.Windows.Forms.Form

    'Variable initializations for sql 
    Dim con As New SqlConnection("server=HOME-EMJKYXXGTL;uid=sa;pwd=aptech;database=master")

    Dim com As New SqlCommand()
    Dim da As New SqlDataAdapter(com)
    Dim ds As New DataSet()
    Friend cok As DialogResult = DialogResult.Cancel
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents admin As System.Windows.Forms.CheckBox
    Friend WithEvents passwd As System.Windows.Forms.TextBox
    Friend WithEvents uname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdlogin As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.admin = New System.Windows.Forms.CheckBox()
        Me.passwd = New System.Windows.Forms.TextBox()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdlogin = New System.Windows.Forms.Button()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.admin, Me.passwd, Me.uname, Me.Label2, Me.Label1})
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'admin
        '
        Me.admin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin.Location = New System.Drawing.Point(224, 104)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(88, 24)
        Me.admin.TabIndex = 14
        Me.admin.Text = "Admin"
        Me.admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'passwd
        '
        Me.passwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwd.Location = New System.Drawing.Point(128, 72)
        Me.passwd.Name = "passwd"
        Me.passwd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.passwd.Size = New System.Drawing.Size(184, 23)
        Me.passwd.TabIndex = 11
        Me.passwd.Text = ""
        '
        'uname
        '
        Me.uname.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uname.Location = New System.Drawing.Point(128, 32)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(184, 23)
        Me.uname.TabIndex = 10
        Me.uname.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(25, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "User Login Form"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdlogin
        '
        Me.cmdlogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogin.Location = New System.Drawing.Point(180, 187)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(72, 24)
        Me.cmdlogin.TabIndex = 17
        Me.cmdlogin.Text = "Login"
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(260, 187)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdcancel.TabIndex = 18
        Me.cmdcancel.Text = "Cancel"
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(346, 223)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdcancel, Me.cmdlogin, Me.Label3, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub admin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin.CheckedChanged
        If admin.Checked = True Then
            uname.Text = "administrator"
        Else
            uname.Clear()
        End If
    End Sub

    Private Sub passwd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles passwd.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmdlogin_Click(sender, e)
        End If
    End Sub



    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ConnectionWithDatabase()
        Dim l As New frmSplash()
        l.ShowDialog()
    End Sub


    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        'Sql connection
        com.Connection = con
        com.CommandText = "select * from tbluser where username='" & uname.Text & "' and userpassword='" & passwd.Text & "'"

        'Fill data
        da.Fill(ds, "tbluser")
        'Check if the data given is NULL
        If ds.Tables("tbluser").Rows.Count > 0 Then
            cok = DialogResult.OK
            userName = ds.Tables("tbluser").Rows(0).Item("UserName")
            Me.Close()
        Else
            MsgBox("Invalid user,Try again")
        End If
        ds.Clear()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        'Close application
        cok = DialogResult.Cancel
        Me.Close()
    End Sub




End Class

Imports System.Data.SqlClient
Public Class frmChangePassword
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtConpasswd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewpasswd As System.Windows.Forms.TextBox
    Friend WithEvents txtOldpasswd As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConpasswd = New System.Windows.Forms.TextBox()
        Me.txtNewpasswd = New System.Windows.Forms.TextBox()
        Me.txtOldpasswd = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(201, 246)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "Ok"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(281, 246)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(0, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(376, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Change Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtConpasswd, Me.txtNewpasswd, Me.txtOldpasswd, Me.txtUsername, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 192)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtConpasswd
        '
        Me.txtConpasswd.Location = New System.Drawing.Point(154, 152)
        Me.txtConpasswd.Name = "txtConpasswd"
        Me.txtConpasswd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtConpasswd.Size = New System.Drawing.Size(182, 23)
        Me.txtConpasswd.TabIndex = 15
        Me.txtConpasswd.Text = ""
        '
        'txtNewpasswd
        '
        Me.txtNewpasswd.Location = New System.Drawing.Point(154, 112)
        Me.txtNewpasswd.Name = "txtNewpasswd"
        Me.txtNewpasswd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtNewpasswd.Size = New System.Drawing.Size(182, 23)
        Me.txtNewpasswd.TabIndex = 14
        Me.txtNewpasswd.Text = ""
        '
        'txtOldpasswd
        '
        Me.txtOldpasswd.Location = New System.Drawing.Point(154, 72)
        Me.txtOldpasswd.Name = "txtOldpasswd"
        Me.txtOldpasswd.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtOldpasswd.Size = New System.Drawing.Size(182, 23)
        Me.txtOldpasswd.TabIndex = 13
        Me.txtOldpasswd.Text = ""
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(154, 32)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(182, 23)
        Me.txtUsername.TabIndex = 12
        Me.txtUsername.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Old Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "User Name"
        '
        'frmChangePassword
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(368, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.Label5, Me.btnCancel, Me.btnOk})
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChangePassword"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'Assigning the username & disabling it
        txtUsername.Text = userName
        txtUsername.Enabled = False
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Call changePassword()
    End Sub


    Sub changePassword()
        adap = New SqlDataAdapter("select username,userpassword from tbluser where username='" & userName & "'", cn)
        ds = New DataSet()
        adap.Fill(ds, "TblUser")
        Dim drs As DataRow = ds.Tables("TblUser").Rows(0)
        If Me.txtOldpasswd.Text <> drs("UserPassword") Then
            MsgBox("Old password is incorrect!", MsgBoxStyle.Exclamation)
            Me.txtOldpasswd.Focus()
            Me.txtOldpasswd.ResetText()
            Exit Sub
        End If

        If Me.txtNewpasswd.Text <> Me.txtConpasswd.Text Then
            MsgBox("Password mismatch!", MsgBoxStyle.Exclamation)
            Me.txtNewpasswd.Focus()
            Me.txtNewpasswd.ResetText()
            Me.txtConpasswd.ResetText()
            Exit Sub
        End If

        drs("UserPassword") = Me.txtNewpasswd.Text
        Dim cmb As New SqlCommandBuilder(adap)
        adap.Update(ds, "TblUser")
        MsgBox("Your password has been changed successfully", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    Private Sub txtConpasswd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConpasswd.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnOk_Click(sender, e)
        End If
    End Sub
End Class

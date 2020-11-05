Imports System.Data.SqlClient


Public Class frmUserDetails
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgcol1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcol2 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUserDetails))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.dgcol1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgcol2 = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(9, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "User Details"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Users Details"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 72)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 128
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(296, 208)
        Me.DataGrid1.TabIndex = 14
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
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
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.Alt4
        Me.MenuItem2.Text = "&Quit"
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton3})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(314, 25)
        Me.ToolBar1.TabIndex = 15
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.ToolTipText = "Print"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.ToolTipText = "Delete User "
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.ToolTipText = "Quit"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgcol1, Me.dgcol2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "tbluser"
        '
        'dgcol1
        '
        Me.dgcol1.Format = ""
        Me.dgcol1.FormatInfo = Nothing
        Me.dgcol1.HeaderText = "User Name"
        Me.dgcol1.MappingName = "username"
        Me.dgcol1.Width = 128
        '
        'dgcol2
        '
        Me.dgcol2.Format = ""
        Me.dgcol2.FormatInfo = Nothing
        Me.dgcol2.HeaderText = "User Type"
        Me.dgcol2.MappingName = "usertype"
        Me.dgcol2.Width = 128
        '
        'frmUserDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(314, 291)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ToolBar1, Me.DataGrid1, Me.Label7})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmUserDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserDetails"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim cn As SqlConnection
    Dim adap As SqlDataAdapter
    Dim ds As DataSet


    Private Sub frmUserDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call IfitisRefreshed()
        'Dim i As DataRow
        'Dim j As DataColumn

        'For Each i In ds.Tables("Users").Rows
        '    For Each j In ds.Tables("Users").Columns
        '        ListView = dd(i(j))
        '    Next
        'Next
    End Sub
    Sub IfitisRefreshed()
        cn = New SqlConnection("server=HOME-EMJKYXXGTL;uid=sa;pwd=aptech;database=master")
        adap = New SqlDataAdapter("select username, usertype from tbluser", cn)
        ds = New DataSet()
        adap.Fill(ds, "tbluser")
        Me.DataGrid1.DataSource = ds.Tables("tbluser")

    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button Is ToolBarButton2 Then
            Call deleteUserdetails()
        ElseIf e.Button Is ToolBarButton1 Then
            Dim l As New PrintUserDetails()
            l.ShowDialog()
        ElseIf e.Button Is ToolBarButton3 Then
            Me.Close()
        End If
    End Sub


    'Function to delete Userdetails
    Sub deleteUserdetails()
        Dim dres As DialogResult = MessageBox.Show("Really want to delete this User's detail", "Delete", MsgBoxStyle.YesNo, MessageBoxIcon.Question)
        If dres = DialogResult.No Then
            Exit Sub
        End If
        'Check if UserName is more than one entered
        Dim str As String = ds.Tables("tbluser").Rows(DataGrid1.CurrentRowIndex)("username")
        If str.Length > 1 Then
            Dim com As New SqlCommand("delete from tbluser where username='" & str & "'", cn)
            cn.Open()
            Dim i As Integer = com.ExecuteNonQuery() 'To run sql command because dataadaptor not used
            cn.Close()
            If Not (i > 0) Then
                MessageBox.Show("Record could not be deleted", "Book Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MsgBox("Record deleted successfully")
                Call IfitisRefreshed()
            End If
        Else
            MsgBox("Record is not deleted")
        End If

    End Sub

End Class

Imports System.Data.SqlClient

Public Class frmBookDetails
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents AddNew As System.Windows.Forms.MenuItem
    Friend WithEvents Edit As System.Windows.Forms.MenuItem
    Friend WithEvents Delete As System.Windows.Forms.MenuItem
    Friend WithEvents AddNewUsers As System.Windows.Forms.MenuItem
    Friend WithEvents Server As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents s As System.Windows.Forms.MenuItem
    Friend WithEvents Refresh As System.Windows.Forms.MenuItem
    Friend WithEvents Quit As System.Windows.Forms.MenuItem
    Friend WithEvents e As System.Windows.Forms.MenuItem
    Friend WithEvents ChangePasswd As System.Windows.Forms.MenuItem
    Friend WithEvents UserDetails As System.Windows.Forms.MenuItem
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgcol1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcol2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcol3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcol4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcol5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgcol6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBookDetails))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.dgcol1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgcol2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgcol3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgcol4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgcol5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgcol6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.AddNew = New System.Windows.Forms.MenuItem()
        Me.Edit = New System.Windows.Forms.MenuItem()
        Me.Delete = New System.Windows.Forms.MenuItem()
        Me.s = New System.Windows.Forms.MenuItem()
        Me.Refresh = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.Quit = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.AddNewUsers = New System.Windows.Forms.MenuItem()
        Me.e = New System.Windows.Forms.MenuItem()
        Me.ChangePasswd = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.UserDetails = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.Server = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.DataGrid1.CaptionText = "Book Details"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 144)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 150
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(784, 304)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dgcol1, Me.dgcol2, Me.dgcol3, Me.dgcol4, Me.dgcol5, Me.dgcol6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'dgcol1
        '
        Me.dgcol1.Format = ""
        Me.dgcol1.FormatInfo = Nothing
        Me.dgcol1.HeaderText = "Book Name"
        Me.dgcol1.MappingName = ""
        Me.dgcol1.Width = 250
        '
        'dgcol2
        '
        Me.dgcol2.Format = ""
        Me.dgcol2.FormatInfo = Nothing
        Me.dgcol2.HeaderText = "Author"
        Me.dgcol2.MappingName = ""
        Me.dgcol2.Width = 160
        '
        'dgcol3
        '
        Me.dgcol3.Format = ""
        Me.dgcol3.FormatInfo = Nothing
        Me.dgcol3.HeaderText = "Publication"
        Me.dgcol3.MappingName = ""
        Me.dgcol3.Width = 160
        '
        'dgcol4
        '
        Me.dgcol4.Format = ""
        Me.dgcol4.FormatInfo = Nothing
        Me.dgcol4.HeaderText = "Groups"
        Me.dgcol4.MappingName = ""
        Me.dgcol4.Width = 90
        '
        'dgcol5
        '
        Me.dgcol5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgcol5.Format = ""
        Me.dgcol5.FormatInfo = Nothing
        Me.dgcol5.HeaderText = "Price"
        Me.dgcol5.MappingName = ""
        Me.dgcol5.Width = 75
        '
        'dgcol6
        '
        Me.dgcol6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.dgcol6.Format = ""
        Me.dgcol6.FormatInfo = Nothing
        Me.dgcol6.HeaderText = "Pages"
        Me.dgcol6.MappingName = ""
        Me.dgcol6.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ComboBox4, Me.Label4, Me.search, Me.ComboBox3, Me.Label3, Me.ComboBox2, Me.Label2, Me.ComboBox1, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(240, 32)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox4.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Author"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(720, 32)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(56, 23)
        Me.search.TabIndex = 8
        Me.search.Text = "Search"
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(434, 32)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(365, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Publication"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(598, 32)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(557, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Group"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(74, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(312, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Book Details"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem7, Me.MenuItem12, Me.MenuItem14})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AddNew, Me.Edit, Me.Delete, Me.s, Me.Refresh, Me.MenuItem2, Me.Quit})
        Me.MenuItem1.Text = "&Book"
        '
        'AddNew
        '
        Me.AddNew.Index = 0
        Me.AddNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.AddNew.Text = "Add &New"
        '
        'Edit
        '
        Me.Edit.Index = 1
        Me.Edit.Text = "&Edit"
        '
        'Delete
        '
        Me.Delete.Index = 2
        Me.Delete.Text = "&Delete"
        '
        's
        '
        Me.s.Index = 3
        Me.s.Text = "-"
        '
        'Refresh
        '
        Me.Refresh.Index = 4
        Me.Refresh.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.Refresh.Text = "&Refresh"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Text = "-"
        '
        'Quit
        '
        Me.Quit.Index = 6
        Me.Quit.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.Quit.Text = "&Quit"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.AddNewUsers, Me.e, Me.ChangePasswd, Me.MenuItem5, Me.UserDetails})
        Me.MenuItem7.Text = "&Users"
        '
        'AddNewUsers
        '
        Me.AddNewUsers.Index = 0
        Me.AddNewUsers.Text = "Add New Users"
        '
        'e
        '
        Me.e.Index = 1
        Me.e.Text = "-"
        '
        'ChangePasswd
        '
        Me.ChangePasswd.Index = 2
        Me.ChangePasswd.Text = "Change Password"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'UserDetails
        '
        Me.UserDetails.Index = 4
        Me.UserDetails.Text = "User Details"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Server})
        Me.MenuItem12.Text = "&Settings"
        '
        'Server
        '
        Me.Server.Index = 0
        Me.Server.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
        Me.Server.Text = "Ser&ver"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem14.Text = "&Help"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem3.Text = "Help for BMS"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "About BMS"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton2, Me.ToolBarButton8, Me.ToolBarButton1, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton10, Me.ToolBarButton3, Me.ToolBarButton9, Me.ToolBarButton11})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(800, 39)
        Me.ToolBar1.TabIndex = 3
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 0
        Me.ToolBarButton8.Text = "New Book"
        Me.ToolBarButton8.ToolTipText = "Add New Book"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 1
        Me.ToolBarButton4.Text = "Delete"
        Me.ToolBarButton4.ToolTipText = "Delete Record"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 2
        Me.ToolBarButton6.Text = "Refresh"
        Me.ToolBarButton6.ToolTipText = "Refresh"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 4
        Me.ToolBarButton10.Text = "Print"
        Me.ToolBarButton10.ToolTipText = "Print Book Details"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 3
        Me.ToolBarButton9.Text = "Quit"
        Me.ToolBarButton9.ToolTipText = "Quit Application"
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmBookDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 453)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ToolBar1, Me.Label5, Me.GroupBox1, Me.DataGrid1})
        Me.Menu = Me.MainMenu1
        Me.Name = "frmBookDetails"
        Me.Text = "Book Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'Database connection
        Call ConnectionWithDatabase()

        'Refreshing the data entered
        Call RefreshBookDetailsInformation()
        Call RefreshBookDetailsInformation()

        'Calling objects(BookName, Group, Pubication & Author) to show on combo-box
        Call ShowBookName()
        Call ShowGroup()
        Call ShowPublication()
        Call ShowAuthor()

        'Close connection
        cn.Close()
    End Sub

    'Showing BookName on combo-box
    Sub ShowBookName()
        Dim adap1 As SqlDataAdapter = New SqlDataAdapter("select distinct BookName from tblBookDetails1", cn)
        Dim ds1 As DataSet = New DataSet()
        adap1.Fill(ds1, "tblBookDetails1")

        Dim dr As DataRow
        For Each dr In ds1.Tables("tblBookDetails1").Rows
            Me.ComboBox1.Items.Add(dr(0))
        Next
    End Sub

    'Showing Group on combo-box
    Sub ShowGroup()
        Dim adap2 As SqlDataAdapter = New SqlDataAdapter("select distinct [Groups] from tblBookDetails1", cn)
        Dim ds2 As DataSet = New DataSet()
        adap2.Fill(ds2, "tblBookDetails1")

        Dim dr As DataRow
        For Each dr In ds2.Tables("tblBookDetails1").Rows
            Me.ComboBox2.Items.Add(dr(0))
        Next
    End Sub

    'Showing Publication on combo-box
    Sub ShowPublication()
        Dim adap1 As SqlDataAdapter = New SqlDataAdapter("select distinct [Publication] from tblBookDetails1", cn)
        Dim ds1 As DataSet = New DataSet()
        adap1.Fill(ds1, "tblBookDetails1")

        Dim dr As DataRow
        For Each dr In ds1.Tables("tblBookDetails1").Rows
            Me.ComboBox3.Items.Add(dr(0))
        Next
    End Sub

    'Showing Author on combo-box
    Sub ShowAuthor()
        Dim adap1 As SqlDataAdapter = New SqlDataAdapter("select distinct [Author] from tblBookDetails1", cn)
        Dim ds1 As DataSet = New DataSet()
        adap1.Fill(ds1, "tblBookDetails1")

        Dim dr As DataRow
        For Each dr In ds1.Tables("tblBookDetails1").Rows
            Me.ComboBox4.Items.Add(dr(0))
        Next
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click

        Dim c1 As String
        Dim c2 As String
        Dim c3 As String
        Dim c4 As String

        c1 = Me.ComboBox1.Text
        c2 = Me.ComboBox2.Text
        c3 = Me.ComboBox3.Text
        c4 = Me.ComboBox4.Text

        Dim cmdstr As String = "select * from tblBookDetails1 Where BookName like '" & c1 & "%' and Author like '" & c4 & "%' and publication like '" & c3 & "%' and Groups like '" & c2 & "%'"
        adap = New SqlDataAdapter(cmdstr, cn)
        ds.Clear()
        adap.Fill(ds, "tblBookDetails1")
        Me.DataGrid1.DataSource = ds.Tables("tblBookDetails1")

    End Sub

    Private Sub AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        Dim f As New frmAddNewBook()
        f.ShowDialog()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quit.Click
        'Quit
        If MessageBox.Show("Do you want to close application", "Book Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    'Check which toolbar is clicked and perform its operation
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        'Check if Add New Book is clicked
        If e.Button Is ToolBarButton8 Then
            Dim item As frmAddNewBook = New frmAddNewBook()
            item.Show()

            'Check if Quit is clicked
        ElseIf e.Button Is ToolBarButton9 Then
            If MessageBox.Show("Do you want to close application", "Book Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Application.Exit()
            End If

            'Check if Refresh is clicked
        ElseIf e.Button Is ToolBarButton6 Then
            Call RefreshBookDetailsInformation()
            Call ComboClear()

            'Check if Delete is clicked
        ElseIf e.Button Is ToolBarButton4 Then
            'Calling delete function
            Delete_Click(sender, e)

            'Check if Print is clicked
        ElseIf e.Button Is ToolBarButton10 Then
            Dim fd As New PrintBookDetails()
            fd.ShowDialog()
        End If
    End Sub

    'Clearing combos
    Sub ComboClear()
        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""
        Me.ComboBox4.Text = ""
    End Sub


    'Wherever refreshed, then this function is called
    Sub RefreshBookDetailsInformation()
        adap = New SqlDataAdapter("select * from tblBookDetails1", cn)
        ds = New DataSet()
        adap.Fill(ds, "tblBookDetails1")
        Me.DataGrid1.DataSource = ds
        Me.DataGrid1.DataMember = "tblBookDetails1"
        Me.DataGridTableStyle1.MappingName = "tblBookDetails1"
        Me.dgcol1.MappingName = "bookname"
        Me.dgcol2.MappingName = "author"
        Me.dgcol3.MappingName = "publication"
        Me.dgcol4.MappingName = "groups"
        Me.dgcol5.MappingName = "price"
        Me.dgcol6.MappingName = "tpages"

    End Sub


    '"User Details" form is called
    Private Sub UserDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserDetails.Click
        Dim f As New frmUserDetails()
        f.ShowDialog()
    End Sub


    '"Add New Users" form is called
    Private Sub AddNewUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewUsers.Click
        Dim f As New frmNewUser()
        f.ShowDialog()
    End Sub


    'Activate Book Details from
    Private Sub frmBookDetails_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Check if this form is refreshed
        If isRefresh = True Then
            Call RefreshBookDetailsInformation()
        End If
    End Sub

    'Function to delete bookentry
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        'Displaying input box to accept Book Name
        Dim dres As DialogResult = MessageBox.Show("Really want to delete the record?", "Delete", MsgBoxStyle.YesNo, MessageBoxIcon.Question)
        If dres = DialogResult.No Then
            Exit Sub
        End If
        'Check if Book Name entered
        Dim str As String = ds.Tables("tblbookdetails1").Rows(DataGrid1.CurrentRowIndex)("bookid")
        If str.Length > 0 Then
            Dim com As New SqlCommand("delete from tblBookDetails1 where bookid='" & str & "'", cn)
            cn.Open()
            Dim i As Integer = com.ExecuteNonQuery() 'To run sql command
            cn.Close()
            If Not (i > 0) Then
                MessageBox.Show("Record could not be deleted", "Book Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Call RefreshBookDetailsInformation()
                Call ComboClear()
                MsgBox("Record deleted successfully")
            End If
        End If
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        If DataGrid1.CurrentRowIndex >= 0 Then
            Dim dr As DataRow = ds.Tables("tblBookDetails1").Rows(DataGrid1.CurrentRowIndex)
            Dim f As New frmEditBookEntry(dr("bookid"))
            f.ShowDialog()
            Call RefreshBookDetailsInformation()
            Call ComboClear()
        End If
    End Sub


    'Called to refresh from menu
    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        Call RefreshBookDetailsInformation()
        Call ComboClear()
    End Sub


    '"Setting" form is called
    Private Sub Server_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Server.Click
        Dim f As New frmSetting()
        f.ShowDialog()
    End Sub

    Private Sub ChangePasswd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswd.Click
        Dim f As New frmChangePassword()
        f.ShowDialog()
    End Sub


    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim l As New AboutBMS()
        l.ShowDialog()
    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        'Help.ShowHelp(Me, BMS1.Chm)
    End Sub
End Class

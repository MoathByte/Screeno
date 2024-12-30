<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.backtologinlink = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBoxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBoxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox5 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox6 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.panelGraph1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.panelGraph1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 143
        Me.IconPictureBox1.Location = New System.Drawing.Point(144, 43)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(152, 143)
        Me.IconPictureBox1.TabIndex = 17
        Me.IconPictureBox1.TabStop = False
        '
        'backtologinlink
        '
        Me.backtologinlink.AutoSize = True
        Me.backtologinlink.LinkColor = System.Drawing.Color.PaleGoldenrod
        Me.backtologinlink.Location = New System.Drawing.Point(234, 259)
        Me.backtologinlink.Name = "backtologinlink"
        Me.backtologinlink.Size = New System.Drawing.Size(33, 13)
        Me.backtologinlink.TabIndex = 14
        Me.backtologinlink.TabStop = True
        Me.backtologinlink.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(101, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Already have an account?"
        '
        'txtBoxFirstname
        '
        Me.txtBoxFirstname.Animated = True
        Me.txtBoxFirstname.BorderRadius = 14
        Me.txtBoxFirstname.BorderThickness = 3
        Me.txtBoxFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxFirstname.DefaultText = ""
        Me.txtBoxFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBoxFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBoxFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBoxFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxFirstname.Location = New System.Drawing.Point(140, 116)
        Me.txtBoxFirstname.Name = "txtBoxFirstname"
        Me.txtBoxFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxFirstname.PlaceholderText = ""
        Me.txtBoxFirstname.SelectedText = ""
        Me.txtBoxFirstname.Size = New System.Drawing.Size(200, 36)
        Me.txtBoxFirstname.TabIndex = 12
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.Animated = True
        Me.txtBoxPassword.BorderRadius = 14
        Me.txtBoxPassword.BorderThickness = 3
        Me.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxPassword.DefaultText = ""
        Me.txtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxPassword.Location = New System.Drawing.Point(140, 74)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtBoxPassword.PlaceholderText = ""
        Me.txtBoxPassword.SelectedText = ""
        Me.txtBoxPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtBoxPassword.TabIndex = 11
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'btnRegister
        '
        Me.btnRegister.Animated = True
        Me.btnRegister.AutoRoundedCorners = True
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BorderRadius = 22
        Me.btnRegister.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.IndicateFocus = True
        Me.btnRegister.Location = New System.Drawing.Point(21, 207)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(321, 46)
        Me.btnRegister.TabIndex = 10
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseTransparentBackground = True
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.Animated = True
        Me.txtBoxUsername.BorderRadius = 14
        Me.txtBoxUsername.BorderThickness = 3
        Me.txtBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxUsername.DefaultText = ""
        Me.txtBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxUsername.Location = New System.Drawing.Point(140, 32)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxUsername.PlaceholderText = ""
        Me.txtBoxUsername.SelectedText = ""
        Me.txtBoxUsername.Size = New System.Drawing.Size(200, 36)
        Me.txtBoxUsername.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Password"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Username"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "First Name"
        '
        'txtBoxLastName
        '
        Me.txtBoxLastName.Animated = True
        Me.txtBoxLastName.BorderRadius = 14
        Me.txtBoxLastName.BorderThickness = 3
        Me.txtBoxLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxLastName.DefaultText = ""
        Me.txtBoxLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBoxLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBoxLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBoxLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBoxLastName.Location = New System.Drawing.Point(140, 158)
        Me.txtBoxLastName.Name = "txtBoxLastName"
        Me.txtBoxLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxLastName.PlaceholderText = ""
        Me.txtBoxLastName.SelectedText = ""
        Me.txtBoxLastName.Size = New System.Drawing.Size(200, 36)
        Me.txtBoxLastName.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Second Name"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2ControlBox4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ControlBox5)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ControlBox6)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(432, 29)
        Me.Guna2Panel2.TabIndex = 26
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.Animated = True
        Me.Guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(360, 1)
        Me.Guna2ControlBox4.Name = "Guna2ControlBox4"
        Me.Guna2ControlBox4.Size = New System.Drawing.Size(35, 25)
        Me.Guna2ControlBox4.TabIndex = 4
        '
        'Guna2ControlBox5
        '
        Me.Guna2ControlBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox5.Animated = True
        Me.Guna2ControlBox5.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2ControlBox5.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox5.Location = New System.Drawing.Point(330, 1)
        Me.Guna2ControlBox5.Name = "Guna2ControlBox5"
        Me.Guna2ControlBox5.Size = New System.Drawing.Size(35, 25)
        Me.Guna2ControlBox5.TabIndex = 3
        '
        'Guna2ControlBox6
        '
        Me.Guna2ControlBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox6.Animated = True
        Me.Guna2ControlBox6.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2ControlBox6.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Guna2ControlBox6.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox6.Location = New System.Drawing.Point(391, 1)
        Me.Guna2ControlBox6.Name = "Guna2ControlBox6"
        Me.Guna2ControlBox6.Size = New System.Drawing.Size(35, 25)
        Me.Guna2ControlBox6.TabIndex = 2
        '
        'panelGraph1
        '
        Me.panelGraph1.Controls.Add(Me.txtBoxUsername)
        Me.panelGraph1.Controls.Add(Me.btnRegister)
        Me.panelGraph1.Controls.Add(Me.Label4)
        Me.panelGraph1.Controls.Add(Me.txtBoxPassword)
        Me.panelGraph1.Controls.Add(Me.txtBoxLastName)
        Me.panelGraph1.Controls.Add(Me.txtBoxFirstname)
        Me.panelGraph1.Controls.Add(Me.Label2)
        Me.panelGraph1.Controls.Add(Me.Label1)
        Me.panelGraph1.Controls.Add(Me.Label5)
        Me.panelGraph1.Controls.Add(Me.backtologinlink)
        Me.panelGraph1.Controls.Add(Me.Label3)
        Me.panelGraph1.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panelGraph1.Location = New System.Drawing.Point(29, 192)
        Me.panelGraph1.Name = "panelGraph1"
        Me.panelGraph1.Size = New System.Drawing.Size(377, 296)
        Me.panelGraph1.TabIndex = 27
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.panelGraph1
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel2
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 532)
        Me.Controls.Add(Me.panelGraph1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.panelGraph1.ResumeLayout(False)
        Me.panelGraph1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents backtologinlink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBoxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox5 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox6 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents panelGraph1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class

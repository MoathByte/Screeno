<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegisterLink = New System.Windows.Forms.LinkLabel()
        Me.iconUsername = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPassword = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelGraph1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox4 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox5 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox6 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.iconUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGraph1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderRadius = 22
        Me.btnLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IndicateFocus = True
        Me.btnLogin.Location = New System.Drawing.Point(20, 129)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(232, 46)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseTransparentBackground = True
        '
        'txtLogin
        '
        Me.txtLogin.BorderRadius = 8
        Me.txtLogin.BorderThickness = 3
        Me.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLogin.DefaultText = ""
        Me.txtLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLogin.Location = New System.Drawing.Point(52, 20)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLogin.PlaceholderText = ""
        Me.txtLogin.SelectedText = ""
        Me.txtLogin.Size = New System.Drawing.Size(200, 36)
        Me.txtLogin.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 8
        Me.txtPassword.BorderThickness = 3
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(52, 77)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(200, 36)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(49, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Don't have an account?"
        '
        'RegisterLink
        '
        Me.RegisterLink.AutoSize = True
        Me.RegisterLink.BackColor = System.Drawing.Color.Transparent
        Me.RegisterLink.LinkColor = System.Drawing.Color.PaleGoldenrod
        Me.RegisterLink.Location = New System.Drawing.Point(171, 188)
        Me.RegisterLink.Name = "RegisterLink"
        Me.RegisterLink.Size = New System.Drawing.Size(46, 13)
        Me.RegisterLink.TabIndex = 6
        Me.RegisterLink.TabStop = True
        Me.RegisterLink.Text = "Register"
        '
        'iconUsername
        '
        Me.iconUsername.BackColor = System.Drawing.Color.Transparent
        Me.iconUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.iconUsername.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.iconUsername.IconColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.iconUsername.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconUsername.Location = New System.Drawing.Point(18, 21)
        Me.iconUsername.Name = "iconUsername"
        Me.iconUsername.Size = New System.Drawing.Size(32, 32)
        Me.iconUsername.TabIndex = 7
        Me.iconUsername.TabStop = False
        '
        'iconPassword
        '
        Me.iconPassword.BackColor = System.Drawing.Color.Transparent
        Me.iconPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.iconPassword.IconColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.iconPassword.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.iconPassword.Location = New System.Drawing.Point(18, 79)
        Me.iconPassword.Name = "iconPassword"
        Me.iconPassword.Size = New System.Drawing.Size(32, 32)
        Me.iconPassword.TabIndex = 8
        Me.iconPassword.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 101
        Me.IconPictureBox1.Location = New System.Drawing.Point(117, 32)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(102, 101)
        Me.IconPictureBox1.TabIndex = 9
        Me.IconPictureBox1.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'panelGraph1
        '
        Me.panelGraph1.Controls.Add(Me.txtLogin)
        Me.panelGraph1.Controls.Add(Me.btnLogin)
        Me.panelGraph1.Controls.Add(Me.txtPassword)
        Me.panelGraph1.Controls.Add(Me.iconPassword)
        Me.panelGraph1.Controls.Add(Me.Label1)
        Me.panelGraph1.Controls.Add(Me.iconUsername)
        Me.panelGraph1.Controls.Add(Me.RegisterLink)
        Me.panelGraph1.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panelGraph1.Location = New System.Drawing.Point(29, 139)
        Me.panelGraph1.Name = "panelGraph1"
        Me.panelGraph1.Size = New System.Drawing.Size(271, 227)
        Me.panelGraph1.TabIndex = 23
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me.panelGraph1
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(327, 29)
        Me.Guna2Panel2.TabIndex = 24
        '
        'Guna2ControlBox4
        '
        Me.Guna2ControlBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox4.Animated = True
        Me.Guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2ControlBox4.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox4.Location = New System.Drawing.Point(256, 1)
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
        Me.Guna2ControlBox5.Location = New System.Drawing.Point(221, 1)
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
        Me.Guna2ControlBox6.Location = New System.Drawing.Point(291, 1)
        Me.Guna2ControlBox6.Name = "Guna2ControlBox6"
        Me.Guna2ControlBox6.Size = New System.Drawing.Size(35, 25)
        Me.Guna2ControlBox6.TabIndex = 2
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(327, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.panelGraph1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.iconUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGraph1.ResumeLayout(False)
        Me.panelGraph1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents iconUsername As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents RegisterLink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents iconPassword As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelGraph1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox4 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox5 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox6 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class

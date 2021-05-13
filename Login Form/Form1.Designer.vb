<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ElipseForm = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ElementsRegister = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnReg1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.ElementsLogin = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnLog = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextboxPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelPass = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelUser = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelMove = New System.Windows.Forms.Timer(Me.components)
        Me.ElementsLoginMove = New System.Windows.Forms.Timer(Me.components)
        Me.ElementsRegisterMove = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ElementsRegister.SuspendLayout()
        Me.ElementsLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'ElipseForm
        '
        Me.ElipseForm.ElipseRadius = 40
        Me.ElipseForm.TargetControl = Me
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me.Panel1
        Me.DragControl.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Login_Form.My.Resources.Resources.Black_Transparent_Gradient
        Me.Panel1.Controls.Add(Me.ElementsRegister)
        Me.Panel1.Controls.Add(Me.ElementsLogin)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 600)
        Me.Panel1.TabIndex = 4
        '
        'ElementsRegister
        '
        Me.ElementsRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ElementsRegister.Controls.Add(Me.Label2)
        Me.ElementsRegister.Controls.Add(Me.BunifuCustomLabel5)
        Me.ElementsRegister.Controls.Add(Me.btnReg1)
        Me.ElementsRegister.Controls.Add(Me.BunifuCustomLabel4)
        Me.ElementsRegister.Controls.Add(Me.RadioButton2)
        Me.ElementsRegister.Controls.Add(Me.RadioButton1)
        Me.ElementsRegister.Controls.Add(Me.BunifuCustomLabel3)
        Me.ElementsRegister.Controls.Add(Me.BunifuMetroTextbox3)
        Me.ElementsRegister.Controls.Add(Me.BunifuCustomLabel2)
        Me.ElementsRegister.Controls.Add(Me.BunifuMetroTextbox2)
        Me.ElementsRegister.Controls.Add(Me.BunifuCustomLabel1)
        Me.ElementsRegister.Controls.Add(Me.BunifuMetroTextbox1)
        Me.ElementsRegister.Location = New System.Drawing.Point(0, 486)
        Me.ElementsRegister.Name = "ElementsRegister"
        Me.ElementsRegister.Size = New System.Drawing.Size(200, 334)
        Me.ElementsRegister.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(21, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sing Up"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(42, 315)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(124, 11)
        Me.BunifuCustomLabel5.TabIndex = 4
        Me.BunifuCustomLabel5.Text = "I already have an account"
        '
        'btnReg1
        '
        Me.btnReg1.ActiveBorderThickness = 1
        Me.btnReg1.ActiveCornerRadius = 20
        Me.btnReg1.ActiveFillColor = System.Drawing.Color.Maroon
        Me.btnReg1.ActiveForecolor = System.Drawing.Color.White
        Me.btnReg1.ActiveLineColor = System.Drawing.Color.White
        Me.btnReg1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReg1.BackgroundImage = CType(resources.GetObject("btnReg1.BackgroundImage"), System.Drawing.Image)
        Me.btnReg1.ButtonText = "ThinButton"
        Me.btnReg1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReg1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg1.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnReg1.IdleBorderThickness = 1
        Me.btnReg1.IdleCornerRadius = 20
        Me.btnReg1.IdleFillColor = System.Drawing.Color.White
        Me.btnReg1.IdleForecolor = System.Drawing.Color.Maroon
        Me.btnReg1.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnReg1.Location = New System.Drawing.Point(54, 268)
        Me.btnReg1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReg1.Name = "btnReg1"
        Me.btnReg1.Size = New System.Drawing.Size(96, 43)
        Me.btnReg1.TabIndex = 7
        Me.btnReg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(22, 250)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(50, 14)
        Me.BunifuCustomLabel4.TabIndex = 14
        Me.BunifuCustomLabel4.Text = "Gender:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(130, 250)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 15)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(78, 250)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 15)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(22, 184)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(61, 14)
        Me.BunifuCustomLabel3.TabIndex = 10
        Me.BunifuCustomLabel3.Text = "Password:"
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Red
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.BunifuMetroTextbox3.BorderThickness = 3
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.isPassword = False
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(25, 202)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(150, 30)
        Me.BunifuMetroTextbox3.TabIndex = 11
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(22, 131)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(64, 14)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "Username:"
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Red
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.BunifuMetroTextbox2.BorderThickness = 3
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(25, 149)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(150, 30)
        Me.BunifuMetroTextbox2.TabIndex = 9
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(22, 81)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(86, 14)
        Me.BunifuCustomLabel1.TabIndex = 7
        Me.BunifuCustomLabel1.Text = "Email address:"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Red
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(25, 99)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(150, 30)
        Me.BunifuMetroTextbox1.TabIndex = 7
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ElementsLogin
        '
        Me.ElementsLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ElementsLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ElementsLogin.Controls.Add(Me.Label1)
        Me.ElementsLogin.Controls.Add(Me.btnRegister)
        Me.ElementsLogin.Controls.Add(Me.btnLog)
        Me.ElementsLogin.Controls.Add(Me.TextboxPass)
        Me.ElementsLogin.Controls.Add(Me.LabelPass)
        Me.ElementsLogin.Controls.Add(Me.TextboxUser)
        Me.ElementsLogin.Controls.Add(Me.LabelUser)
        Me.ElementsLogin.Location = New System.Drawing.Point(0, 60)
        Me.ElementsLogin.Name = "ElementsLogin"
        Me.ElementsLogin.Size = New System.Drawing.Size(200, 334)
        Me.ElementsLogin.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sing In"
        '
        'btnRegister
        '
        Me.btnRegister.ActiveBorderThickness = 1
        Me.btnRegister.ActiveCornerRadius = 20
        Me.btnRegister.ActiveFillColor = System.Drawing.Color.Maroon
        Me.btnRegister.ActiveForecolor = System.Drawing.Color.White
        Me.btnRegister.ActiveLineColor = System.Drawing.Color.White
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegister.BackgroundImage = CType(resources.GetObject("btnRegister.BackgroundImage"), System.Drawing.Image)
        Me.btnRegister.ButtonText = "ThinButton"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnRegister.IdleBorderThickness = 1
        Me.btnRegister.IdleCornerRadius = 20
        Me.btnRegister.IdleFillColor = System.Drawing.Color.White
        Me.btnRegister.IdleForecolor = System.Drawing.Color.Maroon
        Me.btnRegister.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnRegister.Location = New System.Drawing.Point(54, 225)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(96, 41)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLog
        '
        Me.btnLog.ActiveBorderThickness = 1
        Me.btnLog.ActiveCornerRadius = 20
        Me.btnLog.ActiveFillColor = System.Drawing.Color.Maroon
        Me.btnLog.ActiveForecolor = System.Drawing.Color.White
        Me.btnLog.ActiveLineColor = System.Drawing.Color.White
        Me.btnLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLog.BackgroundImage = CType(resources.GetObject("btnLog.BackgroundImage"), System.Drawing.Image)
        Me.btnLog.ButtonText = "ThinButton"
        Me.btnLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLog.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLog.IdleBorderThickness = 1
        Me.btnLog.IdleCornerRadius = 20
        Me.btnLog.IdleFillColor = System.Drawing.Color.White
        Me.btnLog.IdleForecolor = System.Drawing.Color.Maroon
        Me.btnLog.IdleLineColor = System.Drawing.Color.Maroon
        Me.btnLog.Location = New System.Drawing.Point(54, 186)
        Me.btnLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(96, 43)
        Me.btnLog.TabIndex = 5
        Me.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextboxPass
        '
        Me.TextboxPass.BackColor = System.Drawing.SystemColors.Control
        Me.TextboxPass.BorderColorFocused = System.Drawing.Color.Red
        Me.TextboxPass.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextboxPass.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.TextboxPass.BorderThickness = 3
        Me.TextboxPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextboxPass.isPassword = True
        Me.TextboxPass.Location = New System.Drawing.Point(25, 152)
        Me.TextboxPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxPass.Name = "TextboxPass"
        Me.TextboxPass.Size = New System.Drawing.Size(150, 30)
        Me.TextboxPass.TabIndex = 1
        Me.TextboxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.BackColor = System.Drawing.Color.Transparent
        Me.LabelPass.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass.ForeColor = System.Drawing.Color.White
        Me.LabelPass.Location = New System.Drawing.Point(25, 138)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(61, 14)
        Me.LabelPass.TabIndex = 3
        Me.LabelPass.Text = "Password:"
        '
        'TextboxUser
        '
        Me.TextboxUser.BackColor = System.Drawing.SystemColors.Control
        Me.TextboxUser.BorderColorFocused = System.Drawing.Color.Red
        Me.TextboxUser.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextboxUser.BorderColorMouseHover = System.Drawing.Color.Maroon
        Me.TextboxUser.BorderThickness = 3
        Me.TextboxUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextboxUser.isPassword = False
        Me.TextboxUser.Location = New System.Drawing.Point(25, 99)
        Me.TextboxUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxUser.Name = "TextboxUser"
        Me.TextboxUser.Size = New System.Drawing.Size(150, 30)
        Me.TextboxUser.TabIndex = 0
        Me.TextboxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.BackColor = System.Drawing.Color.Transparent
        Me.LabelUser.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.ForeColor = System.Drawing.Color.White
        Me.LabelUser.Location = New System.Drawing.Point(25, 81)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(64, 14)
        Me.LabelUser.TabIndex = 2
        Me.LabelUser.Text = "Username:"
        '
        'PanelMove
        '
        Me.PanelMove.Interval = 1
        '
        'ElementsLoginMove
        '
        Me.ElementsLoginMove.Interval = 15
        '
        'ElementsRegisterMove
        '
        Me.ElementsRegisterMove.Interval = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = Global.Login_Form.My.Resources.Resources.bklog
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ElementsRegister.ResumeLayout(False)
        Me.ElementsRegister.PerformLayout()
        Me.ElementsLogin.ResumeLayout(False)
        Me.ElementsLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ElipseForm As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TextboxUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TextboxPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelPass As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelUser As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PanelMove As Timer
    Friend WithEvents ElementsLoginMove As Timer
    Friend WithEvents ElementsLogin As Panel
    Friend WithEvents ElementsRegisterMove As Timer
    Friend WithEvents ElementsRegister As Panel
    Friend WithEvents btnLog As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnReg1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

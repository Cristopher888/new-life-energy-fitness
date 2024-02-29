<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Panel3 = New Panel()
        btnMas = New FontAwesome.Sharp.IconButton()
        btnTurnos = New FontAwesome.Sharp.IconButton()
        btnCaja = New FontAwesome.Sharp.IconButton()
        btnUsuarios = New FontAwesome.Sharp.IconButton()
        btnInstructores = New FontAwesome.Sharp.IconButton()
        btnActividades = New FontAwesome.Sharp.IconButton()
        btnSocios = New FontAwesome.Sharp.IconButton()
        btnAcceso = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Panel2 = New Panel()
        pbLogo = New PictureBox()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel4 = New Panel()
        lblCurrentWindow = New Label()
        icoCurrentWindow = New FontAwesome.Sharp.IconPictureBox()
        Panel8 = New Panel()
        PanelDesktop = New Panel()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        CType(icoCurrentWindow, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnMas)
        Panel3.Controls.Add(btnTurnos)
        Panel3.Controls.Add(btnCaja)
        Panel3.Controls.Add(btnUsuarios)
        Panel3.Controls.Add(btnInstructores)
        Panel3.Controls.Add(btnActividades)
        Panel3.Controls.Add(btnSocios)
        Panel3.Controls.Add(btnAcceso)
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(Panel5)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(250, 881)
        Panel3.TabIndex = 1
        ' 
        ' btnMas
        ' 
        btnMas.Dock = DockStyle.Top
        btnMas.FlatAppearance.BorderSize = 0
        btnMas.FlatStyle = FlatStyle.Flat
        btnMas.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMas.ForeColor = Color.White
        btnMas.IconChar = FontAwesome.Sharp.IconChar.Plus
        btnMas.IconColor = Color.White
        btnMas.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMas.ImageAlign = ContentAlignment.MiddleLeft
        btnMas.Location = New Point(0, 687)
        btnMas.Name = "btnMas"
        btnMas.Padding = New Padding(20, 0, 0, 0)
        btnMas.Size = New Size(248, 71)
        btnMas.TabIndex = 9
        btnMas.Text = "Más"
        btnMas.TextAlign = ContentAlignment.MiddleLeft
        btnMas.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMas.UseVisualStyleBackColor = True
        ' 
        ' btnTurnos
        ' 
        btnTurnos.Dock = DockStyle.Top
        btnTurnos.FlatAppearance.BorderSize = 0
        btnTurnos.FlatStyle = FlatStyle.Flat
        btnTurnos.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTurnos.ForeColor = Color.White
        btnTurnos.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft
        btnTurnos.IconColor = Color.White
        btnTurnos.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnTurnos.ImageAlign = ContentAlignment.MiddleLeft
        btnTurnos.Location = New Point(0, 616)
        btnTurnos.Name = "btnTurnos"
        btnTurnos.Padding = New Padding(20, 0, 0, 0)
        btnTurnos.Size = New Size(248, 71)
        btnTurnos.TabIndex = 8
        btnTurnos.Text = "Turnos"
        btnTurnos.TextAlign = ContentAlignment.MiddleLeft
        btnTurnos.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTurnos.UseVisualStyleBackColor = True
        ' 
        ' btnCaja
        ' 
        btnCaja.Dock = DockStyle.Top
        btnCaja.FlatAppearance.BorderSize = 0
        btnCaja.FlatStyle = FlatStyle.Flat
        btnCaja.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCaja.ForeColor = Color.White
        btnCaja.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        btnCaja.IconColor = Color.White
        btnCaja.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCaja.ImageAlign = ContentAlignment.MiddleLeft
        btnCaja.Location = New Point(0, 545)
        btnCaja.Name = "btnCaja"
        btnCaja.Padding = New Padding(20, 0, 0, 0)
        btnCaja.Size = New Size(248, 71)
        btnCaja.TabIndex = 7
        btnCaja.Text = "Caja"
        btnCaja.TextAlign = ContentAlignment.MiddleLeft
        btnCaja.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCaja.UseVisualStyleBackColor = True
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.Dock = DockStyle.Top
        btnUsuarios.FlatAppearance.BorderSize = 0
        btnUsuarios.FlatStyle = FlatStyle.Flat
        btnUsuarios.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsuarios.ForeColor = Color.White
        btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog
        btnUsuarios.IconColor = Color.White
        btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft
        btnUsuarios.Location = New Point(0, 474)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Padding = New Padding(20, 0, 0, 0)
        btnUsuarios.Size = New Size(248, 71)
        btnUsuarios.TabIndex = 6
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.TextAlign = ContentAlignment.MiddleLeft
        btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText
        btnUsuarios.UseVisualStyleBackColor = True
        ' 
        ' btnInstructores
        ' 
        btnInstructores.Dock = DockStyle.Top
        btnInstructores.FlatAppearance.BorderSize = 0
        btnInstructores.FlatStyle = FlatStyle.Flat
        btnInstructores.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInstructores.ForeColor = Color.White
        btnInstructores.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        btnInstructores.IconColor = Color.White
        btnInstructores.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnInstructores.ImageAlign = ContentAlignment.MiddleLeft
        btnInstructores.Location = New Point(0, 403)
        btnInstructores.Name = "btnInstructores"
        btnInstructores.Padding = New Padding(20, 0, 0, 0)
        btnInstructores.Size = New Size(248, 71)
        btnInstructores.TabIndex = 5
        btnInstructores.Text = "Instructores"
        btnInstructores.TextAlign = ContentAlignment.MiddleLeft
        btnInstructores.TextImageRelation = TextImageRelation.ImageBeforeText
        btnInstructores.UseVisualStyleBackColor = True
        ' 
        ' btnActividades
        ' 
        btnActividades.Dock = DockStyle.Top
        btnActividades.FlatAppearance.BorderSize = 0
        btnActividades.FlatStyle = FlatStyle.Flat
        btnActividades.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActividades.ForeColor = Color.White
        btnActividades.IconChar = FontAwesome.Sharp.IconChar.Dumbbell
        btnActividades.IconColor = Color.White
        btnActividades.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnActividades.ImageAlign = ContentAlignment.MiddleLeft
        btnActividades.Location = New Point(0, 332)
        btnActividades.Name = "btnActividades"
        btnActividades.Padding = New Padding(20, 0, 0, 0)
        btnActividades.Size = New Size(248, 71)
        btnActividades.TabIndex = 4
        btnActividades.Text = "Actividades"
        btnActividades.TextAlign = ContentAlignment.MiddleLeft
        btnActividades.TextImageRelation = TextImageRelation.ImageBeforeText
        btnActividades.UseVisualStyleBackColor = True
        ' 
        ' btnSocios
        ' 
        btnSocios.Dock = DockStyle.Top
        btnSocios.FlatAppearance.BorderSize = 0
        btnSocios.FlatStyle = FlatStyle.Flat
        btnSocios.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSocios.ForeColor = Color.White
        btnSocios.IconChar = FontAwesome.Sharp.IconChar.Users
        btnSocios.IconColor = Color.White
        btnSocios.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnSocios.ImageAlign = ContentAlignment.MiddleLeft
        btnSocios.Location = New Point(0, 261)
        btnSocios.Name = "btnSocios"
        btnSocios.Padding = New Padding(20, 0, 0, 0)
        btnSocios.Size = New Size(248, 71)
        btnSocios.TabIndex = 3
        btnSocios.Text = "Socios"
        btnSocios.TextAlign = ContentAlignment.MiddleLeft
        btnSocios.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSocios.UseVisualStyleBackColor = True
        ' 
        ' btnAcceso
        ' 
        btnAcceso.Dock = DockStyle.Top
        btnAcceso.FlatAppearance.BorderSize = 0
        btnAcceso.FlatStyle = FlatStyle.Flat
        btnAcceso.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAcceso.ForeColor = Color.White
        btnAcceso.IconChar = FontAwesome.Sharp.IconChar.Fingerprint
        btnAcceso.IconColor = Color.White
        btnAcceso.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnAcceso.ImageAlign = ContentAlignment.MiddleLeft
        btnAcceso.Location = New Point(0, 190)
        btnAcceso.Name = "btnAcceso"
        btnAcceso.Padding = New Padding(20, 0, 0, 0)
        btnAcceso.Size = New Size(248, 71)
        btnAcceso.TabIndex = 1
        btnAcceso.Text = "Acceso"
        btnAcceso.TextAlign = ContentAlignment.MiddleLeft
        btnAcceso.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAcceso.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(pbLogo)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(248, 190)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 188)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 2)
        Panel2.TabIndex = 1
        ' 
        ' pbLogo
        ' 
        pbLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pbLogo.Image = My.Resources.Resources.logo_removebg_preview
        pbLogo.Location = New Point(49, 20)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(150, 150)
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(248, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(2, 881)
        Panel5.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Panel7)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(250, 756)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1194, 125)
        Panel6.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1194, 2)
        Panel7.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(lblCurrentWindow)
        Panel4.Controls.Add(icoCurrentWindow)
        Panel4.Controls.Add(Panel8)
        Panel4.Dock = DockStyle.Top
        Panel4.Font = New Font("Segoe UI", 12F)
        Panel4.ForeColor = Color.White
        Panel4.Location = New Point(250, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1194, 95)
        Panel4.TabIndex = 3
        ' 
        ' lblCurrentWindow
        ' 
        lblCurrentWindow.AutoSize = True
        lblCurrentWindow.Font = New Font("Segoe UI", 12F)
        lblCurrentWindow.ForeColor = Color.White
        lblCurrentWindow.Location = New Point(96, 33)
        lblCurrentWindow.Name = "lblCurrentWindow"
        lblCurrentWindow.Size = New Size(47, 21)
        lblCurrentWindow.TabIndex = 2
        lblCurrentWindow.Text = "Inicio"
        ' 
        ' icoCurrentWindow
        ' 
        icoCurrentWindow.BackColor = Color.FromArgb(CByte(41), CByte(41), CByte(41))
        icoCurrentWindow.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt
        icoCurrentWindow.IconColor = Color.White
        icoCurrentWindow.IconFont = FontAwesome.Sharp.IconFont.Auto
        icoCurrentWindow.IconSize = 50
        icoCurrentWindow.Location = New Point(40, 22)
        icoCurrentWindow.Name = "icoCurrentWindow"
        icoCurrentWindow.Size = New Size(50, 50)
        icoCurrentWindow.TabIndex = 1
        icoCurrentWindow.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Dock = DockStyle.Bottom
        Panel8.Location = New Point(0, 93)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1194, 2)
        Panel8.TabIndex = 0
        ' 
        ' PanelDesktop
        ' 
        PanelDesktop.Dock = DockStyle.Fill
        PanelDesktop.Location = New Point(250, 95)
        PanelDesktop.Name = "PanelDesktop"
        PanelDesktop.Size = New Size(1194, 661)
        PanelDesktop.TabIndex = 4
        ' 
        ' MainMenu
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(41), CByte(41), CByte(41))
        ClientSize = New Size(1444, 881)
        Controls.Add(PanelDesktop)
        Controls.Add(Panel4)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        MinimumSize = New Size(1438, 858)
        Name = "MainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(icoCurrentWindow, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnMaximizeWindow As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCloseWindow As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimizeWindow As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAcceso As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTurnos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCaja As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInstructores As FontAwesome.Sharp.IconButton
    Friend WithEvents btnActividades As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSocios As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents lblCurrentWindow As Label
    Friend WithEvents icoCurrentWindow As FontAwesome.Sharp.IconPictureBox
End Class

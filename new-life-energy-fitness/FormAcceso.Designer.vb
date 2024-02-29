<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAcceso
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(455, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 41)
        Label1.TabIndex = 0
        Label1.Text = "CONTROL DE ACCESO"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(421, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 28)
        Label2.TabIndex = 1
        Label2.Text = "Nombre / ID :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(558, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(253, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(558, 148)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(253, 1)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1232, 80)
        Panel2.TabIndex = 4
        ' 
        ' FormAcceso
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = SystemColors.Control
        ClientSize = New Size(1232, 633)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Name = "FormAcceso"
        Text = "Acceso"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class

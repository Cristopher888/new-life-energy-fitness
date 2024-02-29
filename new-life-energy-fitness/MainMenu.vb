Imports FontAwesome.Sharp

Public Class MainMenu
    Private currentChildForm As Form

    Private Sub OpenChildForm(childForm As Form)
        ' Abrir un solo form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblCurrentWindow.Text = childForm.Text
    End Sub

    Private Sub btnAcceso_Click(sender As Object, e As EventArgs) Handles btnAcceso.Click
        OpenChildForm(New FormAcceso)
        icoCurrentWindow.IconChar = IconChar.Fingerprint
    End Sub

    Private Sub btnSocios_Click(sender As Object, e As EventArgs) Handles btnSocios.Click
        OpenChildForm(New FormSocios)
        icoCurrentWindow.IconChar = IconChar.Users
    End Sub

    Private Sub btnActividades_Click(sender As Object, e As EventArgs) Handles btnActividades.Click
        OpenChildForm(New FormActividades)
        icoCurrentWindow.IconChar = IconChar.Dumbbell
    End Sub

    Private Sub btnInstructores_Click(sender As Object, e As EventArgs) Handles btnInstructores.Click
        OpenChildForm(New FormInstructores)
        icoCurrentWindow.IconChar = IconChar.PeopleGroup
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        OpenChildForm(New FormUsuarios)
        icoCurrentWindow.IconChar = IconChar.UserCog
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
        OpenChildForm(New FormCaja)
        icoCurrentWindow.IconChar = IconChar.FileInvoiceDollar
    End Sub

    Private Sub btnTurnos_Click(sender As Object, e As EventArgs) Handles btnTurnos.Click
        OpenChildForm(New FormTurnos)
        icoCurrentWindow.IconChar = IconChar.ClockRotateLeft
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        OpenChildForm(New FormMas)
        icoCurrentWindow.IconChar = IconChar.Plus
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        icoCurrentWindow.IconChar = IconChar.Home
        lblCurrentWindow.Text = "Inicio"
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
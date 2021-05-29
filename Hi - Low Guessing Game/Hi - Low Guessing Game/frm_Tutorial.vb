Public Class frm_Tutorial

    Private Sub btn_Begin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Begin.Click
        'Opens the desired game mode when the radio button is checked and the button is clicked
        If rdo_HvH.Checked = True Then
            Me.Hide()
            frm_HvH.Visible = True
        ElseIf rdo_HvC.Checked = True Then
            Me.Hide()
            frm_HvC.Visible = True
        ElseIf rdo_CvH.Checked = True Then
            Me.Hide()
            frm_CvH.Visible = True
        ElseIf rdo_CvC.Checked = True Then
            Me.Hide()
            frm_CvC.Visible = True
        Else
            Me.Hide()
            frm_Menu.Visible = True
        End If
    End Sub
End Class
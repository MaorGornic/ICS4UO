Public Class frm_Menu

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        End 'Closes the program
    End Sub

    Private Sub btn_Start_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Start.Click
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
        End If
    End Sub

    Private Sub btn_Start2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start2.Click
        'Tells the users that this option is not available
        MessageBox.Show("Sorry about the inconvenience. This option is currently unavailable!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btn_Tutorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Tutorial.Click
        Me.Hide()
        frm_Tutorial.Visible = True
    End Sub
End Class
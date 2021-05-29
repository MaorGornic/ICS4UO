'Assignment 5 - Casino Craps
'By: Maor Gornik (ICS3U)
'Date: 26 of April, 2018

Public Class frm_InstructionsP4
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        'Hides the current form and goes one step back
        Me.Refresh()
        Me.Hide()
        frm_InstructionsP3.Visible = True
    End Sub

    Private Sub btn_Finish_Click_1(sender As Object, e As EventArgs) Handles btn_Finish.Click
        'Hides the current form, finishes the tutorial and opens the main menu
        Me.Refresh()
        Me.Hide()
        frm_MainMenu.Visible = True
    End Sub
End Class
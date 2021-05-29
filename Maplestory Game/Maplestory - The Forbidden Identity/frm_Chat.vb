'Final Performance Task - Maplestory: The Forbidden Identity
'By: Maor Gornik (ICS3U)
'Date: 20th of June, 2018

Public Class frm_Chat
    Private Sub lbl_Agree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Agree.Click
        'Determining whether the player has accepted the quest and closing the form
        isDeclined = False
        frm_Ellinia.tmr_Walk.Enabled = True
        Me.Hide()
    End Sub

    Private Sub lbl_Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl_Cancel.Click
        'Determining whether the player has declined the quest and closing the form
        frm_Ellinia.tmr_Walk.Enabled = True
        isDeclined = True
        Me.Hide()
    End Sub

    Private Sub frm_Chat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Changing the in-game cursor on form load
        Me.Cursor = New System.Windows.Forms.Cursor(Environment.CurrentDirectory + "/cursor.cur")
    End Sub
End Class
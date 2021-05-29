'Assignment 6 - Wheel of Hangman
'By: Maor Gornik (ICS3U)
'Date: 18th of May, 2018

Public Class frm_Main
    Dim input As String 'Creating a variable that will keep track of the entered text and later be modified
    Dim inputFull As String 'Creating a variable that will hold the entered text and will not be changed
    Dim inputLen As Integer 'Creating a variable that will keep track of the entered text's length
    Dim letter As String

    Private Sub btn_Apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Apply.Click
        'Setting up a button that will modify the entered text according to the user's choice
        input = txt_Input.Text

        If txt_Input.Text = Nothing And input = Nothing Then
            MessageBox.Show("Please enter a text", "String Replacement Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If rdo_Reverse.Checked = True Then
                input = StrReverse(input)
                lbl_Output.Text = input

            ElseIf rdo_Space.Checked = True Then
                input = input.Replace(" ", "")
                lbl_Output.Text = input

            ElseIf rdo_Vowels.Checked = True Then
                input = input.Replace("A", "")
                input = input.Replace("a", "")
                input = input.Replace("E", "")
                input = input.Replace("e", "")
                input = input.Replace("I", "")
                input = input.Replace("i", "")
                input = input.Replace("O", "")
                input = input.Replace("o", "")
                input = input.Replace("U", "")
                input = input.Replace("u", "")
                lbl_Output.Text = input

            ElseIf rdo_VowelsReplace.Checked = True Then
                input = input.Replace("A", "*")
                input = input.Replace("a", "*")
                input = input.Replace("E", "*")
                input = input.Replace("e", "*")
                input = input.Replace("I", "*")
                input = input.Replace("i", "*")
                input = input.Replace("O", "*")
                input = input.Replace("o", "*")
                input = input.Replace("U", "*")
                input = input.Replace("u", "*")
                lbl_Output.Text = input

            ElseIf rdo_Case.Checked = True Then
                inputFull = input
                inputLen = Len(inputFull)
                inputFull = UCase(Mid(inputFull, 2, inputLen))
                input = Mid(input, 1, 1)
                input = LCase(input)

                input = input + inputFull
                lbl_Output.Text = input
            End If
        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        'Setting up a button that will allow the user to save the modified text
        Try
            If ofd_File.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim streamWrite As System.IO.StreamWriter = New System.IO.StreamWriter(ofd_File.FileName, False)
                If input Is Nothing Then
                    MessageBox.Show("Please enter a text to be modified and then try again!", "String Replacement Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    streamWrite.WriteLine(input)
                    MessageBox.Show("Saved!", "String Replacement", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    streamWrite.Close()
                    txt_Input.Text = Nothing
                    lbl_Output.Text = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("This file is being used by another program. Close it and then try again!", "String Replacement Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        'Setting up a button that will allow the user to close the program
        Me.Close()
    End Sub

    Private Sub btn_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Load.Click
        'Setting up a button that will allow the user to load desired text to be modified
        Try
            If ofd_File.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim streamRead As System.IO.StreamReader = New System.IO.StreamReader(ofd_File.FileName)
                input = streamRead.ReadLine()
                If input Is Nothing Then
                    MessageBox.Show("No text was found!", "String Replacement Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    txt_Input.Text = input
                    streamRead.Close()
                    lbl_Output.Text = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("This file is being used by another program. Close it and then try again!", "String Replacement Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class

Public Class frmMain

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Dim Movielist As New IO.StreamReader(My.Application.Info.DirectoryPath & "\" & Me.txtFilename.Text)

        Dim Text As String

        Me.lstMovies.Items.Clear()

        Try
            Do
                Text = Movielist.ReadLine()
                If Text <> "" And Not Text.StartsWith("-") Then
                    Me.lstMovies.Items.Add(Text)
                End If
            Loop
        Catch
            Movielist.Close()
            btnRandom.Enabled = True
            btnLoad.Enabled = False
            Me.txtFilename.Enabled = False
        End Try

    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        Dim Max As Double = Me.lstMovies.Items.Count
        Dim r As New Random

        Dim RandomResult As Double = r.NextDouble * Max

        Try
            lstMovies.SelectedItem = lstMovies.Items(RandomResult)
        Catch
        End Try
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class

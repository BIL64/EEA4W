Public Class FrmRightPopup

    Private Sub FrmRightPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ingen åtgärd.
    End Sub

    Private Sub RpCopy_Click(sender As Object, e As EventArgs) Handles rpCopy.Click
        Form1.rtbARK.Copy()
        Me.Close()
    End Sub

    Private Sub RpCut_Click(sender As Object, e As EventArgs) Handles rpCut.Click
        Form1.rtbARK.Cut()
        Me.Close()
    End Sub

    Private Sub RpPaste_Click(sender As Object, e As EventArgs) Handles rpPaste.Click
        Form1.rtbARK.Paste()
        Me.Close()
    End Sub

    Private Sub RpDelete_Click(sender As Object, e As EventArgs) Handles rpDelete.Click
        Form1.rtbARK.SelectedText = ""
        Me.Close()
    End Sub

    Private Sub RpUndo_Click(sender As Object, e As EventArgs) Handles rpUndo.Click
        Form1.rtbARK.Undo()
        Me.Close()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Form1.rtbARK.SelectAll()
    End Sub

End Class
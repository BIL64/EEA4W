<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRightPopup
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
        components = New ComponentModel.Container()
        cmsRightPopup = New ContextMenuStrip(components)
        rpCopy = New ToolStripMenuItem()
        rpCut = New ToolStripMenuItem()
        rpPaste = New ToolStripMenuItem()
        rpDelete = New ToolStripMenuItem()
        rpUndo = New ToolStripMenuItem()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        DeselectToolStripMenuItem = New ToolStripMenuItem()
        cmsRightPopup.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmsRightPopup
        ' 
        cmsRightPopup.Items.AddRange(New ToolStripItem() {rpCopy, rpCut, rpPaste, rpDelete, rpUndo, SelectAllToolStripMenuItem, DeselectToolStripMenuItem})
        cmsRightPopup.Name = "ContextMenuStrip1"
        cmsRightPopup.Size = New Size(121, 158)
        ' 
        ' rpCopy
        ' 
        rpCopy.Name = "rpCopy"
        rpCopy.Size = New Size(120, 22)
        rpCopy.Text = "Copy"
        ' 
        ' rpCut
        ' 
        rpCut.Name = "rpCut"
        rpCut.Size = New Size(120, 22)
        rpCut.Text = "Cut"
        ' 
        ' rpPaste
        ' 
        rpPaste.Name = "rpPaste"
        rpPaste.Size = New Size(120, 22)
        rpPaste.Text = "Paste"
        ' 
        ' rpDelete
        ' 
        rpDelete.Name = "rpDelete"
        rpDelete.Size = New Size(120, 22)
        rpDelete.Text = "Delete"
        ' 
        ' rpUndo
        ' 
        rpUndo.Name = "rpUndo"
        rpUndo.Size = New Size(120, 22)
        rpUndo.Text = "Undo"
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(120, 22)
        SelectAllToolStripMenuItem.Text = "Select all"
        ' 
        ' DeselectToolStripMenuItem
        ' 
        DeselectToolStripMenuItem.Name = "DeselectToolStripMenuItem"
        DeselectToolStripMenuItem.Size = New Size(120, 22)
        DeselectToolStripMenuItem.Text = "Deselect"
        ' 
        ' FrmRightPopup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(181, 180)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmRightPopup"
        StartPosition = FormStartPosition.Manual
        Text = "FrmRightPopup"
        cmsRightPopup.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmsRightPopup As ContextMenuStrip
    Friend WithEvents rpCopy As ToolStripMenuItem
    Friend WithEvents rpCut As ToolStripMenuItem
    Friend WithEvents rpPaste As ToolStripMenuItem
    Friend WithEvents rpDelete As ToolStripMenuItem
    Friend WithEvents rpUndo As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeselectToolStripMenuItem As ToolStripMenuItem
End Class

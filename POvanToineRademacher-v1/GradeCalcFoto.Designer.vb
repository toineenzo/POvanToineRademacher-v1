<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeCalcFoto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradeCalcFoto))
        Me.PictureGradeSystem = New System.Windows.Forms.PictureBox()
        CType(Me.PictureGradeSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureGradeSystem
        '
        Me.PictureGradeSystem.AccessibleName = ""
        Me.PictureGradeSystem.Image = CType(resources.GetObject("PictureGradeSystem.Image"), System.Drawing.Image)
        Me.PictureGradeSystem.Location = New System.Drawing.Point(0, 0)
        Me.PictureGradeSystem.Name = "PictureGradeSystem"
        Me.PictureGradeSystem.Size = New System.Drawing.Size(195, 203)
        Me.PictureGradeSystem.TabIndex = 0
        Me.PictureGradeSystem.TabStop = False
        '
        'GradeCalcFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(198, 202)
        Me.Controls.Add(Me.PictureGradeSystem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GradeCalcFoto"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Grade System Tabel"
        Me.TopMost = True
        CType(Me.PictureGradeSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureGradeSystem As PictureBox
End Class

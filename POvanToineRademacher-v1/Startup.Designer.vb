<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Startup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.btnProblem1 = New System.Windows.Forms.Button()
        Me.btnProblem2 = New System.Windows.Forms.Button()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoading.AutoSize = True
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Font = New System.Drawing.Font("Alfphabet", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.Lime
        Me.lblLoading.Location = New System.Drawing.Point(43, 24)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(413, 76)
        Me.lblLoading.TabIndex = 0
        Me.lblLoading.Text = "Loading..."
        '
        'btnProblem1
        '
        Me.btnProblem1.Location = New System.Drawing.Point(318, 114)
        Me.btnProblem1.Name = "btnProblem1"
        Me.btnProblem1.Size = New System.Drawing.Size(55, 23)
        Me.btnProblem1.TabIndex = 1
        Me.btnProblem1.Text = "Option 1"
        Me.btnProblem1.UseVisualStyleBackColor = True
        '
        'btnProblem2
        '
        Me.btnProblem2.Location = New System.Drawing.Point(377, 114)
        Me.btnProblem2.Name = "btnProblem2"
        Me.btnProblem2.Size = New System.Drawing.Size(55, 23)
        Me.btnProblem2.TabIndex = 2
        Me.btnProblem2.Text = "Option 2"
        Me.btnProblem2.UseVisualStyleBackColor = True
        '
        'lblProblem
        '
        Me.lblProblem.AutoSize = True
        Me.lblProblem.Location = New System.Drawing.Point(315, 98)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(120, 13)
        Me.lblProblem.TabIndex = 3
        Me.lblProblem.Text = "Not loading? Click here!"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(56, 114)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(49, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(142, 120)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(91, 13)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Version Unknown"
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(503, 166)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblProblem)
        Me.Controls.Add(Me.btnProblem2)
        Me.Controls.Add(Me.btnProblem1)
        Me.Controls.Add(Me.lblLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Startup"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Startup"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Lime
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoading As Label
    Friend WithEvents btnProblem1 As Button
    Friend WithEvents btnProblem2 As Button
    Friend WithEvents lblProblem As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblVersion As Label
End Class

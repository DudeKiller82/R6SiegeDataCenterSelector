<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R6SiegeDataCenterSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R6SiegeDataCenterSelector))
        Me.ChangeDataCenterButton = New System.Windows.Forms.Button()
        Me.DataCenterComboBox = New System.Windows.Forms.ComboBox()
        Me.CurrentDataCenterLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ChangeDataCenterButton
        '
        Me.ChangeDataCenterButton.Location = New System.Drawing.Point(12, 52)
        Me.ChangeDataCenterButton.Name = "ChangeDataCenterButton"
        Me.ChangeDataCenterButton.Size = New System.Drawing.Size(232, 36)
        Me.ChangeDataCenterButton.TabIndex = 0
        Me.ChangeDataCenterButton.Text = "Change Data Center"
        Me.ChangeDataCenterButton.UseVisualStyleBackColor = True
        '
        'DataCenterComboBox
        '
        Me.DataCenterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DataCenterComboBox.FormattingEnabled = True
        Me.DataCenterComboBox.Location = New System.Drawing.Point(12, 25)
        Me.DataCenterComboBox.Name = "DataCenterComboBox"
        Me.DataCenterComboBox.Size = New System.Drawing.Size(232, 21)
        Me.DataCenterComboBox.TabIndex = 1
        '
        'CurrentDataCenterLabel
        '
        Me.CurrentDataCenterLabel.AutoSize = True
        Me.CurrentDataCenterLabel.Location = New System.Drawing.Point(12, 9)
        Me.CurrentDataCenterLabel.Name = "CurrentDataCenterLabel"
        Me.CurrentDataCenterLabel.Size = New System.Drawing.Size(104, 13)
        Me.CurrentDataCenterLabel.TabIndex = 2
        Me.CurrentDataCenterLabel.Text = "Current Data Center:"
        '
        'R6SiegeDataCenterSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 96)
        Me.Controls.Add(Me.CurrentDataCenterLabel)
        Me.Controls.Add(Me.DataCenterComboBox)
        Me.Controls.Add(Me.ChangeDataCenterButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "R6SiegeDataCenterSelector"
        Me.Text = "R6 Data Center Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChangeDataCenterButton As System.Windows.Forms.Button
    Friend WithEvents DataCenterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CurrentDataCenterLabel As System.Windows.Forms.Label

End Class

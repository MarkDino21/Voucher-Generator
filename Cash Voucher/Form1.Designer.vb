<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblSetting = New System.Windows.Forms.Label()
        Me.lblRMMC = New System.Windows.Forms.Label()
        Me.lblRDC = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 44)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Update Supplier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(260, 44)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Cash Voucher"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 219)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 64)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(260, 44)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Check Voucher"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblSetting
        '
        Me.lblSetting.AutoSize = True
        Me.lblSetting.BackColor = System.Drawing.Color.Transparent
        Me.lblSetting.Location = New System.Drawing.Point(270, -1)
        Me.lblSetting.Name = "lblSetting"
        Me.lblSetting.Size = New System.Drawing.Size(40, 13)
        Me.lblSetting.TabIndex = 1
        Me.lblSetting.Text = "Setting"
        '
        'lblRMMC
        '
        Me.lblRMMC.AutoSize = True
        Me.lblRMMC.BackColor = System.Drawing.Color.Transparent
        Me.lblRMMC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRMMC.Location = New System.Drawing.Point(0, 2)
        Me.lblRMMC.Name = "lblRMMC"
        Me.lblRMMC.Size = New System.Drawing.Size(40, 13)
        Me.lblRMMC.TabIndex = 2
        Me.lblRMMC.Text = "RMMC"
        '
        'lblRDC
        '
        Me.lblRDC.AutoSize = True
        Me.lblRDC.BackColor = System.Drawing.Color.Transparent
        Me.lblRDC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRDC.Location = New System.Drawing.Point(46, 2)
        Me.lblRDC.Name = "lblRDC"
        Me.lblRDC.Size = New System.Drawing.Size(30, 13)
        Me.lblRDC.TabIndex = 2
        Me.lblRDC.Text = "RDC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cash_Voucher.My.Resources.Resources.cash_voucher_rm
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(313, 248)
        Me.Controls.Add(Me.lblRDC)
        Me.Controls.Add(Me.lblRMMC)
        Me.Controls.Add(Me.lblSetting)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(329, 287)
        Me.MinimumSize = New System.Drawing.Size(329, 247)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Voucher"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSetting As System.Windows.Forms.Label
    Friend WithEvents lblRMMC As Label
    Friend WithEvents lblRDC As Label
    Friend WithEvents Button4 As Button
End Class

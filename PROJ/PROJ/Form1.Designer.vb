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
        Me.btnUploadPic = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicLand = New System.Windows.Forms.PictureBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnGrass = New System.Windows.Forms.Button()
        Me.btnSoil = New System.Windows.Forms.Button()
        Me.txtLengthScale = New System.Windows.Forms.TextBox()
        Me.btnUploadScale = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.PicScale = New System.Windows.Forms.PictureBox()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.txtGrass = New System.Windows.Forms.TextBox()
        Me.txtSoil = New System.Windows.Forms.TextBox()
        Me.txtUnknown = New System.Windows.Forms.TextBox()
        Me.grpScaleFactor = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpArea = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShowChart = New System.Windows.Forms.Button()
        Me.btnshoworig = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        CType(Me.PicLand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpScaleFactor.SuspendLayout()
        Me.grpArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUploadPic
        '
        Me.btnUploadPic.Location = New System.Drawing.Point(12, 12)
        Me.btnUploadPic.Name = "btnUploadPic"
        Me.btnUploadPic.Size = New System.Drawing.Size(132, 22)
        Me.btnUploadPic.TabIndex = 0
        Me.btnUploadPic.Text = "Upload Picture"
        Me.btnUploadPic.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PicLand
        '
        Me.PicLand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PicLand.Location = New System.Drawing.Point(0, 192)
        Me.PicLand.Name = "PicLand"
        Me.PicLand.Size = New System.Drawing.Size(537, 279)
        Me.PicLand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicLand.TabIndex = 1
        Me.PicLand.TabStop = False
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(12, 40)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(132, 22)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "Process Picture"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnGrass
        '
        Me.btnGrass.Location = New System.Drawing.Point(260, 12)
        Me.btnGrass.Name = "btnGrass"
        Me.btnGrass.Size = New System.Drawing.Size(86, 50)
        Me.btnGrass.TabIndex = 3
        Me.btnGrass.Text = "Highlight Grass"
        Me.btnGrass.UseVisualStyleBackColor = True
        '
        'btnSoil
        '
        Me.btnSoil.Location = New System.Drawing.Point(352, 12)
        Me.btnSoil.Name = "btnSoil"
        Me.btnSoil.Size = New System.Drawing.Size(86, 50)
        Me.btnSoil.TabIndex = 4
        Me.btnSoil.Text = "Highlight Soil"
        Me.btnSoil.UseVisualStyleBackColor = True
        '
        'txtLengthScale
        '
        Me.txtLengthScale.Location = New System.Drawing.Point(113, 42)
        Me.txtLengthScale.Name = "txtLengthScale"
        Me.txtLengthScale.Size = New System.Drawing.Size(62, 20)
        Me.txtLengthScale.TabIndex = 5
        '
        'btnUploadScale
        '
        Me.btnUploadScale.Location = New System.Drawing.Point(6, 13)
        Me.btnUploadScale.Name = "btnUploadScale"
        Me.btnUploadScale.Size = New System.Drawing.Size(169, 23)
        Me.btnUploadScale.TabIndex = 6
        Me.btnUploadScale.Text = "Upload Scale"
        Me.btnUploadScale.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'PicScale
        '
        Me.PicScale.Location = New System.Drawing.Point(6, 68)
        Me.PicScale.Name = "PicScale"
        Me.PicScale.Size = New System.Drawing.Size(169, 44)
        Me.PicScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicScale.TabIndex = 7
        Me.PicScale.TabStop = False
        '
        'btnArea
        '
        Me.btnArea.Location = New System.Drawing.Point(6, 13)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(254, 23)
        Me.btnArea.TabIndex = 8
        Me.btnArea.Text = "Compute Land Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'txtGrass
        '
        Me.txtGrass.Location = New System.Drawing.Point(162, 45)
        Me.txtGrass.Name = "txtGrass"
        Me.txtGrass.Size = New System.Drawing.Size(98, 20)
        Me.txtGrass.TabIndex = 9
        '
        'txtSoil
        '
        Me.txtSoil.Location = New System.Drawing.Point(162, 68)
        Me.txtSoil.Name = "txtSoil"
        Me.txtSoil.Size = New System.Drawing.Size(98, 20)
        Me.txtSoil.TabIndex = 10
        '
        'txtUnknown
        '
        Me.txtUnknown.Location = New System.Drawing.Point(162, 92)
        Me.txtUnknown.Name = "txtUnknown"
        Me.txtUnknown.Size = New System.Drawing.Size(98, 20)
        Me.txtUnknown.TabIndex = 11
        '
        'grpScaleFactor
        '
        Me.grpScaleFactor.Controls.Add(Me.Label1)
        Me.grpScaleFactor.Controls.Add(Me.PicScale)
        Me.grpScaleFactor.Controls.Add(Me.btnUploadScale)
        Me.grpScaleFactor.Controls.Add(Me.txtLengthScale)
        Me.grpScaleFactor.Location = New System.Drawing.Point(12, 68)
        Me.grpScaleFactor.Name = "grpScaleFactor"
        Me.grpScaleFactor.Size = New System.Drawing.Size(181, 118)
        Me.grpScaleFactor.TabIndex = 12
        Me.grpScaleFactor.TabStop = False
        Me.grpScaleFactor.Text = "Scale Factor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Length of Scale (m):"
        '
        'grpArea
        '
        Me.grpArea.Controls.Add(Me.Label4)
        Me.grpArea.Controls.Add(Me.Label3)
        Me.grpArea.Controls.Add(Me.Label2)
        Me.grpArea.Controls.Add(Me.txtUnknown)
        Me.grpArea.Controls.Add(Me.txtSoil)
        Me.grpArea.Controls.Add(Me.txtGrass)
        Me.grpArea.Controls.Add(Me.btnArea)
        Me.grpArea.Location = New System.Drawing.Point(199, 68)
        Me.grpArea.Name = "grpArea"
        Me.grpArea.Size = New System.Drawing.Size(266, 118)
        Me.grpArea.TabIndex = 13
        Me.grpArea.TabStop = False
        Me.grpArea.Text = "Metric Land Area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Unknown Materials, sq. meter:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Dry Soil, sq. meter:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Grasslands, sq. meter:"
        '
        'btnShowChart
        '
        Me.btnShowChart.Location = New System.Drawing.Point(150, 12)
        Me.btnShowChart.Name = "btnShowChart"
        Me.btnShowChart.Size = New System.Drawing.Size(104, 50)
        Me.btnShowChart.TabIndex = 14
        Me.btnShowChart.Text = "Show Chart"
        Me.btnShowChart.UseVisualStyleBackColor = True
        '
        'btnshoworig
        '
        Me.btnshoworig.Location = New System.Drawing.Point(444, 12)
        Me.btnshoworig.Name = "btnshoworig"
        Me.btnshoworig.Size = New System.Drawing.Size(86, 50)
        Me.btnshoworig.TabIndex = 15
        Me.btnshoworig.Text = "Show Original Picture"
        Me.btnshoworig.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(471, 68)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(59, 118)
        Me.btnreset.TabIndex = 16
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 471)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnshoworig)
        Me.Controls.Add(Me.btnShowChart)
        Me.Controls.Add(Me.grpArea)
        Me.Controls.Add(Me.grpScaleFactor)
        Me.Controls.Add(Me.btnSoil)
        Me.Controls.Add(Me.btnGrass)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.PicLand)
        Me.Controls.Add(Me.btnUploadPic)
        Me.Name = "Form1"
        Me.Text = "Farmland Composition Analyzer"
        CType(Me.PicLand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpScaleFactor.ResumeLayout(False)
        Me.grpScaleFactor.PerformLayout()
        Me.grpArea.ResumeLayout(False)
        Me.grpArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUploadPic As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PicLand As System.Windows.Forms.PictureBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnGrass As System.Windows.Forms.Button
    Friend WithEvents btnSoil As System.Windows.Forms.Button
    Friend WithEvents txtLengthScale As System.Windows.Forms.TextBox
    Friend WithEvents btnUploadScale As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PicScale As System.Windows.Forms.PictureBox
    Friend WithEvents txtGrass As System.Windows.Forms.TextBox
    Friend WithEvents txtSoil As System.Windows.Forms.TextBox
    Friend WithEvents txtUnknown As System.Windows.Forms.TextBox
    Friend WithEvents grpScaleFactor As System.Windows.Forms.GroupBox
    Friend WithEvents grpArea As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowChart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnArea As System.Windows.Forms.Button
    Friend WithEvents btnshoworig As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button

End Class

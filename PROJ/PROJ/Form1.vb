Public Class Form1
    Dim bitmap2 As Bitmap
    Dim bitmap As Bitmap
    Dim grassbit As Bitmap
    Dim soilbit As Bitmap
    Dim scalefactor As Double
    Dim pixelscale As Integer
    Dim GrassCheck As Integer
    Dim Soilcheck As Integer
    Dim unknownpixelarea As Integer
    Dim grasspixelarea As Integer
    Dim soilpixelarea As Integer

    Private Sub btnUploadPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadPic.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            reset()
            PicLand.Image = Image.FromFile(OpenFileDialog1.FileName)
            btnProcess.Enabled = True
            btnGrass.Enabled = False
            btnSoil.Enabled = False
            btnArea.Enabled = False
            btnShowChart.Enabled = False
            btnUploadScale.Enabled = False
            btnshoworig.Enabled = False
        End If
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        bitmap = Image.FromFile(OpenFileDialog1.FileName)
        Dim Red As Integer
        Dim Green As Integer
        Dim Blue As Integer
        grassbit = New Bitmap(bitmap.Width, bitmap.Height)
        soilbit = New Bitmap(bitmap.Width, bitmap.Height)
        Dim grayscalegreen As Integer
        For x As Integer = 0 To bitmap.Width - 1
            For y As Integer = 0 To bitmap.Height - 1
                Red = bitmap.GetPixel(x, y).R
                Green = bitmap.GetPixel(x, y).G
                Blue = bitmap.GetPixel(x, y).B
                'MessageBox.Show(Red & "," & Green & "," & Blue)
                If Green > 45 Then
                    If Math.Abs(Red - Blue) > 15 Then
                        grayscalegreen = 0
                    ElseIf (Green - 20) > Red > (Green + 20) Then
                        grayscalegreen = 0
                    ElseIf (Green - 20) > Blue > (Green + 20) Then
                        grayscalegreen = 0
                        'ElseIf Blue > 80 And Red > 80 Then
                        '    grayscalegreen = 0
                    ElseIf Blue > Green Or Red > Green Then
                        grayscalegreen = 0
                    Else
                        grayscalegreen = 255
                    End If
                Else
                    grayscalegreen = 0
                End If
                Dim grayscale As Color = Color.FromArgb(grayscalegreen, grayscalegreen, grayscalegreen)
                grassbit.SetPixel(x, y, grayscale)
            Next
        Next

        Dim grayscalebrown As Integer
        For x As Integer = 0 To bitmap.Width - 1
            For y As Integer = 0 To bitmap.Height - 1
                Red = bitmap.GetPixel(x, y).R
                Green = bitmap.GetPixel(x, y).G
                Blue = bitmap.GetPixel(x, y).B
                'MessageBox.Show(Red & "," & Green & "," & Blue)
                If Math.Abs(Green - Red) < 20 And Math.Abs(Green - Blue) < 20 Then
                    If Red > 150 And Green > 150 And Blue > 150 Then
                        grayscalebrown = 0
                    ElseIf Green >= Red Or Blue >= Red Then
                        grayscalebrown = 0
                    ElseIf Math.Abs(Red - Green) < 5 Or Math.Abs(Red - Blue) < 5 Then
                        grayscalebrown = 0
                    Else
                        grayscalebrown = 255
                    End If
                Else
                    grayscalebrown = 0
                End If
                Dim grayscale As Color = Color.FromArgb(grayscalebrown, grayscalebrown, grayscalebrown)
                soilbit.SetPixel(x, y, grayscale)
            Next
        Next

        'Dilation - Image Enhancing
        For smoothloop As Integer = 0 To 2
            For x As Integer = 1 To grassbit.Width - 2
                For y As Integer = 1 To grassbit.Height - 2
                    Dim grassgrade As Integer = 0
                    Dim soilgrade As Integer = 0
                    If grassbit.GetPixel(x - 1, y).R = 255 Then
                        grassgrade += 1
                    End If
                    If grassbit.GetPixel(x, y + 1).R = 255 Then
                        grassgrade += 1
                    End If
                    If grassbit.GetPixel(x, y - 1).R = 255 Then
                        grassgrade += 1
                    End If
                    If grassbit.GetPixel(x + 1, y).R = 255 Then
                        grassgrade += 1
                    End If
                    If grassbit.GetPixel(x - 1, y).R = 255 Then
                        soilgrade += 1
                    End If
                    If soilbit.GetPixel(x, y + 1).R = 255 Then
                        soilgrade += 1
                    End If
                    If soilbit.GetPixel(x, y - 1).R = 255 Then
                        soilgrade += 1
                    End If
                    If soilbit.GetPixel(x + 1, y).R = 255 Then
                        soilgrade += 1
                    End If

                    If grassgrade > 2 Then
                        grassbit.SetPixel(x, y, Color.FromArgb(255, 255, 255))
                    End If
                    If soilgrade > 2 Then
                        soilbit.SetPixel(x, y, Color.FromArgb(255, 255, 255))
                    End If
                Next
            Next
            smoothloop += 1
        Next

        For x As Integer = 0 To bitmap.Width - 1
            For y As Integer = 0 To bitmap.Height - 1
                GrassCheck = grassbit.GetPixel(x, y).R
                Soilcheck = soilbit.GetPixel(x, y).R
                If GrassCheck = 255 Then
                    grasspixelarea += 1
                End If
                If Soilcheck = 255 Then
                    soilpixelarea += 1
                End If
                If GrassCheck = 0 And Soilcheck = 0 Then
                    unknownpixelarea += 1
                End If
            Next
        Next

        btnProcess.Enabled = False
        btnGrass.Enabled = True
        btnSoil.Enabled = True
        btnShowChart.Enabled = True
        btnArea.Enabled = False
        btnUploadScale.Enabled = True
        btnshoworig.Enabled = True
        txtLengthScale.Enabled = True
    End Sub

    Private Sub btnGrass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrass.Click
        PicLand.Image = grassbit
    End Sub

    Private Sub btnSoil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoil.Click
        PicLand.Image = soilbit
    End Sub

    Private Sub btnUploadScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadScale.Click
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            PicScale.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
        Dim pixelcount As Integer = 0
        For y As Integer = 0 To PicScale.Image.Height - 1
            For x As Integer = 0 To PicScale.Image.Width - 1
                Dim scalebitmap As Bitmap = PicScale.Image
                If scalebitmap.GetPixel(x, y).R > 100 Then
                    pixelcount += 1
                End If
            Next
            If pixelcount > pixelscale Then
                pixelscale = pixelcount
            End If
            pixelcount = 0
        Next
        btnArea.Enabled = True
    End Sub

    Public Sub btnArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArea.Click
        If IsNumeric(txtLengthScale.Text) Then
            scalefactor = ((CDbl(txtLengthScale.Text)) / pixelscale) ^ 2
            Dim unknownmetricarea As Double
            Dim grassmetricarea As Double
            Dim soilmetricarea As Double

            grassmetricarea = scalefactor * grasspixelarea
            soilmetricarea = scalefactor * soilpixelarea
            unknownmetricarea = scalefactor * unknownpixelarea
            txtGrass.Text = Math.Round(grassmetricarea, 2)
            txtSoil.Text = Math.Round(soilmetricarea, 2)
            txtUnknown.Text = Math.Round(unknownmetricarea, 2)
        Else
            MessageBox.Show("Invalid scale input.")
        End If
    End Sub

    Public Sub btnShowChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowChart.Click
        Dim totalpixelarea As Integer = grasspixelarea + soilpixelarea + unknownpixelarea
        Dim grassArea As Double = grasspixelarea / totalpixelarea
        Dim soilArea As Double = soilpixelarea / totalpixelarea
        Dim unknownArea As Double = unknownpixelarea / totalpixelarea
        frmPieChart.Chart1.Series("Land Areas").Points.AddXY("Grass Land", grassArea)
        frmPieChart.Chart1.Series("Land Areas").Points.AddXY("Dry Soil", soilArea)
        frmPieChart.Chart1.Series("Land Areas").Points.AddXY("Unknown Materials", unknownArea)
        frmPieChart.Chart1.Series("Land Areas").IsValueShownAsLabel = True
        frmPieChart.Chart1.Series("Land Areas").LabelFormat = "0.00%"

        frmPieChart.Chart1.Titles.Add("Land Composition in Percentage")
        frmPieChart.Show()
    End Sub
    
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
    End Sub

    Sub reset()
        btnProcess.Enabled = False
        btnGrass.Enabled = False
        btnSoil.Enabled = False
        btnShowChart.Enabled = False
        btnArea.Enabled = False
        btnUploadScale.Enabled = False
        btnshoworig.Enabled = False
        PicLand.Image = Nothing
        PicScale.Image = Nothing
        txtGrass.Text = Nothing
        txtLengthScale.Text = Nothing
        txtSoil.Text = Nothing
        txtUnknown.Text = Nothing
        txtLengthScale.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnProcess.Enabled = False
        btnGrass.Enabled = False
        btnSoil.Enabled = False
        btnShowChart.Enabled = False
        btnArea.Enabled = False
        btnUploadScale.Enabled = False
        btnshoworig.Enabled = False
        PicLand.Image = Nothing
        PicScale.Image = Nothing
        txtGrass.Text = Nothing
        txtLengthScale.Text = Nothing
        txtSoil.Text = Nothing
        txtUnknown.Text = Nothing
        txtLengthScale.Enabled = False
    End Sub

    Private Sub btnshoworig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshoworig.Click
        PicLand.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub txtLengthScale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLengthScale.KeyPress
        Dim keypress As String = e.KeyChar
        If IsNumeric(keypress) = True Or keypress = "." Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub
End Class

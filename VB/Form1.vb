Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace ImageSlider
	Public Partial Class Form1
		Inherits Form
		Private currentImageIndex As Integer = 0
		Private images As Image()

		Public Sub New()
			Me.images = CreateImages()
			InitializeComponent()
		End Sub

		Private Function CreateImages() As Image()
			Return New Image(){ CreateImage(Color.Red), CreateImage(Color.Green), CreateImage(Color.Blue) }
		End Function

		Private Function CreateImage(ByVal color As Color) As Image
			Dim bitmap As Bitmap = New Bitmap(100, 100)
			Dim i As Integer = 0
			Do While i < bitmap.Width
				Dim j As Integer = 0
				Do While j < bitmap.Height
					bitmap.SetPixel(i, j, color)
					j += 1
				Loop
				i += 1
			Loop
			Return bitmap
		End Function

		Private Sub imageSlider1_CanGetNextPrevImage(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CanGetNextPrevImageEventArgs) Handles imageSlider1.CanGetNextPrevImage
			If e.IsNext Then
			e.CanGetImage = (currentImageIndex < images.Length - 1)
			Else
				e.CanGetImage = (currentImageIndex > 0)
			End If
		End Sub

		Private Sub imageSlider1_GetImage(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.GetImageEventArgs) Handles imageSlider1.GetImage
			If e.IsStartUp Then
				e.Image = images(0)
				Return
			End If
			If e.IsNext Then
				e.Image = images(currentImageIndex + 1)
				If e.CurrentImageUpdated Then
				currentImageIndex += 1
				End If
			ElseIf e.IsPrev Then
				e.Image = images(currentImageIndex - 1)
				If e.CurrentImageUpdated Then
				currentImageIndex -= 1
				End If
			End If
		End Sub
	End Class
End Namespace

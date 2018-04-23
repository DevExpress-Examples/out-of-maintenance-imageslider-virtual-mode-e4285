Imports Microsoft.VisualBasic
Imports System
Namespace ImageSlider
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.imageSlider1 = New DevExpress.XtraEditors.Controls.ImageSlider()
			CType(Me.imageSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageSlider1
			' 
			Me.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
			Me.imageSlider1.Location = New System.Drawing.Point(0, 0)
			Me.imageSlider1.Name = "imageSlider1"
			Me.imageSlider1.Size = New System.Drawing.Size(497, 263)
			Me.imageSlider1.TabIndex = 0
			Me.imageSlider1.Text = "imageSlider1"
			Me.imageSlider1.VirtualMode = True
'			Me.imageSlider1.GetImage += New System.EventHandler(Of DevExpress.XtraEditors.Controls.GetImageEventArgs)(Me.imageSlider1_GetImage);
'			Me.imageSlider1.CanGetNextPrevImage += New System.EventHandler(Of DevExpress.XtraEditors.Controls.CanGetNextPrevImageEventArgs)(Me.imageSlider1_CanGetNextPrevImage);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(497, 263)
			Me.Controls.Add(Me.imageSlider1)
			Me.Name = "Form1"
			Me.Text = "ImageSlider Virtual Mode"
			CType(Me.imageSlider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents imageSlider1 As DevExpress.XtraEditors.Controls.ImageSlider
	End Class
End Namespace


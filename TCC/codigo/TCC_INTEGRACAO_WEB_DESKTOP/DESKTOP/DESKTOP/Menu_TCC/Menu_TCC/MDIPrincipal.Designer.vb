<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIPrincipal))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctImagem0 = New System.Windows.Forms.PictureBox()
        CType(Me.pctImagem0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "artigos0.PNG")
        Me.ImageList1.Images.SetKeyName(1, "artigos2.PNG")
        Me.ImageList1.Images.SetKeyName(2, "artigos_0.PNG")
        '
        'pctImagem0
        '
        Me.pctImagem0.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pctImagem0.Image = CType(resources.GetObject("pctImagem0.Image"), System.Drawing.Image)
        Me.pctImagem0.InitialImage = CType(resources.GetObject("pctImagem0.InitialImage"), System.Drawing.Image)
        Me.pctImagem0.Location = New System.Drawing.Point(3, 4)
        Me.pctImagem0.Name = "pctImagem0"
        Me.pctImagem0.Size = New System.Drawing.Size(145, 139)
        Me.pctImagem0.TabIndex = 11
        Me.pctImagem0.TabStop = False
        '
        'MDIPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1014, 550)
        Me.Controls.Add(Me.pctImagem0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "MDIPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pctImagem0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pctImagem0 As System.Windows.Forms.PictureBox

End Class

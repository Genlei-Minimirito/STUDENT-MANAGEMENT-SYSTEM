<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        txtUname = New TextBox()
        txtPword = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtUname
        ' 
        txtUname.BackColor = SystemColors.Window
        txtUname.Location = New Point(40, 138)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(239, 23)
        txtUname.TabIndex = 0
        ' 
        ' txtPword
        ' 
        txtPword.BackColor = SystemColors.Window
        txtPword.Location = New Point(40, 200)
        txtPword.Name = "txtPword"
        txtPword.Size = New Size(239, 23)
        txtPword.TabIndex = 1
        txtPword.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(60, 255)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 27)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmLogIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 379)
        Controls.Add(Button1)
        Controls.Add(txtPword)
        Controls.Add(txtUname)
        DoubleBuffered = True
        Name = "frmLogIn"
        Text = "frmLogIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUname As TextBox
    Friend WithEvents txtPword As TextBox
    Friend WithEvents Button1 As Button
End Class

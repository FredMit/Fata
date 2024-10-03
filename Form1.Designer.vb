<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblName = New Label()
        txtName = New TextBox()
        lblAge = New Label()
        lblFavcolor = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btn = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(126, 73)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(185, 73)
        txtName.Name = "txtName"
        txtName.Size = New Size(196, 23)
        txtName.TabIndex = 1
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(126, 156)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(28, 15)
        lblAge.TabIndex = 2
        lblAge.Text = "Age"
        ' 
        ' lblFavcolor
        ' 
        lblFavcolor.AutoSize = True
        lblFavcolor.Location = New Point(124, 240)
        lblFavcolor.Name = "lblFavcolor"
        lblFavcolor.Size = New Size(81, 15)
        lblFavcolor.TabIndex = 3
        lblFavcolor.Text = "favouritecolor"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(185, 153)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(196, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(211, 240)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(270, 23)
        TextBox2.TabIndex = 5
        ' 
        ' btn
        ' 
        btn.Location = New Point(373, 336)
        btn.Name = "btn"
        btn.Size = New Size(75, 23)
        btn.TabIndex = 6
        btn.Text = "Show"
        btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(lblFavcolor)
        Controls.Add(lblAge)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblFavcolor As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn As Button

End Class

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
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(182, 107)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(142, 20)
        Me.txt_usuario.TabIndex = 0
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(29, 32)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 182)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 1
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaLabel1.Location = New System.Drawing.Point(217, 32)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(77, 27)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "LOGIN"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(202, 74)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(103, 15)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Ingrese su Usuario"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(191, 148)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(123, 15)
        Me.GunaLabel3.TabIndex = 4
        Me.GunaLabel3.Text = "Ingrese su Contraseña"
        '
        'txt_contra
        '
        Me.txt_contra.Location = New System.Drawing.Point(182, 181)
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.Size = New System.Drawing.Size(142, 20)
        Me.txt_contra.TabIndex = 5
        '
        'btn_iniciar
        '
        Me.btn_iniciar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_iniciar.Location = New System.Drawing.Point(171, 252)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_iniciar.TabIndex = 6
        Me.btn_iniciar.Text = "INICIAR"
        Me.btn_iniciar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(405, 309)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.txt_contra)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.txt_usuario)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents btn_iniciar As Button
End Class

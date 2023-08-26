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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        LDni = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LModificar = New Label()
        LNya = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        TGuardar = New Button()
        TEliminar = New Button()
        Panel1 = New Panel()
        TBTelefono = New TextBox()
        LTelefono = New Label()
        Label1 = New Label()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        BSalir = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(10, 53)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 0
        LDni.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(10, 127)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 1
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(10, 89)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 2
        LApellido.Text = "Apellido"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(135, 16)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 3
        LModificar.Text = "modificar"
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(10, 16)
        LNya.Name = "LNya"
        LNya.Size = New Size(110, 15)
        LNya.TabIndex = 4
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(103, 45)
        TDni.Name = "TDni"
        TDni.Size = New Size(122, 23)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(103, 81)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(122, 23)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(103, 124)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(122, 23)
        TNombre.TabIndex = 7
        ' 
        ' TGuardar
        ' 
        TGuardar.BackColor = SystemColors.ButtonHighlight
        TGuardar.Image = CType(resources.GetObject("TGuardar.Image"), Image)
        TGuardar.ImageAlign = ContentAlignment.MiddleLeft
        TGuardar.Location = New Point(25, 384)
        TGuardar.Name = "TGuardar"
        TGuardar.Size = New Size(120, 42)
        TGuardar.TabIndex = 8
        TGuardar.Text = "Guardar"
        TGuardar.UseVisualStyleBackColor = False
        ' 
        ' TEliminar
        ' 
        TEliminar.BackColor = SystemColors.ButtonHighlight
        TEliminar.Image = CType(resources.GetObject("TEliminar.Image"), Image)
        TEliminar.ImageAlign = ContentAlignment.MiddleRight
        TEliminar.Location = New Point(167, 384)
        TEliminar.Name = "TEliminar"
        TEliminar.RightToLeft = RightToLeft.Yes
        TEliminar.Size = New Size(126, 42)
        TEliminar.TabIndex = 9
        TEliminar.Text = "Eliminar"
        TEliminar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(TBTelefono)
        Panel1.Controls.Add(LTelefono)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(TDni)
        Panel1.Controls.Add(LNya)
        Panel1.Controls.Add(LModificar)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(LDni)
        Panel1.Location = New Point(15, 7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(260, 355)
        Panel1.TabIndex = 10
        ' 
        ' TBTelefono
        ' 
        TBTelefono.Location = New Point(103, 173)
        TBTelefono.Name = "TBTelefono"
        TBTelefono.Size = New Size(122, 23)
        TBTelefono.TabIndex = 15
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Location = New Point(10, 179)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(52, 15)
        LTelefono.TabIndex = 14
        LTelefono.Text = "Telefono"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 15)
        Label1.TabIndex = 13
        Label1.Text = "Tarjeta de creditos:"
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(121, 315)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 19)
        CheckBox3.TabIndex = 12
        CheckBox3.Text = "Mastercard"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(121, 290)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(47, 19)
        CheckBox2.TabIndex = 11
        CheckBox2.Text = "Visa"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(121, 265)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Naranja"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.Location = New Point(335, 272)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(55, 19)
        RBVaron.TabIndex = 12
        RBVaron.TabStop = True
        RBVaron.Text = "Varon"
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(493, 271)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 13
        RBMujer.TabStop = True
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.Location = New Point(411, 384)
        BSalir.Name = "BSalir"
        BSalir.Size = New Size(116, 42)
        BSalir.TabIndex = 14
        BSalir.Text = "Salir"
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(350, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(177, 173)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(601, 438)
        Controls.Add(PictureBox1)
        Controls.Add(BSalir)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(Panel1)
        Controls.Add(TEliminar)
        Controls.Add(TGuardar)
        Name = "Form1"
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents LNya As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents BSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

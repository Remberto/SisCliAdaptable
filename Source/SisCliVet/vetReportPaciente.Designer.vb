﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vetReportPaciente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtCodPaciente = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lstVacunas = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRasgos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEstadoRep = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEspecie = New System.Windows.Forms.TextBox()
        Me.txtSexo = New System.Windows.Forms.TextBox()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvVacunas = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvVacunas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 14)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 398)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(627, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Pacientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSeleccionar)
        Me.GroupBox1.Controls.Add(Me.dgvPacientes)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 354)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Paciente"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(491, 294)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(108, 46)
        Me.btnSeleccionar.TabIndex = 3
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(22, 57)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.Size = New System.Drawing.Size(577, 231)
        Me.dgvPacientes.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(87, 24)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(512, 22)
        Me.txtBusqueda.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Búsqueda:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(627, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(6, 7)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(615, 354)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtCodPaciente)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.lstVacunas)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.txtRasgos)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtEstadoRep)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.picFoto)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txtEspecie)
        Me.TabPage3.Controls.Add(Me.txtSexo)
        Me.TabPage3.Controls.Add(Me.txtFechaNac)
        Me.TabPage3.Controls.Add(Me.txtNombre)
        Me.TabPage3.Controls.Add(Me.txtRaza)
        Me.TabPage3.Controls.Add(Me.txtPeso)
        Me.TabPage3.Controls.Add(Me.txtColor)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(607, 326)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Datos Generales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtCodPaciente
        '
        Me.txtCodPaciente.Enabled = False
        Me.txtCodPaciente.Location = New System.Drawing.Point(267, 242)
        Me.txtCodPaciente.Name = "txtCodPaciente"
        Me.txtCodPaciente.Size = New System.Drawing.Size(159, 22)
        Me.txtCodPaciente.TabIndex = 51
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(264, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(162, 15)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Código de Registro Generado:"
        '
        'lstVacunas
        '
        Me.lstVacunas.Enabled = False
        Me.lstVacunas.FormattingEnabled = True
        Me.lstVacunas.ItemHeight = 15
        Me.lstVacunas.Location = New System.Drawing.Point(128, 224)
        Me.lstVacunas.Name = "lstVacunas"
        Me.lstVacunas.Size = New System.Drawing.Size(120, 94)
        Me.lstVacunas.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(69, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Vacunas:"
        '
        'txtRasgos
        '
        Me.txtRasgos.Enabled = False
        Me.txtRasgos.Location = New System.Drawing.Point(128, 165)
        Me.txtRasgos.Multiline = True
        Me.txtRasgos.Name = "txtRasgos"
        Me.txtRasgos.Size = New System.Drawing.Size(312, 44)
        Me.txtRasgos.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Rasgos distintivos:"
        '
        'txtEstadoRep
        '
        Me.txtEstadoRep.Enabled = False
        Me.txtEstadoRep.Location = New System.Drawing.Point(414, 125)
        Me.txtEstadoRep.Name = "txtEstadoRep"
        Me.txtEstadoRep.Size = New System.Drawing.Size(172, 22)
        Me.txtEstadoRep.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(289, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 15)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Estado Reproductivo:"
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(446, 161)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(141, 144)
        Me.picFoto.TabIndex = 41
        Me.picFoto.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(291, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 15)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Fecha de nacimiento:"
        '
        'txtEspecie
        '
        Me.txtEspecie.Enabled = False
        Me.txtEspecie.Location = New System.Drawing.Point(414, 14)
        Me.txtEspecie.Name = "txtEspecie"
        Me.txtEspecie.Size = New System.Drawing.Size(171, 22)
        Me.txtEspecie.TabIndex = 39
        '
        'txtSexo
        '
        Me.txtSexo.Enabled = False
        Me.txtSexo.Location = New System.Drawing.Point(77, 50)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(171, 22)
        Me.txtSexo.TabIndex = 39
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Enabled = False
        Me.txtFechaNac.Location = New System.Drawing.Point(415, 86)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(172, 22)
        Me.txtFechaNac.TabIndex = 38
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(77, 14)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(171, 22)
        Me.txtNombre.TabIndex = 39
        '
        'txtRaza
        '
        Me.txtRaza.Enabled = False
        Me.txtRaza.Location = New System.Drawing.Point(413, 50)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(172, 22)
        Me.txtRaza.TabIndex = 38
        '
        'txtPeso
        '
        Me.txtPeso.Enabled = False
        Me.txtPeso.Location = New System.Drawing.Point(77, 125)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(171, 22)
        Me.txtPeso.TabIndex = 37
        '
        'txtColor
        '
        Me.txtColor.Enabled = False
        Me.txtColor.Location = New System.Drawing.Point(77, 86)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(171, 22)
        Me.txtColor.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 15)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Peso:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(373, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Raza:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 15)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Color:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(359, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 15)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Especie:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(36, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Sexo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 15)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Nombre:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgvConsultas)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(607, 326)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Historial de Consultas"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgvConsultas
        '
        Me.dgvConsultas.AllowUserToAddRows = False
        Me.dgvConsultas.AllowUserToDeleteRows = False
        Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvConsultas.Location = New System.Drawing.Point(3, 3)
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.ReadOnly = True
        Me.dgvConsultas.Size = New System.Drawing.Size(601, 320)
        Me.dgvConsultas.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvVacunas)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(607, 326)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Control de Vacunas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvVacunas
        '
        Me.dgvVacunas.AllowUserToAddRows = False
        Me.dgvVacunas.AllowUserToDeleteRows = False
        Me.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVacunas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVacunas.Location = New System.Drawing.Point(3, 3)
        Me.dgvVacunas.Name = "dgvVacunas"
        Me.dgvVacunas.ReadOnly = True
        Me.dgvVacunas.Size = New System.Drawing.Size(601, 320)
        Me.dgvVacunas.TabIndex = 0
        '
        'vetReportPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 422)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.Name = "vetReportPaciente"
        Me.Text = "Reporte de Pacientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvVacunas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lstVacunas As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRasgos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEstadoRep As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEspecie As System.Windows.Forms.TextBox
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaNac As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtRaza As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgvConsultas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvVacunas As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodPaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
End Class

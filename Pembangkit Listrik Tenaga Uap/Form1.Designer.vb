<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalBatubara = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbxTahap = New System.Windows.Forms.GroupBox()
        Me.ptxwater = New System.Windows.Forms.PictureBox()
        Me.ptxlistrik = New System.Windows.Forms.PictureBox()
        Me.ptxuap = New System.Windows.Forms.PictureBox()
        Me.ptxcj = New System.Windows.Forms.PictureBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.ptxCoal = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxTahap.SuspendLayout()
        CType(Me.ptxwater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxlistrik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxuap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxcj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxCoal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banyak Batubara"
        '
        'txtTotalBatubara
        '
        Me.txtTotalBatubara.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBatubara.Location = New System.Drawing.Point(279, 29)
        Me.txtTotalBatubara.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalBatubara.Name = "txtTotalBatubara"
        Me.txtTotalBatubara.Size = New System.Drawing.Size(361, 23)
        Me.txtTotalBatubara.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(654, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kg"
        '
        'btnProses
        '
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Location = New System.Drawing.Point(279, 77)
        Me.btnProses.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(168, 38)
        Me.btnProses.TabIndex = 3
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(474, 77)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(168, 38)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'gbxTahap
        '
        Me.gbxTahap.Controls.Add(Me.ptxwater)
        Me.gbxTahap.Controls.Add(Me.ptxlistrik)
        Me.gbxTahap.Controls.Add(Me.ptxuap)
        Me.gbxTahap.Controls.Add(Me.ptxcj)
        Me.gbxTahap.Controls.Add(Me.btnHitung)
        Me.gbxTahap.Controls.Add(Me.ptxCoal)
        Me.gbxTahap.Controls.Add(Me.Label8)
        Me.gbxTahap.Controls.Add(Me.Label7)
        Me.gbxTahap.Controls.Add(Me.Label6)
        Me.gbxTahap.Controls.Add(Me.Label5)
        Me.gbxTahap.Controls.Add(Me.Label4)
        Me.gbxTahap.Controls.Add(Me.PictureBox5)
        Me.gbxTahap.Controls.Add(Me.PictureBox4)
        Me.gbxTahap.Controls.Add(Me.PictureBox3)
        Me.gbxTahap.Controls.Add(Me.PictureBox2)
        Me.gbxTahap.Controls.Add(Me.PictureBox1)
        Me.gbxTahap.Location = New System.Drawing.Point(12, 170)
        Me.gbxTahap.Name = "gbxTahap"
        Me.gbxTahap.Size = New System.Drawing.Size(812, 276)
        Me.gbxTahap.TabIndex = 8
        Me.gbxTahap.TabStop = False
        Me.gbxTahap.Text = "Tahapan"
        Me.gbxTahap.Visible = False
        '
        'ptxwater
        '
        Me.ptxwater.Image = CType(resources.GetObject("ptxwater.Image"), System.Drawing.Image)
        Me.ptxwater.Location = New System.Drawing.Point(200, 192)
        Me.ptxwater.Name = "ptxwater"
        Me.ptxwater.Size = New System.Drawing.Size(83, 78)
        Me.ptxwater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxwater.TabIndex = 14
        Me.ptxwater.TabStop = False
        Me.ptxwater.Visible = False
        '
        'ptxlistrik
        '
        Me.ptxlistrik.Image = CType(resources.GetObject("ptxlistrik.Image"), System.Drawing.Image)
        Me.ptxlistrik.Location = New System.Drawing.Point(569, 109)
        Me.ptxlistrik.Name = "ptxlistrik"
        Me.ptxlistrik.Size = New System.Drawing.Size(83, 77)
        Me.ptxlistrik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxlistrik.TabIndex = 13
        Me.ptxlistrik.TabStop = False
        Me.ptxlistrik.Visible = False
        '
        'ptxuap
        '
        Me.ptxuap.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ptxuap.Image = CType(resources.GetObject("ptxuap.Image"), System.Drawing.Image)
        Me.ptxuap.Location = New System.Drawing.Point(389, 109)
        Me.ptxuap.Name = "ptxuap"
        Me.ptxuap.Size = New System.Drawing.Size(83, 77)
        Me.ptxuap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxuap.TabIndex = 12
        Me.ptxuap.TabStop = False
        Me.ptxuap.Visible = False
        '
        'ptxcj
        '
        Me.ptxcj.Image = CType(resources.GetObject("ptxcj.Image"), System.Drawing.Image)
        Me.ptxcj.Location = New System.Drawing.Point(200, 109)
        Me.ptxcj.Name = "ptxcj"
        Me.ptxcj.Size = New System.Drawing.Size(83, 77)
        Me.ptxcj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxcj.TabIndex = 11
        Me.ptxcj.TabStop = False
        Me.ptxcj.Visible = False
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(690, 207)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(116, 31)
        Me.btnHitung.TabIndex = 10
        Me.btnHitung.Text = "Perhitungan"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'ptxCoal
        '
        Me.ptxCoal.Image = CType(resources.GetObject("ptxCoal.Image"), System.Drawing.Image)
        Me.ptxCoal.Location = New System.Drawing.Point(11, 109)
        Me.ptxCoal.Name = "ptxCoal"
        Me.ptxCoal.Size = New System.Drawing.Size(83, 77)
        Me.ptxCoal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxCoal.TabIndex = 6
        Me.ptxCoal.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Batubara"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(716, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Transformer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(568, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Generator"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(402, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Boiler"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Penggilingan"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(389, 25)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(67, 57)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(730, 26)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 57)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(571, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(67, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(206, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(67, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 479)
        Me.Controls.Add(Me.gbxTahap)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalBatubara)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulasi Pembangkit Listrik Tenaga Uap"
        Me.gbxTahap.ResumeLayout(False)
        Me.gbxTahap.PerformLayout()
        CType(Me.ptxwater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxlistrik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxuap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxcj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxCoal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalBatubara As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnProses As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gbxTahap As GroupBox
    Friend WithEvents ptxwater As PictureBox
    Friend WithEvents ptxlistrik As PictureBox
    Friend WithEvents ptxuap As PictureBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents ptxCoal As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents ptxcj As PictureBox
End Class

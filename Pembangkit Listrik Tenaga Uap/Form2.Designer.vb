<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimulasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimulasi))
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblDaya = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ptxRMH1OFF = New System.Windows.Forms.PictureBox()
        Me.ptxRMH1ON = New System.Windows.Forms.PictureBox()
        Me.ptxRMH2ON = New System.Windows.Forms.PictureBox()
        Me.ptxRMH2OFF = New System.Windows.Forms.PictureBox()
        Me.ptxKNTRON = New System.Windows.Forms.PictureBox()
        Me.ptxKNTROFF = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxRMH1OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxRMH1ON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxRMH2ON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxRMH2OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxKNTRON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptxKNTROFF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(126, 21)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(243, 17)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Daya Listrik yang Diperoleh Sebesar "
        '
        'lblDaya
        '
        Me.lblDaya.AutoSize = True
        Me.lblDaya.Location = New System.Drawing.Point(376, 21)
        Me.lblDaya.Name = "lblDaya"
        Me.lblDaya.Size = New System.Drawing.Size(0, 17)
        Me.lblDaya.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(437, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "KWh"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(697, 403)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 31)
        Me.btnKembali.TabIndex = 10
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Rumah 900 KWh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(357, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Rumah 1300 KWh"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(360, 202)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(115, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Kantor 5100 KWh"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(655, 202)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'ptxRMH1OFF
        '
        Me.ptxRMH1OFF.Image = CType(resources.GetObject("ptxRMH1OFF.Image"), System.Drawing.Image)
        Me.ptxRMH1OFF.Location = New System.Drawing.Point(88, 114)
        Me.ptxRMH1OFF.Name = "ptxRMH1OFF"
        Me.ptxRMH1OFF.Size = New System.Drawing.Size(59, 52)
        Me.ptxRMH1OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxRMH1OFF.TabIndex = 25
        Me.ptxRMH1OFF.TabStop = False
        '
        'ptxRMH1ON
        '
        Me.ptxRMH1ON.Image = CType(resources.GetObject("ptxRMH1ON.Image"), System.Drawing.Image)
        Me.ptxRMH1ON.Location = New System.Drawing.Point(88, 114)
        Me.ptxRMH1ON.Name = "ptxRMH1ON"
        Me.ptxRMH1ON.Size = New System.Drawing.Size(59, 52)
        Me.ptxRMH1ON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxRMH1ON.TabIndex = 26
        Me.ptxRMH1ON.TabStop = False
        Me.ptxRMH1ON.Visible = False
        '
        'ptxRMH2ON
        '
        Me.ptxRMH2ON.Image = CType(resources.GetObject("ptxRMH2ON.Image"), System.Drawing.Image)
        Me.ptxRMH2ON.Location = New System.Drawing.Point(390, 114)
        Me.ptxRMH2ON.Name = "ptxRMH2ON"
        Me.ptxRMH2ON.Size = New System.Drawing.Size(59, 52)
        Me.ptxRMH2ON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxRMH2ON.TabIndex = 28
        Me.ptxRMH2ON.TabStop = False
        Me.ptxRMH2ON.Visible = False
        '
        'ptxRMH2OFF
        '
        Me.ptxRMH2OFF.Image = CType(resources.GetObject("ptxRMH2OFF.Image"), System.Drawing.Image)
        Me.ptxRMH2OFF.Location = New System.Drawing.Point(390, 114)
        Me.ptxRMH2OFF.Name = "ptxRMH2OFF"
        Me.ptxRMH2OFF.Size = New System.Drawing.Size(59, 52)
        Me.ptxRMH2OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxRMH2OFF.TabIndex = 27
        Me.ptxRMH2OFF.TabStop = False
        '
        'ptxKNTRON
        '
        Me.ptxKNTRON.Image = CType(resources.GetObject("ptxKNTRON.Image"), System.Drawing.Image)
        Me.ptxKNTRON.Location = New System.Drawing.Point(681, 114)
        Me.ptxKNTRON.Name = "ptxKNTRON"
        Me.ptxKNTRON.Size = New System.Drawing.Size(59, 52)
        Me.ptxKNTRON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxKNTRON.TabIndex = 30
        Me.ptxKNTRON.TabStop = False
        Me.ptxKNTRON.Visible = False
        '
        'ptxKNTROFF
        '
        Me.ptxKNTROFF.Image = CType(resources.GetObject("ptxKNTROFF.Image"), System.Drawing.Image)
        Me.ptxKNTROFF.Location = New System.Drawing.Point(681, 114)
        Me.ptxKNTROFF.Name = "ptxKNTROFF"
        Me.ptxKNTROFF.Size = New System.Drawing.Size(59, 52)
        Me.ptxKNTROFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptxKNTROFF.TabIndex = 29
        Me.ptxKNTROFF.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(59, 327)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 21)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "OFF"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(360, 327)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(54, 21)
        Me.CheckBox2.TabIndex = 37
        Me.CheckBox2.Text = "OFF"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(655, 327)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(54, 21)
        Me.CheckBox3.TabIndex = 39
        Me.CheckBox3.Text = "OFF"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'frmSimulasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 479)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ptxKNTRON)
        Me.Controls.Add(Me.ptxKNTROFF)
        Me.Controls.Add(Me.ptxRMH2ON)
        Me.Controls.Add(Me.ptxRMH2OFF)
        Me.Controls.Add(Me.ptxRMH1ON)
        Me.Controls.Add(Me.ptxRMH1OFF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDaya)
        Me.Controls.Add(Me.label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmSimulasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulasi pembangkit Listrik Tenaga Uap"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxRMH1OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxRMH1ON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxRMH2ON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxRMH2OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxKNTRON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptxKNTROFF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label2 As Label
    Friend WithEvents lblDaya As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ptxRMH1OFF As PictureBox
    Friend WithEvents ptxRMH1ON As PictureBox
    Friend WithEvents ptxRMH2ON As PictureBox
    Friend WithEvents ptxRMH2OFF As PictureBox
    Friend WithEvents ptxKNTRON As PictureBox
    Friend WithEvents ptxKNTROFF As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class

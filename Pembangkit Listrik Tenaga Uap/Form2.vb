Public Class frmSimulasi
    Sub kondisi()
        Dim sisa As Integer
        If CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            If CInt(lblDaya.Text) >= 900 Then
                ptxRMH1ON.Visible = True
                ptxRMH1OFF.Visible = False
                ptxRMH2ON.Visible = False
                ptxRMH2OFF.Visible = True
                ptxKNTRON.Visible = False
                ptxKNTROFF.Visible = True
            Else
                MessageBox.Show("Maaf daya tidak mencukupi")
            End If
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            ptxRMH1ON.Visible = False
            ptxRMH1OFF.Visible = True
            ptxRMH2ON.Visible = False
            ptxRMH2OFF.Visible = True
            ptxKNTRON.Visible = False
            ptxKNTROFF.Visible = True
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            If CInt(lblDaya.Text) >= 2200 Then
                ptxRMH1ON.Visible = True
                ptxRMH1OFF.Visible = False
                ptxRMH2ON.Visible = True
                ptxRMH2OFF.Visible = False
                ptxKNTRON.Visible = False
                ptxKNTROFF.Visible = True
            Else
                MessageBox.Show("Maaf daya tidak mencukupi")
            End If
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            If CInt(lblDaya.Text) >= 6000 Then
                ptxRMH1ON.Visible = True
                ptxRMH1OFF.Visible = False
                ptxRMH2ON.Visible = False
                ptxRMH2OFF.Visible = True
                ptxKNTRON.Visible = True
                ptxKNTROFF.Visible = False
            Else
                MessageBox.Show("Maaf daya tidak mencukupi")
            End If
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = False Then
            If CInt(lblDaya.Text) >= 1300 Then
                ptxRMH1ON.Visible = False
                ptxRMH1OFF.Visible = True
                ptxRMH2ON.Visible = True
                ptxRMH2OFF.Visible = False
                ptxKNTRON.Visible = False
                ptxKNTROFF.Visible = True
            Else
                MessageBox.Show("Maaf daya tidak mencukupi")
            End If
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            If CInt(lblDaya.Text) >= 6400 Then
                ptxRMH1ON.Visible = False
                ptxRMH1OFF.Visible = True
                ptxRMH2ON.Visible = True
                ptxRMH2OFF.Visible = False
                ptxKNTRON.Visible = True
                ptxKNTROFF.Visible = False
            Else
                MessageBox.Show("Maaf daya tidak mencukupi")
            End If
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = True Then
            If CInt(lblDaya.Text) >= 5100 Then
                ptxRMH1ON.Visible = False
                ptxRMH1OFF.Visible = True
                ptxRMH2ON.Visible = False
                ptxRMH2OFF.Visible = True
                ptxKNTRON.Visible = True
                ptxKNTROFF.Visible = False
            Else
                MessageBox.Show("Maaf daya tidak mencukupi")
            End If
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            If CInt(lblDaya.Text) >= 7300 Then
                ptxRMH1ON.Visible = True
                ptxRMH1OFF.Visible = False
                ptxRMH2ON.Visible = True
                ptxRMH2OFF.Visible = False
                ptxKNTRON.Visible = True
                ptxKNTROFF.Visible = False
            Else
                MessageBox.Show("Maaf daya tidak mencukupi")
            End If
        End If
    End Sub
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        frmHome.Show()
        Me.Close()
        frmHome.Timer1.Enabled = False
        frmHome.ptxCoal.Location = New Point(11, 109)
        frmHome.ptxcj.Location = New Point(200, 109)
        frmHome.ptxwater.Location = New Point(200, 192)
        frmHome.ptxuap.Location = New Point(389, 109)
        frmHome.ptxlistrik.Location = New Point(569, 109)
        frmHome.ptxcj.Visible = False
        frmHome.ptxwater.Visible = False
        frmHome.ptxuap.Visible = False
        frmHome.ptxlistrik.Visible = False
        frmHome.txtTotalBatubara.Text = ""
        frmHome.gbxTahap.Visible = False
        frmHome.txtTotalBatubara.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "ON"
            kondisi()
        Else
            CheckBox1.Text = "OFF"
            kondisi()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.Text = "ON"
            kondisi()
        Else
            CheckBox2.Text = "OFF"
            kondisi()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox3.Text = "ON"
            kondisi()
        Else
            CheckBox3.Text = "OFF"
            kondisi()
        End If
    End Sub
End Class
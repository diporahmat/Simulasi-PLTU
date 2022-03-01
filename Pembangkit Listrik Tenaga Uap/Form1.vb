Public Class frmHome
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ptxCoal.Left = Me.Width Then
            Timer1.Enabled = False
        Else
            If ptxCoal.Left < 860 Then
                ptxCoal.Left = ptxCoal.Left + 50
                If ptxCoal.Left > 151 Then
                    ptxCoal.Visible = False
                    ptxcj.Visible = True
                    ptxwater.Visible = True
                    ptxwater.Left = ptxwater.Left + 50
                    ptxcj.Left = ptxcj.Left + 50
                    If ptxcj.Left > 381 Then
                        ptxwater.Visible = False
                        ptxcj.Visible = False
                        ptxuap.Visible = True
                        ptxuap.Left = ptxuap.Left + 50
                        If ptxuap.Left > 601 Then
                            ptxuap.Visible = False
                            If ptxlistrik.Left < 721 Then
                                ptxlistrik.Visible = True
                                ptxlistrik.Left = ptxlistrik.Left + 20
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If txtTotalBatubara.Text = "" Then
            MessageBox.Show("Banyak Batubara Belum Diisi!")
        Else
            gbxTahap.Visible = True
            ptxCoal.Visible = True
            Timer1.Enabled = True
            frmSimulasi.lblDaya.Text = 2 * CInt(txtTotalBatubara.Text)
        End If

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtTotalBatubara.Text = ""
    End Sub

    Private Sub BtnHitung_Click_1(sender As Object, e As EventArgs) Handles btnHitung.Click
        frmSimulasi.Show()
        Me.Hide()
    End Sub
End Class

﻿Public Class bam

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        lt.Show()
        Me.Hide()
    End Sub

    Private Sub bam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PatanjaliDataSet9.Patanjali_Bam' table. You can move, or remove it, as needed.
        Me.Patanjali_BamTableAdapter.Fill(Me.PatanjaliDataSet9.Patanjali_Bam)

    End Sub
End Class
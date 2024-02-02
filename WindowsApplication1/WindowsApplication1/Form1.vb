Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox6.Text = 0

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ga As Integer
        Dim gc As Integer
        Dim dg As Integer
        Dim rec As Double
        Dim prem1 As Double
        Dim prem2 As Double
        Dim prem3 As Double
        Dim prem4 As Double
       
        If (ComboBox1.SelectedItem = "Grupo #1" Or ComboBox1.SelectedItem = "Grupo #2") Then
            ga = Val(TextBox3.Text)
            gc = Val(TextBox4.Text)
            dg = ga - gc
            TextBox5.Text = dg

            DataGridView1.Rows.Add(ComboBox1.SelectedItem, TextBox1.Text, Val(TextBox2.Text), Val(TextBox3.Text), Val(TextBox4.Text), dg)
        Else
            MsgBox("Por favor seleccione un grupo")

        End If


        rec = Val(TextBox6.Text)
        If (rec <> 0) Then
            prem1 = 50000 + 0.1 * rec
            prem2 = 30000 + 0.05 * rec
            prem3 = 20000 + 0.03 * rec
            prem4 = 10000 + 0.01 * rec

            TextBox7.Text = prem1
            TextBox8.Text = prem2
            TextBox9.Text = prem3
            TextBox10.Text = prem4


        Else
            MsgBox("Por favor ingrese el monto recolectado en el torneo")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Sort(DataGridView1.Columns(2), System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        With DataGridView1
            .Sort(DataGridView1.Columns(2), System.ComponentModel.ListSortDirection.Descending)
            .Sort(DataGridView1.Columns(5), System.ComponentModel.ListSortDirection.Descending)
        End With
    End Sub
End Class

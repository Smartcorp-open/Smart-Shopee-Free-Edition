Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyDataDataSet1.Data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.MyDataDataSet1.Data)
        'TODO: This line of code loads data into the 'MyDataDataSet.Data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.MyDataDataSet1.Data)
        'TODO: This line of code loads data into the 'MyDataDataSet1.Data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.MyDataDataSet1.Data)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataBindingSource1.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataBindingSource1.RemoveCurrent()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataBindingSource1.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataBindingSource1.MovePrevious()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataBindingSource1.EndEdit()
        DataTableAdapter.Update(Me.MyDataDataSet1.Data)
        DataTableAdapter.Fill(Me.MyDataDataSet1.Data)

        MsgBox("Your Record Has Been Submitted Successfully !", vbInformation)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Call notfound()
            Exit Sub
        Else
            DataBindingSource1.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSearch.Text & "')" &
                "OR (Product LIKE '" & txtSearch.Text & "') OR (Price LIKE '" & txtSearch.Text & "')" &
                "OR (Quantity LIKE '" & txtSearch.Text & "') OR (Details LIKE '" & txtSearch.Text & "')" &
                "OR (Manufacturer LIKE '" & txtSearch.Text & "')"
            If DataBindingSource1.Count <> 0 Then
                With DataGridView1
                    .DataSource = DataBindingSource1

                End With
            Else
                MsgBox("Data Not Found !!!!!", MsgBoxStyle.Information)
                DataBindingSource1.Filter = Nothing

            End If
        End If
    End Sub
    Private Sub notfound()

    End Sub
End Class

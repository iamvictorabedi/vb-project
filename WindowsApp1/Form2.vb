Public Class Form2
    Private Sub Sheet1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Sheet1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Sheet1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Sheet1' table. You can move, or remove it, as needed.
        Me.Sheet1TableAdapter.Fill(Me.StudentDataSet.Sheet1)

    End Sub

    Private Sub btngrades_Click(sender As Object, e As EventArgs) Handles btngrades.Click
        Form1.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("Do you want to exit?", "Student Grade Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
           DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
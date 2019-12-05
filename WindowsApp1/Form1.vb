Public Class Form1
    Private Sub Sheet2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Sheet2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Sheet2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.Sheet2' table. You can move, or remove it, as needed.
        Me.Sheet2TableAdapter.Fill(Me.StudentDataSet.Sheet2)

    End Sub

    Private Sub btnattendance_Click(sender As Object, e As EventArgs) Handles btnattendance.Click
        Form2.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("Do you want to exit?", "Student Grade Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
            DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class

Public Class Form1

    Dim totalCals As Double
    Dim fatGrams As Double
    Dim fatCals As Double
    Dim fatPercentage As Double
    Dim valuesAreValid As Boolean = True

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearEverything()
        totalCals = 0
        fatGrams = 0
        fatPercentage = 0
        fatCals = 0

        txtCals.Clear()
        txtFat.Clear()
        txtPercentage.Clear()
    End Sub

    Private Sub ValidateInputs()
        If (Not IsNumeric(txtFat.Text)) Then
            MessageBox.Show("Fat grams are not numeric", "Error")
            ClearEverything()
            valuesAreValid = False
        ElseIf (Not IsNumeric(txtCals.Text)) Then
            MessageBox.Show("Calories are not numeric", "Error")
            ClearEverything()
            valuesAreValid = False
        Else
            totalCals = Double.Parse(txtCals.Text)
            fatGrams = Double.Parse(txtFat.Text)
            fatCals = (fatGrams * 9)
            fatPercentage = fatCals / totalCals * 100
            valuesAreValid = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearEverything()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ValidateInputs()

        Try
            If (valuesAreValid) Then
                If (fatPercentage > 100) Then
                    MessageBox.Show("Input Error: fat calories may not be greater than total calories", "Notice!")
                    ClearEverything()
                Else
                    Select Case fatPercentage
                        Case Is < 30
                            MessageBox.Show("This food is low in fat", "Notice!")
                            txtPercentage.Text = fatPercentage.ToString
                        Case Is >= 30
                            MessageBox.Show("This food is high in fat", "Notice!")
                            txtPercentage.Text = fatPercentage.ToString
                    End Select
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Error!", "Something wrong with the math")
        End Try
    End Sub
End Class

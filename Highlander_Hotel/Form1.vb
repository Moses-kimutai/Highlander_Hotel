Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Declaration of variables'
        Dim Nights As Double
        Dim Night_Charge As Double
        Dim Room_Service As Double
        Dim Telephone As Double
        Dim Misc As Double
        Dim Room_Charges As Double
        Dim Additional As Double
        Dim Subtotal As Double
        Dim Tax As Double
        Dim Total_Charges As Double


        ' this allows textbox inputs to be transfered to spesific variable'

        'try checks if the inputs are double if not a pop up message will apear asking you to enter a double number'
        Try
            Nights = Val(TextBox1.Text)
            Night_Charge = Val(TextBox2.Text)
            Room_Service = Val(TextBox3.Text)
            Telephone = Val(TextBox4.Text)
            Misc = Val(TextBox5.Text)

        Catch
            MessageBox.Show(" Enter a double number.")

        End Try

        'calculation of  Room charges, Additional charges, Tubtotal, Tax and Total charges.'
        Room_Charges = Nights * Night_Charge
        Additional = Room_Charges + Room_Service + Misc
        Subtotal = Room_Charges + Additional
        Tax = Subtotal * 0.07
        Total_Charges = Subtotal + Tax

        'conversion of double variables to string'
        'displaying the calculations in the labels'
        LblRoom.Text = ("$") & Room_Charges.ToString("n2")
        LblAdditional.Text = ("$") & Additional.ToString("n2")
        LblSub.Text = ("$") & Subtotal.ToString("n2")
        LblTax.Text = ("$") & Tax.ToString("n2")
        LblTotal.Text = ("$") & Total_Charges.ToString("n2")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'clears all the textboxes and display labels.'
        TextBox1.ResetText()
        TextBox2.ResetText()
        TextBox3.ResetText()
        TextBox4.ResetText()
        TextBox5.ResetText()
        LblRoom.ResetText()
        LblAdditional.ResetText()
        LblSub.ResetText()
        LblTax.ResetText()
        LblTotal.ResetText()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Closes the application'
        Me.Close()

    End Sub
End Class

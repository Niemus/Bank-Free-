
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox4.Text = TextBox1.Text * TextBox2.Text * 0.12 * 30 / 361

        Dim Valuta As Double = TextBox4.Text
        TextBox4.Text = String.Format("{0:c}", Valuta)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox3.Text = "12,5"


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox5.Text = TextBox6.Text * 9 / 100

        Dim Valuta2 As Double = TextBox5.Text
        TextBox5.Text = String.Format("{0:c}", Valuta2)


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ModuleRegAuto.RegAuto()
    End Sub
End Class

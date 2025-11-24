Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("cafe")
        ListBox1.Items.Add("jus d orqnge")
        ListBox1.Items.Add("eau minerale")
        ListBox1.Items.Add("citronade")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim commande As String
        Dim prix As Integer
        If rdpizza.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf rdpates.Checked Then
            commande = "pates"
            prix = 15
        Else
            commande = "burger"
            prix = 8
        End If
        For Each ctrl In grsuppliments.controls
            If ctrl.checked Then
                commande = commande() + "" + ctrl.text
                If ctrl.text = "fromage" Then
                    prix = prix + 2
                ElseIf ctrl.text = "frittes" Then
                    prix = prix + 2
                ElseIf ctrl.text = "dessert" Then
                    prix = prix + 4

                End If
            End If
        Next

    End Sub
End Class

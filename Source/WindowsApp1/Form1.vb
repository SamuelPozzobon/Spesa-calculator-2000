Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim spesa, tot, iva, commissioneC, commissioneE, totfinale As Double
        Dim p1, p2, p3, p4, totp As Double
        Dim pagamento As String
        MsgBox("Benvenuto in 'Spesa calculator 2000', un programma dove potrai calcolare il costo della tua spesa (Solo 4 prodotti!). Fornito dal supermarket Esselunga")
        p1 = InputBox("Inserisci il prezzo del prodotto numero 1")
        p2 = InputBox("Inserisci il prezzo del prodotto numero 2")
        p3 = InputBox("Inserisci il prezzo del prodotto numero 3")
        p4 = InputBox("Inserisci il prezzo del prodotto numero 4")
        MsgBox("Sto calcolando l'importo della tua spesa (Addebitando l'IVA del 22%)...")
        totp = p1 + p2 + p3 + p4
        iva = (totp * 22) / 100
        tot = totp + iva
        pagamento = InputBox("Scegli un metodo di pagamento, se paghi in 'contanti' avrai una commissione del 2% mentre se con 'elettronico' avrai uno sconto del 1%, se usi altri metodi nessun cambiamento.")
        If pagamento = "contanti" Then
            commissioneC = (tot * 2) / 100
            totfinale = tot + commissioneC
            MsgBox("Devi pagare " & totfinale & "€")
        Else
            If pagamento = "elettronico" Then
                commissioneE = (tot * 1) / 100
                totfinale = spesa - commissioneE
                MsgBox("Devi pagare " & totfinale & "€")
            Else
                MsgBox("Devi pagare " & tot & "€")
            End If
        End If

        MsgBox("Grazie per aver comprato da Esselunga ed aver utilizzato Spesa calculator 2000!")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SecondForm As New Form2

        SecondForm.Show()
    End Sub

    Public random As New Random()

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As Integer
        For i = 1 To 1
            MsgBox(Convert.ToString(random.Next(0, 1000000000)))
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ThirdForm As New Form3

        ThirdForm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim Form4 As New Form4

        Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Attualmente Papa Francesco sta pregando, non si può richiedere un appuntamento in questo momento.")

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim Form5 As New Form5

        Form5.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Form6 As New Form6

        Form6.Show()
    End Sub
End Class

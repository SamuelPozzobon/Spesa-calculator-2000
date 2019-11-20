Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim anno, numeropolmoni As Integer
        Dim respiro, malattia As String
        Dim tot, tot2 As Double
        MsgBox("Esselunga market 9000 ti presenta il calcolatore dei polmoni! Clicca OK per continuare.")
        anno = InputBox("Inserisci il tuo anno di nascita")
        numeropolmoni = InputBox("Quanti polmoni hai?")
        respiro = InputBox("Il tuo respiro è in buone condizioni? Se sì mettere 'si' invece se no mettere 'no'")
        If respiro = "si" Then
            tot = anno * 13
        Else
            If respiro = "no" Then
                tot = anno * 4
            End If
        End If
        malattia = InputBox("Hai qualche malattia ai polmoni? Se si mettere 'si' invece se no mettere 'no'")
        If malattia = "si" Then
            tot2 = tot + 120
            MsgBox("Il costo dei tuoi polmoni è di " & tot2 & "€")
        Else
            If malattia = "no" Then
                tot2 = tot + 867
                MsgBox("Il costo dei tuoi polmoni è di " & tot2 & "€")
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim anno, numeroreni As Integer
        Dim urina, malattia As String
        Dim tot, tot2 As Double
        MsgBox("Esselunga market 9000 ti presenta il calcolatore dei reni!")
        anno = InputBox("Inserisci il tuo anno di nascita")
        numeroreni = InputBox("Quanti reni hai?")
        urina = InputBox("La tua urina è in buone condizioni? Se si mettere 'si' invece se no mettere 'no'")
        If urina = "si" Then
            tot = anno * 4
        Else
            If urina = "no" Then
                tot = anno * 2
            End If
        End If
        malattia = InputBox("Hai qualche malattia ai reni? Se si mettere 'si' invece se no mettere 'no'")
        If malattia = "si" Then
            tot2 = tot + 120
            MsgBox("Il costo dei tuoi reni è di " & tot2 & "€")
        Else
            If malattia = "no" Then
                tot2 = tot + 567
                MsgBox("Il costo dei tuoi reni è di " & tot2 & "€")
            End If
        End If
    End Sub
End Class
Module Produits
    Public Structure article
        Dim code As Integer
        Dim qte As Integer
        Dim desination As String
        Dim prix As Double
    End Structure
    Public listeproduit As New List(Of article)
    Function ajoutarticle(Ar As article)
        If existe(Ar.code) = True Then
            MessageBox.Show("article deja exsite ", "erreur")
            Return False
        Else
            listeproduit.Add(Ar)
            MessageBox.Show("ajout avec succe ", "bien")
        End If
    End Function

    Private Function existe(ch As String)
        Dim test As Boolean = False
        For Each Ar As article In listeproduit
            If Ar.code = ch Then
                test = True
            Else
                test = False
            End If
        Next
        Return test
    End Function
    Function pluscher() As article
        Dim max As Double = listeproduit(0).prix
        Dim cher As String = listeproduit(0).desination
        For Each i As article In listeproduit
            If i.prix > max Then
                max = i.prix
                cher = i.desination
            End If
        Next
    End Function

End Module

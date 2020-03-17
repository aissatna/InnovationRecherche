Module InnovationRecherche
    Public liste() As Integer 'Liste mémorisant les entiers
    Public element As Integer 'Element à rechercher dans la liste'
    Public Structure Etape 'Structure d'étapes
        Dim debut As Integer
        Dim fin As Integer
    End Structure

    'Initialisation du Module
    Public Sub Initialisation(ByVal taille As Integer,
                              ByVal min As Integer,
                              ByVal max As Integer)
        InnovationRecherche.GenererListe(taille, min, max)
        InnovationRecherche.TriRapide()
        InnovationRecherche.AfficherTouteLaListe()
    End Sub

    'Génère une liste d'entier non triée
    Public Sub GenererListe(ByVal taille As Integer, ByVal min As Integer, ByVal max As Integer)
        ReDim liste(taille - 1)
        Dim random As Integer

        Randomize()
        For i = 0 To taille - 1
            random = Int((max - min + 1) * Rnd() + min)

            Do While liste.Contains(random)
                random = Int((max - min + 1) * Rnd() + min)
            Loop

            liste(i) = random
        Next
    End Sub

    'Échange la place de deux éléments d'une liste
    Public Sub Echanger(ByVal i As Integer, ByVal j As Integer)
        Dim tmp = liste(i)
        liste(i) = liste(j)
        liste(j) = tmp
    End Sub

    'Partitionne une liste d'entier pour le tri rapide
    Public Function Partitionner(ByRef premier As Integer, ByRef dernier As Integer,
                                 ByRef pivot As Integer) As Integer
        Dim j = premier
        Echanger(pivot, dernier)

        For i = premier To dernier - 1
            If liste(i) <= liste(dernier) Then
                Echanger(i, j)
                j += 1
            End If
        Next i

        Echanger(dernier, j)
        Return j
    End Function

    'Choisit et renvoie l'élément a ou b
    Public Function ChoixPivot(ByVal a As Integer, ByVal b As Integer) As Integer
        Randomize()
        If CInt(Int((2 * Rnd()) + 1)) = 2 Then
            Return a
        Else
            Return b
        End If
    End Function

    'Fonction de tri rapide (quick sort)
    Public Sub TriRapide(ByRef premier As Integer, ByRef dernier As Integer)
        Dim pivot As Integer
        If premier < dernier Then
            pivot = ChoixPivot(premier, dernier) 'Revoie le premier ou le dernier
            pivot = Partitionner(premier, dernier, pivot)
            TriRapide(premier, pivot - 1)
            TriRapide(pivot + 1, dernier)
        End If
    End Sub

    'Trie la liste grace à la fonction de tri rapide
    Public Sub TriRapide()
        TriRapide(0, liste.Length - 1)
    End Sub

    'Affiche les éléments de la liste entre l'indice "debut" et l'indice "fin"
    Public Sub AfficherListe(ByVal debut As Integer, ByVal fin As Integer)
        Dim text = ""
        For i = debut To fin
            text += liste(i) & " | "
        Next
        Console.WriteLine(text)
    End Sub

    'Affiche tous les éléments de la liste
    Public Sub AfficherTouteLaListe()
        AfficherListe(0, liste.Length - 1)
    End Sub


    'Recherche et retourne la position d'un élément dans une liste
    Public Function RechercheDichotomique(ByVal element As Integer) As Integer
        InnovationRecherche.element = element
        Return RechercheDichotomique(0, liste.Length - 1)
    End Function


    'Effectue une recherche par dichotomie
    Public Function RechercheDichotomique(ByVal debut As Integer, ByVal fin As Integer) As Integer
        Dim longueurListe = (fin + 1) - (debut + 1)
        Dim mediane As Integer

        If longueurListe < 0 Then
            Return -1
        End If

        If longueurListe Mod 2 = 0 Then
            mediane = longueurListe / 2 + debut
        Else
            mediane = CInt(longueurListe / 2) + 1 + debut
        End If

        If InnovationRecherche.element = liste(mediane) Then
            Return mediane
        ElseIf InnovationRecherche.element < liste(mediane) Then
            Return RechercheDichotomique(debut, mediane - 1)
        Else
            Return RechercheDichotomique(mediane + 1, fin)
        End If
    End Function

    'Effectue une recherche séquentielle et retourne la position de l'élement dans la liste
    '-1 pour le cas échéant (ne se trouve pas dans la liste)
    Public Function RechercheSequentielle(ByVal element As Integer) As Integer
        InnovationRecherche.element = element
        'Écrire le code sur la recherche séquentielle ici :D
        Dim trouveElement As Boolean = False
        Dim i As Integer = 0
        Dim indiceElement As Integer = -1
        While trouveElement = False And i < liste.Length
            If liste(i) = element Then
                trouveElement = True
                indiceElement = i
            Else
                i += 1
            End If
        End While
        Return indiceElement
    End Function
End Module

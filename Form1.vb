Public Class Form1
    Public listeBouton() As Button 'Liste des boutons qui s'affiche pour désigner les éléments

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnInitialisation.Enabled = False
        btnRecherche.Enabled = False
        ReDim listeBouton(0)
    End Sub

    Private Sub btnInitialisation_Click(sender As Object, e As EventArgs) Handles btnInitialisation.Click
        InnovationRecherche.Initialisation(CInt(tbTaille.Text),
                                           CInt(tbMin.Text),
                                           CInt(tbMax.Text))

        For i = 0 To InnovationRecherche.liste.Length - 1
            Dim element As Button
            element = New Button
            element.ForeColor = Color.Black 'Couleur de police des boutons en noir
            element.Width = 40 'Affectation de la largeur
            element.Height = 40 'Affectation de la heuteur
            element.Text = liste(i)

            ReDim Preserve listeBouton(i)
            listeBouton(i) = element
        Next i

        'Afficher dans gbListe les éléments de 0 à liste.Length - 1
        '(10 et 20 sont les coordonnées du point d'origine du premier élément à afficher)
        AfficherListe(gbListe, 0, liste.Length - 1, 10, 20)
    End Sub

    'Affiche la liste des entiers entre debut et fin
    Private Sub AfficherListe(ByRef gb As GroupBox,
                              ByVal debut As Integer,
                              ByVal fin As Integer,
                              ByRef xDebut As Integer,
                              ByRef yDebut As Integer)
        Dim x = xDebut : Dim y = yDebut
        gb.Controls.Clear()

        'Pour afficher la liste des boutons
        For i = debut To fin
            listeBouton(i).Location = New Point(x, y) 'Position du bouton par rapport à l'origine (en haut à gauche)
            gb.Controls.Add(listeBouton(i))

            x += listeBouton(i).Width - 1
            If x + listeBouton(i).Width > gbListe.Width Then 'Si la position horizontale dépasse l'écran
                x = xDebut
                y += listeBouton(i).Height - 1
            End If
        Next i

        yDebut += y
    End Sub

    Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles btnRecherche.Click
        Dim position As Integer
        Dim message As String
        Dim t_debut, t_fin As Integer
        Dim tempsExecution As Integer

        For i = 0 To listeBouton.Length - 1
            listeBouton(i).BackColor = Color.Transparent
        Next

        If cbRecherche.Text = "Recherche par dichotomie" Then
            t_debut = System.DateTime.Now.Millisecond 'Donne le temps actuel en milliseconde
            position = InnovationRecherche.RechercheDichotomique(CInt(tbRecherche.Text))
            t_fin = System.DateTime.Now.Millisecond 'Donne le temps actuel en milliseconde
        Else
            t_debut = System.DateTime.Now.Millisecond 'Donne le temps actuel en milliseconde
            position = InnovationRecherche.RechercheSequentielle(CInt(tbRecherche.Text))
            t_fin = System.DateTime.Now.Millisecond 'Donne le temps actuel en milliseconde
        End If

        tempsExecution = t_fin - t_debut
        message = ""
        If position < 0 Then
            message += "Le nombre " + CStr(InnovationRecherche.element) +
                " ne se trouve pas dans la liste !"
        Else
            message += "Le nombre " +
                CStr(InnovationRecherche.element) +
                " est à la position " +
                CStr(position + 1) + " !"
            listeBouton(position).BackColor = Color.Aqua
        End If

        lblMessage.Text = message
        lblTempsExecution.Text = "Terminé en " +
            tempsExecution.ToString() +
            "ms."
    End Sub

    Private Sub btnInitialisationListener(sender As Object, e As EventArgs) _
        Handles tbTaille.TextChanged, tbMin.TextChanged, tbMax.TextChanged
        If IsNumeric(tbTaille.Text) And IsNumeric(tbMin.Text) And IsNumeric(tbMax.Text) Then 'Que des nombres
            If CInt(tbTaille.Text) >= 1 And CInt(tbTaille.Text) <= 76 _
                And CInt(tbMax.Text) < 1000 _
                And CInt(tbMin.Text) < 999 _
                And CInt(tbMax.Text) >= CInt(tbMin.Text) Then 'Règle de définitions
                If CInt(tbMax.Text) - CInt(tbMin.Text) + 1 >= CInt(tbTaille.Text) Then 'Assez de place pour mettre tous les éléments
                    btnInitialisation.Enabled = True
                Else
                    btnInitialisation.Enabled = False
                End If
            Else
                btnInitialisation.Enabled = False
            End If
        Else
            btnInitialisation.Enabled = False
        End If
    End Sub

    Private Sub btnRechercheListener(sender As Object, e As EventArgs) _
        Handles cbRecherche.TextChanged, tbRecherche.TextChanged
        If cbRecherche.Text <> "" And IsNumeric(tbRecherche.Text) Then
            btnRecherche.Enabled = True
        Else
            btnRecherche.Enabled = False
        End If
    End Sub


End Class

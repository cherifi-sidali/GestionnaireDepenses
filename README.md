# 💰 Gestionnaire de dépenses personnelles

## 📌 Description du projet

Gestionnaire de dépenses personnelles est une application développée avec .NET MAUI.

L'application permet à l'utilisateur de consulter et de gérer ses dépenses personnelles à partir de plusieurs pages.

Ce projet est réalisé dans le cadre du cours **IFM30739**.

## 🛠️ Technologies utilisées

- .NET MAUI
- C#
- XAML
- Visual Studio
- Git
- GitHub

---

# 📅 Semaine 1 - Création et préparation du projet

Durant la première semaine, nous avons préparé l'environnement de développement et créé la structure de base de l'application.

## Travail réalisé

- Installation et configuration de Visual Studio.
- Vérification de la charge de travail .NET MAUI.
- Création du projet .NET MAUI.
- Création du dépôt GitHub.
- Connexion du projet local avec GitHub.
- Création du fichier README.
- Préparation de la structure générale de l'application.
- Préparation de la maquette de l'application.
- Utilisation de Git pour suivre les modifications du projet.

## Objectif de la semaine 1

L'objectif principal était d'obtenir un projet fonctionnel et correctement configuré avant de commencer le développement des différentes pages.

---

# 📅 Semaine 2 - Tableau de bord et liste des dépenses

Durant la deuxième semaine, nous avons développé les principales pages permettant de consulter les dépenses.

## 🏠 Tableau de bord

Création de la page `TableauDeBordPage`.

Le tableau de bord constitue la page principale de l'application.

Il affiche :

- Le nom de l'application.
- Le total simulé des dépenses : **425,50 $**.
- Le nombre de transactions : **8**.
- Un bouton permettant d'accéder à la liste des dépenses.

## 📋 Liste des dépenses

Création de la page `ListeDepensesPage`.

Cette page utilise un `CollectionView` pour afficher plusieurs dépenses simulées.

Chaque dépense contient :

- Description
- Catégorie
- Date
- Montant

Exemples de dépenses :

- Restaurant - Alimentation - 20/09/2026 - 25,50 $
- Essence - Transport - 21/09/2026 - 60,00 $
- Épicerie - Alimentation - 22/09/2026 - 85,30 $

## 🔄 Navigation

Une navigation entre le tableau de bord et la liste des dépenses a été mise en place.

La commande `Navigation.PushAsync()` permet d'ouvrir une nouvelle page.

La commande `Navigation.PopAsync()` permet de retourner à la page précédente.

## Composants utilisés

Plusieurs composants XAML sont utilisés :

- `ContentPage`
- `VerticalStackLayout`
- `Label`
- `Button`
- `Image`
- `CollectionView`

## Objectif de la semaine 2

L'objectif était de créer les principales pages de consultation et de permettre à l'utilisateur de naviguer dans l'application.

---

# 📅 Semaine 3 - Détail, ajout et validation des dépenses

Durant la troisième semaine, plusieurs fonctionnalités ont été ajoutées afin de rendre l'application plus complète et interactive.

## 🔎 1. Page Détail d'une dépense

Création de la page `DetailDepensePage`.

Cette page permet d'afficher séparément :

- 📝 Description
- 🏷️ Catégorie
- 📅 Date
- 💰 Montant

Les informations de la dépense sélectionnée sont transmises de la page Liste vers la page Détail.

## 🖱️ 2. Double-clic sur une dépense

Un système de double-clic a été ajouté à la liste.

L'utilisateur peut maintenant double-cliquer sur une dépense pour ouvrir directement sa page de détail.

Cette fonctionnalité utilise un `TapGestureRecognizer` avec deux clics.

## ➕ 3. Page Ajouter une dépense

Création de la page `AjouterDepensePage`.

Cette page contient un formulaire permettant à l'utilisateur de saisir une nouvelle dépense.

Le formulaire contient :

- Un `Entry` pour la description.
- Un `Entry` pour le montant.
- Un `Picker` pour choisir la catégorie.
- Un `DatePicker` pour sélectionner la date.
- Un bouton Ajouter.
- Un bouton Retour.

## 🏷️ 4. Catégories disponibles

L'utilisateur peut choisir parmi plusieurs catégories :

- Alimentation
- Transport
- Logement
- Loisirs
- Autre

## ✅ 5. Validation du formulaire

Une validation simple est effectuée avant l'ajout d'une dépense.

L'application vérifie :

- Que la description est remplie.
- Que le montant est rempli.
- Qu'une catégorie est sélectionnée.

Si une information obligatoire est manquante, un message d'erreur est affiché.

Exemples :

`Veuillez entrer une description.`

`Veuillez entrer un montant.`

`Veuillez choisir une catégorie.`

Lorsque les informations sont correctement saisies, l'application affiche :

`La dépense a été ajoutée.`

## 💾 6. Ajout d'une dépense dans la liste

Le fonctionnement du formulaire a été amélioré.

Lorsqu'une nouvelle dépense est ajoutée :

1. Les informations du formulaire sont récupérées.
2. Une nouvelle dépense est créée.
3. La dépense est ajoutée à la liste.
4. L'utilisateur retourne à la liste.
5. La liste est automatiquement actualisée.
6. La nouvelle dépense apparaît à l'écran.

## 🔄 7. Passage de paramètres entre les pages

Le passage de paramètres entre les pages a été ajouté.

Lorsqu'une dépense est sélectionnée, ses informations sont envoyées vers `DetailDepensePage`.

Cela permet d'afficher le détail correspondant à la dépense choisie par l'utilisateur.

## 🎨 8. Amélioration de l'interface

L'apparence générale de l'application a été améliorée afin de rendre l'interface plus agréable et plus facile à utiliser.

Les pages utilisent maintenant un style commun avec :

- Un fond clair.
- Des couleurs violettes.
- Des couleurs vertes pour certains éléments importants.
- Des cartes blanches avec des coins arrondis.
- Des boutons plus visibles.
- Des icônes et des emojis.
- Une meilleure organisation des informations.

Des icônes sont utilisées pour faciliter la compréhension :

- 💰 Dépenses
- 💳 Transaction
- 📝 Description
- 🏷️ Catégorie
- 📅 Date
- ➕ Ajouter
- 👁️ Voir le détail

## 🏠 9. Amélioration du tableau de bord

Le tableau de bord a également été amélioré.

Il présente maintenant :

- Un titre plus visible.
- Une carte pour le total des dépenses.
- Une carte pour le nombre de transactions.
- Des couleurs cohérentes avec le reste de l'application.
- Des icônes.
- Un bouton permettant d'accéder aux dépenses.

## 📋 10. Amélioration de la liste des dépenses

La liste des dépenses utilise maintenant une présentation sous forme de cartes.

Chaque dépense est affichée dans une carte avec :

- Une icône 💳.
- Les informations de la dépense.
- Une bordure arrondie.
- Une présentation claire.

La page contient également :

- 👁️ Un bouton Voir le détail.
- ➕ Un bouton Ajouter une dépense.
- ← Un bouton Retour.

L'utilisateur peut également double-cliquer directement sur une dépense pour consulter son détail.

## Objectif de la semaine 3

L'objectif était de rendre l'application plus interactive et plus agréable à utiliser.

L'utilisateur peut maintenant :

1. Consulter le tableau de bord.
2. Consulter la liste des dépenses.
3. Ajouter une nouvelle dépense.
4. Voir immédiatement la nouvelle dépense dans la liste.
5. Sélectionner une dépense.
6. Double-cliquer sur une dépense.
7. Consulter son détail.
8. Voir séparément la description, la catégorie, la date et le montant.
9. Naviguer entre les différentes pages.

---

# 📱 Structure actuelle de l'application

L'application possède quatre pages principales :

### `TableauDeBordPage`

Affiche le résumé général des dépenses.

### `ListeDepensesPage`

Affiche la liste des dépenses et permet d'accéder aux autres fonctionnalités.

### `DetailDepensePage`

Affiche les informations détaillées de la dépense sélectionnée.

### `AjouterDepensePage`

Permet de remplir un formulaire et d'ajouter une nouvelle dépense.

---

# ✨ Fonctionnalités actuelles

L'application permet actuellement de :

- Consulter un tableau de bord.
- Afficher le total des dépenses.
- Afficher le nombre de transactions.
- Consulter la liste des dépenses.
- Ajouter une nouvelle dépense.
- Actualiser la liste après un ajout.
- Sélectionner une dépense.
- Double-cliquer sur une dépense.
- Consulter le détail d'une dépense.
- Afficher séparément les informations d'une dépense.
- Valider les champs obligatoires.
- Afficher des messages d'erreur.
- Afficher un message de confirmation.
- Naviguer entre les différentes pages.

---

# 📸 Captures d'écran

## Tableau de bord

![Tableau de bord](Screenshots/tableau-de-bord.png)

## Liste des dépenses

![Liste des dépenses](Screenshots/liste-depenses.png)

## Détail d'une dépense

![Détail d'une dépense](Screenshots/detail-depense.png)

## Ajouter une dépense

![Ajouter une dépense](Screenshots/ajouter-depense.png)

---

# ▶️ Comment exécuter le projet

1. Télécharger ou cloner le dépôt GitHub.
2. Ouvrir le projet dans Visual Studio.
3. Vérifier que la charge de travail .NET MAUI est installée.
4. Ouvrir la solution du projet.
5. Sélectionner **Windows Machine** comme cible d'exécution.
6. Cliquer sur **Démarrer** pour lancer l'application.

---

# 🌐 Git et GitHub

Git et GitHub sont utilisés pour suivre le développement du projet.

Les modifications réalisées durant les différentes semaines sont enregistrées avec des commits afin de conserver l'historique du développement.

GitHub permet également aux membres de l'équipe de collaborer sur le même projet.

---

# 👥 Équipe

Projet réalisé en équipe dans le cadre du cours **IFM30739**.

---

# 🚀 État du projet

**Phase 1 - Semaine 3 terminée.**

Travail réalisé jusqu'à maintenant :

- ✅ Configuration du projet.
- ✅ Création du dépôt GitHub.
- ✅ Création du tableau de bord.
- ✅ Création de la liste des dépenses.
- ✅ Création de la page de détail.
- ✅ Création du formulaire d'ajout.
- ✅ Ajout réel des nouvelles dépenses dans la liste.
- ✅ Actualisation de la liste.
- ✅ Validation des champs.
- ✅ Passage de paramètres entre les pages.
- ✅ Double-clic pour consulter une dépense.
- ✅ Navigation entre les différentes pages.
- ✅ Amélioration de l'ergonomie.
- ✅ Amélioration des couleurs et de l'interface.
- ✅ Utilisation de Git et GitHub.
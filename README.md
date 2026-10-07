# Gestionnaire de dépenses personnelles

## Description du projet

Gestionnaire de dépenses personnelles est une application développée avec .NET MAUI.

L'application permet à l'utilisateur de consulter et de gérer ses dépenses personnelles à partir de plusieurs pages.

Ce projet est réalisé dans le cadre du cours IFM30739.

## Technologies utilisées

- .NET MAUI
- C#
- XAML
- Visual Studio
- Git
- GitHub

---

# Semaine 1 - Création et préparation du projet

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
- Utilisation de Git pour le suivi des modifications.

## Objectif de la semaine 1

L'objectif principal était d'avoir un projet fonctionnel et correctement configuré avant de commencer le développement des différentes pages.

---

# Semaine 2 - Tableau de bord et liste des dépenses

Durant la deuxième semaine, nous avons commencé à développer les principales pages de l'application.

## 1. Tableau de bord

Création de la page `TableauDeBordPage`.

Le tableau de bord constitue la page principale de l'application.

Il affiche :

- Le nom de l'application.
- Le total simulé des dépenses : 425,50 $.
- Le nombre de transactions : 8.
- Un bouton permettant d'accéder à la liste des dépenses.

## 2. Liste des dépenses

Création de la page `ListeDepensesPage`.

Cette page utilise un `CollectionView` pour afficher plusieurs dépenses simulées.

Chaque dépense contient :

- Description
- Catégorie
- Date
- Montant

Exemples :

- Restaurant - Alimentation - 20/09/2026 - 25,50 $
- Essence - Transport - 21/09/2026 - 60,00 $
- Épicerie - Alimentation - 22/09/2026 - 85,30 $

## 3. Navigation

Une navigation entre le tableau de bord et la liste des dépenses a été mise en place.

La commande `Navigation.PushAsync()` permet d'ouvrir une nouvelle page.

La commande `Navigation.PopAsync()` permet de retourner à la page précédente.

Un menu de navigation permet également d'accéder aux différentes sections de l'application.

## 4. Interface

Plusieurs composants XAML ont été utilisés :

- `ContentPage`
- `VerticalStackLayout`
- `Label`
- `Button`
- `Image`
- `CollectionView`

## Objectif de la semaine 2

L'objectif était de créer les principales pages de consultation de l'application et de permettre à l'utilisateur de naviguer entre elles.

---

# Semaine 3 - Détail, ajout et validation des dépenses

Durant la troisième semaine, de nouvelles fonctionnalités ont été ajoutées afin de permettre à l'utilisateur de consulter le détail d'une dépense et de remplir un formulaire pour ajouter une nouvelle dépense.

## 1. Page Détail d'une dépense

Création de la page `DetailDepensePage`.

Cette page permet d'afficher les informations détaillées d'une dépense :

- Description
- Catégorie
- Date
- Montant

Un bouton **Voir le détail** a été ajouté à la liste des dépenses.

Lorsque l'utilisateur clique sur ce bouton, l'application ouvre la page de détail.

Un bouton **Retour** permet de revenir à la page précédente.

## 2. Page Ajouter une dépense

Création de la page `AjouterDepensePage`.

Cette page contient un formulaire permettant de saisir une nouvelle dépense.

Le formulaire contient :

- Un `Entry` pour la description.
- Un `Entry` pour le montant.
- Un `Picker` pour la catégorie.
- Un `DatePicker` pour la date.
- Un bouton **Ajouter**.
- Un bouton **Retour**.

## 3. Catégories disponibles

Le `Picker` permet de choisir parmi plusieurs catégories :

- Alimentation
- Transport
- Logement
- Loisirs
- Autre

## 4. Validation du formulaire

Une validation simple a été ajoutée.

Avant d'accepter le formulaire, l'application vérifie :

- Que la description est remplie.
- Que le montant est rempli.
- Qu'une catégorie est sélectionnée.

Si une information est manquante, un message d'erreur est affiché.

Exemples :

`Veuillez entrer une description.`

`Veuillez entrer un montant.`

`Veuillez choisir une catégorie.`

Lorsque les informations sont correctement saisies, l'application affiche :

`La dépense a été ajoutée.`

## 5. Amélioration de la navigation

La page `ListeDepensesPage` contient maintenant trois boutons :

- **Voir le détail**
- **Ajouter une dépense**
- **Retour**

L'application possède maintenant quatre pages principales :

1. `TableauDeBordPage`
2. `ListeDepensesPage`
3. `DetailDepensePage`
4. `AjouterDepensePage`

## 6. Composants utilisés pendant la semaine 3

Nous avons utilisé plusieurs composants .NET MAUI :

- `Label`
- `Entry`
- `Picker`
- `DatePicker`
- `Button`
- `ScrollView`
- `VerticalStackLayout`
- `CollectionView`

## Objectif de la semaine 3

L'objectif était de rendre l'application plus interactive en permettant à l'utilisateur :

- De consulter ses dépenses.
- De consulter le détail d'une dépense.
- D'ouvrir un formulaire d'ajout.
- De saisir les informations d'une dépense.
- De valider les champs.
- De naviguer entre les différentes pages.

---

# Fonctionnalités actuelles de l'application

L'application permet actuellement de :

- Consulter le tableau de bord.
- Voir le total simulé des dépenses.
- Voir le nombre de transactions.
- Consulter la liste des dépenses.
- Voir le détail d'une dépense.
- Ouvrir le formulaire d'ajout.
- Saisir une description.
- Saisir un montant.
- Choisir une catégorie.
- Sélectionner une date.
- Valider les champs obligatoires.
- Naviguer entre les différentes pages.

---

# Captures d'écran

## Tableau de bord

![Tableau de bord](Screenshots/tableau-de-bord.png)

## Liste des dépenses

![Liste des dépenses](Screenshots/liste-depenses.png)

## Détail d'une dépense

![Détail d'une dépense](Screenshots/detail-depense.png)

## Ajouter une dépense

![Ajouter une dépense](Screenshots/ajouter-depense.png)

---

# Comment exécuter le projet

1. Télécharger ou cloner le dépôt GitHub.
2. Ouvrir le projet dans Visual Studio.
3. Vérifier que la charge de travail .NET MAUI est installée.
4. Ouvrir la solution du projet.
5. Sélectionner **Windows Machine** comme cible d'exécution.
6. Cliquer sur **Démarrer** pour lancer l'application.

---

# Utilisation de Git et GitHub

Git et GitHub sont utilisés pour suivre le développement du projet.

Les modifications réalisées durant chaque semaine sont enregistrées avec des commits afin de conserver l'historique du développement de l'application.

---

# Équipe

Projet réalisé en équipe dans le cadre du cours IFM30739.

---

# État du projet

**Phase 1 - Semaine 3 terminée.**

Travail réalisé jusqu'à maintenant :

- Configuration du projet.
- Création du dépôt GitHub.
- Création du tableau de bord.
- Création de la liste des dépenses.
- Création de la page de détail.
- Création du formulaire d'ajout.
- Ajout des champs de saisie.
- Ajout des catégories.
- Ajout du DatePicker.
- Ajout de la validation.
- Ajout des messages d'erreur et de confirmation.
- Mise en place de la navigation.
- Utilisation de Git et GitHub.

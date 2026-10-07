## Semaine 3 - Détail, ajout et validation des dépenses

Durant la semaine 3, nous avons poursuivi le développement de l'application en ajoutant de nouvelles fonctionnalités permettant à l'utilisateur de consulter le détail d'une dépense et d'ajouter une nouvelle dépense.

### 1. Création de la page Détail d'une dépense

Une nouvelle page `DetailDepensePage` a été créée.

Cette page permet d'afficher les informations détaillées d'une dépense :

- Description de la dépense
- Catégorie
- Date
- Montant

Un bouton **Voir le détail** a été ajouté dans la page de la liste des dépenses.

Lorsque l'utilisateur clique sur ce bouton, l'application ouvre la page de détail.

Un bouton **Retour** permet ensuite de revenir à la page précédente.

### 2. Création de la page Ajouter une dépense

Une nouvelle page `AjouterDepensePage` a été créée.

Cette page contient un formulaire permettant à l'utilisateur de saisir les informations d'une nouvelle dépense.

Le formulaire contient les contrôles suivants :

- `Entry` pour saisir la description.
- `Entry` pour saisir le montant.
- `Picker` pour choisir une catégorie.
- `DatePicker` pour sélectionner la date.
- `Button` pour ajouter la dépense.
- `Button` pour retourner à la page précédente.

Les catégories proposées sont :

- Alimentation
- Transport
- Logement
- Loisirs
- Autre

### 3. Validation du formulaire

Une validation simple a été ajoutée avant l'ajout d'une dépense.

L'application vérifie :

- Si la description a été saisie.
- Si le montant a été saisi.
- Si une catégorie a été sélectionnée.

Si une information obligatoire est manquante, un message d'erreur est affiché à l'utilisateur.

Exemple :

`Veuillez entrer une description.`

ou :

`Veuillez choisir une catégorie.`

Si toutes les informations sont correctement saisies, l'application affiche un message de confirmation :

`La dépense a été ajoutée.`

### 4. Navigation entre les pages

La navigation de l'application a été améliorée.

L'utilisateur peut maintenant naviguer entre :

1. Le tableau de bord.
2. La liste des dépenses.
3. Le détail d'une dépense.
4. Le formulaire d'ajout d'une dépense.

La navigation entre les pages est réalisée avec `Navigation.PushAsync()`.

Le retour à la page précédente est réalisé avec `Navigation.PopAsync()`.

### 5. Amélioration de la liste des dépenses

La page `ListeDepensesPage` contient maintenant :

- La liste des dépenses existantes.
- Un bouton **Voir le détail**.
- Un bouton **Ajouter une dépense**.
- Un bouton **Retour**.

Le bouton **Voir le détail** permet d'accéder à `DetailDepensePage`.

Le bouton **Ajouter une dépense** permet d'accéder à `AjouterDepensePage`.

### 6. Ergonomie de l'application

L'interface a été organisée afin de rester simple et facile à utiliser.

Les différents éléments utilisent notamment :

- `Label`
- `Entry`
- `Picker`
- `DatePicker`
- `Button`
- `CollectionView`
- `VerticalStackLayout`
- `ScrollView`

L'utilisation d'un `ScrollView` dans le formulaire permet de conserver l'accès aux différents champs même lorsque l'espace disponible sur l'écran est limité.

### 7. Résultat de la semaine 3

À la fin de la semaine 3, l'application possède quatre pages principales :

- `TableauDeBordPage`
- `ListeDepensesPage`
- `DetailDepensePage`
- `AjouterDepensePage`

L'utilisateur peut consulter ses dépenses, afficher le détail d'une dépense, ouvrir un formulaire pour ajouter une nouvelle dépense et naviguer entre les différentes pages.

## État du projet

Phase 1 - Semaine 3.

Fonctionnalités réalisées jusqu'à maintenant :

- Création du tableau de bord.
- Affichage du total des dépenses.
- Affichage du nombre de transactions.
- Création de la liste des dépenses.
- Affichage des informations des dépenses.
- Création de la page de détail.
- Création du formulaire d'ajout.
- Ajout des champs de saisie.
- Ajout du choix de catégorie.
- Ajout de la sélection de date.
- Ajout de la validation des champs.
- Ajout des messages d'erreur et de confirmation.
- Navigation entre les différentes pages.
- Utilisation de Git et GitHub pour le suivi du projet.
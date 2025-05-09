# Application de Gestion de Personnel

## Présentation

Cette application de bureau développée en **C#** permet la gestion du personnel d'une entreprise. Elle s'appuie sur une base de données **SQL Server** pour stocker les informations des employés. L'interface utilisateur permet d'ajouter, modifier, supprimer et consulter les employés de manière simple et intuitive.

## Fonctionnalités principales

- Ajouter un employé
- Modifier les informations d’un employé existant
- Supprimer un employé
- Afficher la liste complète du personnel
- recherche
- Connexion

## Technologies utilisées

- **Langage** : C#
- **Framework** : .NET (Windows Forms ou WPF)
- **Base de données** : SQL Server
- **IDE** : Visual Studio

## Prérequis

- Visual Studio 2019 ou plus récent
- .NET Desktop Runtime (selon le framework utilisé)
- SQL Server (local ou distant)

## Structure de la base de données

Voici un exemple de script SQL pour créer la table `personne` :

```sql
create table personne
(
	idP bigint identity(1,1) not null,
	nom varchar(50) not null,
	postnom varchar(50),
	prenom varchar(50),
	sexe varchar(1) default 'M' not null
);

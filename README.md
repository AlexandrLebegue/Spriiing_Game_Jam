# BOGUE (Spriiing_Game_Jam 2023)

Notre jeux qui défonce tout :)

Bravo à notre artiste Patricia, à bébou Fabien, weebu Aurélien et pipou Alexandre.

## Introduction.

Jeu pour répondre à la thématique « Revers » de la Spring Game Jam.

Met en scène Bogue, une petite chataigne tombée de son arbre et qui se retrouve confrontée à des souvenirs traumatiques représentés par un oiseau. Bogue alterne entre le monde lumineux où elle s'éveille et les phasess traumatiques dont iel sort fissuré·e. 

Au terme du jeu, Bogue accepte ses blessures, ce qui lui permet d’éclore et de se planter pour devenir un bel arbre.

## Partie conception fonctionnelle :
### Univers. (Ambiance, thème(s) abordé(s), genre vidéoludique, émotion(s) recherchée(s)…)

Plateformer 2D alternant entre deux boucles de gameplay : une **action** et une **puzzle**

---
Thématique(s) narrative(s) : changement après l'enfance, adolescence, transition(s) en général (c'est pas une copie de *Celeste* promis). Accepter ses traumatismes et en ressortir grandi·e

Deux ambiances distinctes :
- **Monde de l'éveil** très lumineux, ouvert. Thématique sylvestre. Peut-être quelques éléments déroutants quand même ? Un peu grisâtre (voire brumeux) quand même -> REVERDIT à la fin lorsque Bogue se plante. Pluie ??
<br/>*Inspirations* : Ori and the Blind Forest
- **Monde des traumas** plutôt effrayant. Cyclopéen et clostrophobique en même temps, un peu comme le level design de Little Nightmares (?)
<br/>*Inspirations* : Ori and the Blind Forest

>Peut-être réfléchir à une possibilité de "merge" les deux mondes à la fin ?

Alternance de **phases ambiantes**, calmes et contemplatives avec des **phases stressantes** et claustrophobiques.
<br/>Fin du jeu contemplative et lumineuse (+ touche d'humour si "Bogue plante")

### Game & Narrative Design

1. Phase plutôt contemplative (peut-être un peu triste/morne ?). Gameplay et gamefeel plutôt lent
Bogue apprend à se déplacer et expérimenter les premières mécaniques de jeu.
2. Transition brutale (glitch) dans le "monde des traumas". Ambiance anxiogène, Bogue est poursuivi (entre des racines ?) par l'oiseau (le rendre un peu figuratif ?)
Gamefeel toujours assez lent pour créer un sentiment d'urgence. Application des mécaniques apprises dans un contexte plus impliquant
>Développer transition
3. Bogue partient à se "réveiller". Retour au "monde de l'éveil" (fin de la vision ?), de nuit peut-être ?, l'oiseau est tooujours présent sous forme éthérée.
<br/> Bogue doit apprendre à "switch" entre les deux mondes pour résoudre les puzzles en utilisant l'oiseau
>Possiilité d'inclure un tableau "inversion" où on contrôle l'oiseau pourchassant Bogue pour comprendre que celui-ci peut aider à résoudre les puzzles

### Personnages. (Personnalités, idées lié au charadesign…)

- **Bogue** : petite chataigne dépressive
- **L'oiseau** : antagoniste aveugle représentant métaphoriquement les traumatismes de Bogue. Retournement de son utilisation lorsqu'il sert à Bogue pour progresser dans le jeu

##  Partie conception technique :
### Technologies 
Unity 2D

### Gameplay. (Le type de jeu, les possibilités et les modes de jeu, les niveaux, l’expérience utilisateur…) **

4 "niveaux"/tableaux :
1. intro/monde lumineux : plateformer action lent (phase "tutorielle")
2. monde des traumas : action plateformer (phases de poursuite dans *Celeste* ou *Inmost* quitte à essayer de "scénariser" un peu si possible)
3. retour au monde lumineux (niveau en biphase) : puzzle plateforme. Mécanique de swap pour trigger les déplacements de l'oiseau sur le modèle des poisson-rêve de Celeste ?
4. cinématique de fin

### Level Design

Même Level Design entre les deux mondes (accentue idée de "revers")
-> Ajout de l'oiseau + des obstacles divers

D'abord level de gauche à droite puis de droite à gauche
Juste effets visuels pour l'alternance de niveau ?

### IHM

Lorem Ipsum

### Graphismes 
*(Le style artistique, les couleurs, croquis, artwork, charadesign…)*

### Audio

Lorem Ipsum

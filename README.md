# BOGUE (Spriiing_Game_Jam 2023)

Notre jeux qui défonce tout :)

Bravo à notre artiste Patricia, à bébou Fabien, weebu Aurélien et pipou Alexandre.

## Introduction.

Jeu pour répondre à la thématique « Revers » de la Spring Game Jam.

Met en scène Bogue, une petite chataigne tombée de son arbre et qui se retrouve confrontée à des souvenirs traumatiques représentés par un oiseau. Bogue alterne entre le monde lumineux où elle s'éveille et les phasess traumatiques dont elle sort fissurée. 

Au terme du jeu, Bogue accepte ses blessures, ce qui lui permet d’éclore et de se planter pour devenir un bel arbre.

## Partie conception fonctionnelle :
### Univers. (Ambiance, thème(s) abordé(s), genre vidéoludique, émotion(s) recherchée(s)…)

Plateformer 2D alternant entre deux boucles de gameplay : une **action** et une **puzzle**

---
Thématique(s) narrative(s) : changement après l'enfance, adolescence, transition(s) en général (c'est pas une copie de *Celeste* promis). Accepter ses traumatismes et en ressortir grandie

Deux ambiances distinctes :
- **Monde de l'éveil :**  Thématique sylvestre.  Un peu grisâtre (voire brumeux) quand même -> REVERDIT à la fin lorsque Bogue se plante. Pluie ?? Gris-vert
<br/>*Inspirations* : Inmost, Ori and the blind forest
- **Monde des traumas :** Pendant du monde de l'éveil (même niveau en inversé) Violet-noir
<br/>*Inspirations* : Limbo

>Peut-être réfléchir à une possibilité de "merge" les deux mondes à la fin ?

Alternance de **phases ambiantes**, calmes et contemplatives avec des **phases stressantes** et claustrophobiques.
<br/>Fin du jeu contemplative et lumineuse (+ touche d'humour si "Bogue plante")

### Game & Narrative Design

1. Phase plutôt contemplative (peut-être un peu triste/morne ?). Gameplay et gamefeel plutôt lent
Bogue apprend à se déplacer.
2. Transition brutale (glitch) dans le "monde des traumas". Ambiance anxiogène, Bogue est poursuivi (entre des racines ?) par l'oiseau (le rendre un peu figuratif ?)
Gamefeel toujours assez lent pour créer un sentiment d'urgence. Mécaniques permettant de parcourir le niveau dans l'autre sens
Elle tombe à plusieurs reprise se qui fendille sa coque.
3. Bogue partient à se "réveiller". Scène de fin dans forêt ensoleillée

>Développer transition

*[Retour au "monde de l'éveil" (fin de la vision ?), de nuit peut-être ?, l'oiseau est toujours présent sous forme éthérée.
<br/> Bogue doit apprendre à "switch" entre les deux mondes pour résoudre les puzzles en utilisant l'oiseau
Possilité d'inclure un tableau "inversion" où on contrôle l'oiseau pourchassant Bogue pour comprendre que celui-ci peut aider à résoudre les puzzles]*

### Personnages. (Personnalités, idées lié au charadesign…)

- **Bogue** : petite chataigne dépressive
- **L'oiseau** : antagoniste aveugle représentant métaphoriquement les traumatismes de Bogue. Retournement de son utilisation lorsqu'il sert à Bogue pour progresser dans le jeu

##  Partie conception technique :
### Technologies 
Unity 2D

### Gameplay. (Le type de jeu, les possibilités et les modes de jeu, les niveaux, l’expérience utilisateur…) **

4 "niveaux"/tableaux :
1. intro/monde de l'éveil : plateformer action lent (phase "tutorielle")
2. monde des traumas : action plateformer (phases de poursuite dans *Celeste* ou *Inmost* quitte à essayer de "scénariser" un peu si possible)
3. Scène final : forêt ensoleillée

*[3. retour au monde lumineux (niveau en biphase) : puzzle plateforme. Mécanique de swap pour trigger les déplacements de l'oiseau sur le modèle des poisson-rêve de Celeste ?
4. cinématique de fin]*

### Level Design

Même Level Design entre les deux mondes (accentue idée de "revers")
-> Ajout de l'oiseau + des obstacles divers

D'abord de gauche à droite -> uniquement faisable dans ce sens
Puis au bout acquisition d'un pouvoir + transition monde trauma

Monde de droite à gauche avec le pouvoir + oiseau qui nous pousse à avancer

#### WakeMeUpInside


#### Dark World
- Chute dans une grotte -> on ne voit plus que ses yeux

### IHM

Lorem Ipsum

### Graphismes 

Inspiration visuelle : Ori and the blind forest

### Sound Design

- Ambiance forêt
- Pluie
- (Chants d'oiseau ?)


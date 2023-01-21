
[English version below]

Fonctionnel :
- Ouverture d'une fenêtre en allant sur "Window > Custom > Show Gizmos".
- Ouverture d'une fenêtre lorsque l'on double clique sur le Scriptable Object.
- Affichage des données dans la fenêtre stockés dans le Scriptable Object.
- Les données sont sauvegardées en direct lorsque l'on écrit.
- Affichage des sphères blanches aux positions données.
- Affichage des textes noirs aux positions données.
- Déplacement des sphères avec le bouton "Edit".
- Déplacement des sphères avec l'outil de déplacement par défaut.
- Sauvegarde des données en direct lorsque l'on déplace une sphère.
- L'affichage ne se fait que dans la Scene View.
- Rien n'est affiché dans la hiérarchie.

Je me suis permis d'interpréter le sujet sur les détails manquants.
Une seule fenêtre ne peut être ouverte à la fois, si on tente d'en ouvrir une nouvelle, celle-ci va seulement rediriger vers la fenêtre déjà existante.
Si on ouvre une fenêtre depuis "Window > Custom > Show Gizmos" alors qu'aucune n'est ouverte, les données seront récupérées depuis un Scriptable Object par défaut.
Dans le cas où le Scriptable object par défaut n'est pas trouvé, il ouvrira une fenêtre sans donnée et créera un nouvel Scriptable Object.
Si une fenêtre est déjà ouverte et que l'on clique sur un nouvel Scriptable Object, la fenêtre changera pour afficher les nouvelles données.

Je me suis également permis des modifications afin que vous puissiez juger mes capacités d'adaptation.
Pour afficher des sphères avec du texte dans la Scene View, des objets sont créés en invisible, puis utilisent des Gizmos et des Handles afin de s'afficher dans la Scene View.
Les objets sont détruits directement lorsque la fenêtre est fermée.
Le bouton "Hidden Objects > Hide Show Objects" vous permet d'afficher/cacher les objets créés en cas de besoin.vers

Note :
Unity peut parfois cacher les objets.
Mais vous pouvez les faire réapparaitre :
- En ouvrant à nouveau une fenêtre
- En cliquant sur Le bouton "Hidden Objects > Hide Show Objects" puis en interagissant avec eux dans la hiérarchie.




Functional:
- Opening a window by going to "Window > Custom > Show Gizmos".
- Opening a window when double clicking on the Scriptable Object.
- Display data in the window stored in the Scriptable Object.
- Data is saved live as you write.
- Display of white spheres at given positions.
- Display of black texts at the given positions.
- Moving the spheres with the "Edit" button.
- Moving the spheres with the default moving tool.
- Live data saving when moving a sphere.
- The display is only done in the Scene View.
- Nothing is displayed in the hierarchy.

I took the liberty of interpreting the subject on the missing details.
Only one window can be opened at a time, if you try to open a new one, it will only redirect to the existing window.
If you open a window from "Window > Custom > Show Gizmos" when none is open, the data will be retrieved from a Scriptable Object by default.
In case the default Scriptable object is not found, it will open a window without data and create a new Scriptable Object.
If a window is already open and a new Scriptable Object is open, the window will change to show the new data.

I also allowed myself some modifications so that you can judge my adaptability.
To display spheres with text in the Scene View, objects are created invisibly, then use Gizmos and Handles to display in the Scene View.
The objects are destroyed directly when the window is closed.
The button "Hidden Objects > Hide Show Objects" allows you to show/hide the created objects if needed.

Note :
Unity can sometimes hide objects.
But you can make them reappear:
- By opening a new window
- By clicking on the "Hidden Objects > Hide Show Objects" button and then interacting with them in the hierarchy.
#Programme mettant en place Dijkstra en utilisant la programmation dynamique
class Noeud:#classe représentant les noeuds du graphe

    nom = ""
    suivants = []   #Liste des noeuds suivants
    couts = []      #Liste des coûts des chemins vers les noeuds suivants (rangé dans le même ordre que "suivants"
    precedants = [] #Liste des noeuds précédents

    def __init__(self):
        self.nom = ""
        self.suivants = []
        self.couts = []
        self.precedants = []


    def setNom(self, name):
        self.nom = name

    def addSuivant(self, next):
        self.suivants.append(next)

    def addCouts(self, costs):
        self.couts.append(costs)

    def addPrecedants(self, pred):
        self.precedants.append(pred)


#Lecture fichier de données et enregistrement dans la variable lines
file = open("C:/Users/THEO/Documents/UQAC/Algo/Projet2/donnees.txt","r")   
lines = file.readlines()
file.close()

#Création des listes contenant les noeuds et les noms des noeuds
listeNoeuds = []
listeNoms = []

#Création de tous les noeuds et rangement dans la liste "ListeNoeuds"
for line in lines:
    if(len(line.strip()) == 1):
        newNoeud = Noeud()
        newNoeud.setNom(line.strip())
        listeNoeuds.append(newNoeud)
        listeNoms.append(line.strip())
    else:
        for i in listeNoeuds:
            if(i.nom == line.strip()[0]):
                i.addSuivant(line.strip()[2])
                i.addCouts(line.strip()[4])
            if(i.nom == line.strip()[2]):
                i.addPrecedants(line.strip()[0])

#Affichage de tous les noeuds
for i in listeNoeuds:
    print(i.nom)
    print(i.suivants)
    print(i.couts)
    print(i.precedants)

#####Dijkstra
#Initialisation des variables
infini = 999999
j = 0
listeCouts = [] #On enregistre les coûts de chaque noeuds dans cette liste
listeCouts.append(0)
n = len(listeNoeuds)
for i in range(1,n):
    listeCouts.append(infini)

#Boucle de calcul
while(j!=n-1 and j<infini):
    #On enregistre le noeud courant
    courant = listeNoeuds[j]
    k = 0
    #On parcours les noeuds suivants et on mets à jour les coûts
    for noeudsSuivants in courant.suivants:
        suivant = listeNoeuds[listeNoms.index(noeudsSuivants)]
        i = listeNoms.index(noeudsSuivants)
        if(listeCouts[i]>listeCouts[j]+int(courant.couts[k])):
            listeCouts[i] = listeCouts[j]+int(courant.couts[k])
        k+=1
    #On met j à jour en prenant le noeuds de poids le plus faible 
    min = infini
    for i in range(j+1,n):
        if(listeCouts[i]<min):
            min = listeCouts[i]
            j = i

#Affichage des coûts
print(listeCouts)
namespace SiteOnepiece.Models
{
    
    public class BaseDeDonnées
    {
        public List<Enfant> Enfants { get; set; }

        public List<Parent> Parents { get; set; }

        public BaseDeDonnées()
        {
            Enfants = new List<Enfant>();
            Parents = new List<Parent>();

            // Creation des 3 parents

            //Parents.Add(new Parent()
            //{
            //    Id = 1,
            //    Nom = "Logia",
            //    Description = "Logia est le nom donné à un type de Fruit du Démon. Il est caractérisé par\r\nle fait qu'il donne à son utilisateur le pouvoir de prendre la forme\r\nd'un élément naturel, de le produire et le contrôler à volonté.",
            //    MoyennePrime = 170,
            //    nombreUtilisateur = 17,
            //    ImageURL = "/images/Suna_Suna_no_Mi_Infobox.jpg"
            //});
            //Parents.Add(new Parent()
            //{
            //    Id = 2,
            //    Nom = "Zoan",
            //    Description = "Zoan est le nom donné à un type de Fruit du Démon permettant à son utilisateur de se transformer en animal ou en une créature hybride (moitié espèce animale et moitié espèce de l'utilisateur, souvent humain) à volonté.",
            //    MoyennePrime = 636,
            //    nombreUtilisateur = 80,
            //    ImageURL = "/images/Gomu_Gomu_no_Mi_Infobox.jpg"
            //});
            //Parents.Add(new Parent()
            //{
            //    Id = 3,
            //    Nom = "Paramecia",
            //    Description = "Paramecia donnent aux utilisateurs un pouvoir \"surhumain\" qui peut affecter son corps, manipuler l'environnement ou produire une substance quelconque. Modifier. Permet de durcir son corps à volonté et augmenté la température des parties tempérés.",
            //    MoyennePrime = 162,
            //    nombreUtilisateur = 96,
            //    ImageURL = "/images/Ope_Ope_no_Mi_Infobox.jpg"
            //});

            //// Creation des 12 Enfants

            //Enfants.Add(new Enfant()
            //{
            //    id = 1,
            //    IdParent = 1,
            //    Description = "Marshall D. Teach, mieux connu sous le nom de Barbe Noire (黒ひげ, Kurohige), est l'Amiral de l'Équipage de Barbe Noire et fait actuellement partie des Quatre Empereurs.\r\n\r\nTeach est un ancien membre de la seconde division de l'Équipage de Barbe Blanche qui fut dirigée par Portgas D. Ace. Il tue Thatch, Commandant de la quatrième division, pour s'approprier le Yami Yami no Mi. Il devint temporairement l'un des 7 Grands Corsaires en battant Ace et en le livrant à la Marine, mais il décide d'abandonner son titre après que son équipage et lui eurent tué Barbe Blanche lors du siège de Marine Ford.\r\n\r\nIl est l'un des antagonistes principaux de One Piece et la seule personne connue à avoir absorbé deux Fruits du Démon différents.",
            //    Prime = 3996000000,
            //    Nom = "BlackBeard",
            //    NomFruitDemon = " Yami Yami no Mi",
            //    Equipage = "BlackBeard pirates",
            //    Occupation = "Yonko",
            //    ImageURL = "/images/BlackBeard.jpg",
            //    ageDebut = 28,
            //    agePrensent = 20,
            //    typeDeFruit = "logia",
            //    EstVedette = true


            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 2,
            //    IdParent = 1,
            //    Description = "Akainu (nom signifiant chien rouge) est un des 3 amiraux de la Marine et donc un de ses membres les plus forts. Il porte tout le temps une casquette ainsi que des gants. Il a une très grande confiance en lui et en sa force. C'est un homme cruel et sans scrupule qui n'hésite pas à tuer des innocents.Il ne fait preuve d'aucune pitié, que ce soit envers ses ennemis ou envers les soldats de la Marine. Il est adepte d'une justice absolue et est donc l'amiral le plus dur et le plus implacable.",
            //    Prime = 0,
            //    Nom = "Akainu",
            //    NomFruitDemon = " Magu Magu no Mi",
            //    Equipage =  "Marine",
            //    Occupation = "Admiral de la marine",
            //    ImageURL = "/images/Akainu.jpg",
            //    ageDebut = 48,
            //    agePrensent = 50,
            //    typeDeFruit = "logia",
            //    EstVedette = true
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 3,
            //    IdParent = 1,
            //    Description = "Kizaru utilise la caractéristique principale de la lumière : sa vitesse. Il peut ainsi se téléporter rapidement d'un endroit à un autre, rattrapant facilement des fuyards. La rapidité de ses coups est également dévastatrice, le combat contre les Supernovaes en est une preuve.",
            //    Prime = 0,
            //    Nom = "Kizaru",
            //    NomFruitDemon = "Pika Pika no Mi ",
            //    Equipage = "Marine",
            //    Occupation = "Admiral de la marine",
            //    ImageURL = "/images/tumblr_332e0c173459ad22272524d85ee374fd_f7cc668e_500.png",
            //    ageDebut = 48,
            //    agePrensent = 50,
            //    typeDeFruit = "logia",
            //    EstVedette = true
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 4,
            //    IdParent = 1,
            //    Description = "Crocodile, plus connu sous le titre de Sir Crocodile (サー･クロコダイル, Sā Kurokodairu) ou de Mr. 0 (ミスター・ゼロ, Misutā Zero), fut le président de Baroque Works et l'antagoniste principal de la Saga Baroque Works. Son nom de code dans l'organisation était Mr. 0. Il est le premier ennemi de la série qui a duré aussi longtemps et fut le premier ennemi à avoir réellement battu Luffy. Il fut d'abord présenté comme l'un des 7 capitaines corsaires, mais il fut dépouillé de son titre lorsqu'il a essayé de prendre le contrôle d'Alabasta, le royaume du désert. Il a d'abord été présenté comme étant un ennemi majeur de Luffy, cependant, tous les deux ont formé une alliance difficile et improbable lors de leur évasion d'Impel Down et la deuxième moitié de la Bataille de Marine Ford.\r\n\r\nDepuis l'arrêt de l'institution des Sept Grands Corsaires, il est l'un des membres prééminent de la Cross Guild",
            //    Prime = 1965000000,
            //    Nom = "Crocodile",
            //    NomFruitDemon = "Suna Suna no Mi ",
            //    Equipage = "Cross guild",
            //    Occupation = "Cross guild",
            //    ImageURL = "/images/crocoboy.jpg",
            //    ageDebut = 28,
            //    agePrensent = 20,
            //    typeDeFruit = "logia",
            //    EstVedette = false
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 5,
            //    IdParent = 2,
            //    Description = "Luffy est facilement reconnaissable à son chapeau de paille, un chapeau qui lui a été donné par un pirate nommé Shanks « le roux », son idole depuis son enfance. Ce dernier s'est fait arracher le bras gauche en sauvant Luffy. Il est aussi reconnaissable par la cicatrice sous l'œil gauche, qui fait penser à son grand-père Garp, et qu'il s'est lui-même infligé pour prouver sa bravoure à Shanks et son équipage. Pendant son changement physique Gear Second, le corps de Luffy s'assombrit, brille, et devient plus fluide. Lorsqu'il était enfant, Luffy a pour la première fois été intronisé par le port d'un tee-shirt blanc et d'un shirt bleu. Dans One Piece, Luffy porte un chandail rouge, un pantacourt bleu et des sandales. Après l'ellipse des deux ans, Luffy remplace son chandail par une veste rouge à manches longues et porte également une écharpe jaune autour de sa taille. Luffy est un garçon insouciant qui fait souvent preuve d'imprudence et de hardiesse. Il invite de nombreux autres personnages, tels que Chopper ou Brook, généralement pour rejoindre son équipage.\r\n",
            //    Prime = 3000000000,
            //    Nom = "Luffy",
            //    NomFruitDemon = "Hito Hito no mi : model Nika ",
            //    Equipage = "StrawHat pirates",
            //    Occupation = "Yonko",
            //    ImageURL = "/images/luffy.jpg",
            //    ageDebut = 19,
            //    agePrensent = 21,
            //    typeDeFruit = "Zoan",
            //    EstVedette = true
            //});
            //Enfants.Add(new Enfant()
            //{
            //    id = 6,
            //    IdParent = 2,
            //    Description = "Marco était le commandant de la Première Division de L'Équipage de Barbe Blanche.Il est connu aussi sous le nom de \"Marco le Phénix\" et doit son surnom au pouvoir du Fruit du Démon de type Zoan Mythique qui lui permet de se transformer en phénix et de se régénérer à volonté. Marco était le bras droit et le second du Yonko Barbe Blanche ainsi que son confident le plus proche. Suite à la Guerre de Représailles, Marco est retourné à Sphinx, l'île de naissance de son défunt capitaine, où il agit en tant que docteur et protecteur des habitants de l'île ainsi que pour les membres de l'équipage de Barbe Blanche.",
            //    Prime = 1374000000,
            //    Nom = "Marco",
            //    NomFruitDemon = "Tori Tori no Mi, Model: Phoenix ",
            //    Equipage = "WhiteBeard pirates",
            //    Occupation = "Docteur",
            //    ImageURL = "/images/Marco.png",
            //    ageDebut = 28,
            //    agePrensent = 30,
            //    typeDeFruit = "Zoan",
            //    EstVedette = false
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 7,
            //    IdParent = 2,
            //    Description = "Tony Tony Chopper est le docteur de l'Équipage du Chapeau de Paille. Chopper est un renne qui a mangé le Hito Hito no Mi, lui permettant de se transformer en humain. Il est originaire de l'Île de Drum, ce qui fait de lui le premier membre de l'équipage du Chapeau de Paille à être né sur La Route de tous les Périls. Il est le sixième membre de celui-ci, et le cinquième à se joindre à l'Équipage.\r\n\r\nAlors que sa prime avant l'ellipse était juste de Symbole Berry50, celle-ci a tout simplement doublée à Symbole Berry100 après les événements de Dressrosa ce qui en fait la plus petite prime de la série. Cette prime si basse s'explique par le fait que la Marine le considère comme l'Animal de Compagnie de l'équipage. Même après les événements de l'Arc Pays des Wa, sa prime n'a monté que jusqu'à Symbole Berry1 000.",
            //    Prime = 1000,
            //    Nom = "Chopper",
            //    NomFruitDemon = "Hito Hito no mi : model Humain ",
            //    Equipage = "StrawHat pirates",               
            //    Occupation = "Docteur",
            //    ImageURL = "/images/chopper.jpg",
            //    ageDebut = 16,
            //    agePrensent = 18,
            //    typeDeFruit = "Zoan",
            //    EstVedette = false
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 8,
            //    IdParent = 2,
            //    Description = "Kaidou (カイドウ, Kaidō) ou Kaido, surnommé \"Kaidou aux Cent Bêtes\" est le capitaine de l'Équipage aux Cent Bêtes. ainsi qu'un ancien membre des Quatre Empereurs, le troisième à être mentionné par son nom, et le dernier à faire ses débuts. Il est également connu comme étant \"La Créature la Plus Puissante du Monde\" (en parallèle avec Edward Newgate \"L'Homme le Plus Puissant du Monde\"). Lui et son équipage occupent actuellement le Pays des Wa. Il était également allié avec Kurozumi Orochi avant qu'il ne décide de le trahir, afin de développer son plan pour une nouvelle Onigashima. Il est un ancien apprenti de l'Équipage de Rocks.\r\n\r\n",
            //    Prime = 4611100000,
            //    Nom = "Kaido",
            //    NomFruitDemon = "Uo Uo no Mi, Model: Seiryu",
            //    Equipage = "Beast pirates",
            //    Occupation = "Yonko",
            //    ImageURL = "/images/Kaido.png",
            //    ageDebut = 42,
            //    agePrensent = 44,
            //    typeDeFruit = "Zoan",
            //    EstVedette = true
            //});
            //Enfants.Add(new Enfant()
            //{
            //    id = 9,
            //    IdParent = 3,
            //    Description = "Charlotte Katakuri est le 2e fils et le 3e enfant de la Famille Charlotte, et un triplé né en même temps qu'Oven et Daifuku. Il est l'un des trois Généraux Sucrés de l'Équipage de Big Mom ainsi que le Ministre Farine (粉大臣, Kona Daijin) gouvernant l'Île Blé.\r\nEn raison de ses actions, il est le troisième antagoniste de l'Arc Whole Cake après Big Mom en premier et Vinsmoke Judge en deuxième.",
            //    Prime = 1057000000,
            //    Nom = "Katakuri",
            //    NomFruitDemon = "Mochi Mochi no Mi",
            //    Equipage = "BigMom pirates",
            //    Occupation = "Ministre Farine",
            //    ImageURL = "/images/Katakuri.png",
            //    ageDebut = 34,
            //    agePrensent = 36,
            //    typeDeFruit = "Paramecia",
            //    EstVedette = false
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 10,
            //    IdParent = 3,
            //    Description = "Nico Robin, alias l'Enfant du Démon, est l'Archéologue de L'Équipage du Chapeau de Paille. Nico Robin est recherchée depuis qu'elle a huit ans, date à laquelle elle fût reconnue comme la dernière des démons d'Ohara, obtenant une prime de Symbole Berry79.000.000. Elle est la fille de Nico Olvia. Elle fut présentée comme étant la Vice-Présidente de Baroque Works connue sous le nom de Miss AllSunday et était le bras droit du chef de cette organisation, Crocodile. Robin recherche le Rio Ponéglyphe afin de découvrir la \"Véritable Histoire\" du Siècle Oublié, elle est la dernière personne sur terre à savoir lire les ponéglyphes. Elle est la septième membre de L'Équipage du Chapeau de Paille. Sur Tequila Wolf, le numéro d'esclave de Robin est le 3926. Alors que sa prime était de Symbole Berry 80.000.000 après les événements d'Enies Lobby et de Symbole Berry 130.000.000, obtenue après les événements de Dressrosa, sa prime actuelle est de Symbole Berry930.000.000, obtenue après les événements de l'Arc Pays des Wa.",
            //    Prime = 930000000,
            //    Nom = "Nico Robin",
            //    NomFruitDemon = "Hana Hana no Mi",
            //    Equipage = "StrawHat pirates",
            //    Occupation = "Archéologue",
            //    ImageURL = "/images/NicoRobin.png",
            //    ageDebut = 28,
            //    agePrensent = 30,
            //    typeDeFruit = "Paramecia",
            //    EstVedette = false
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 11,
            //    IdParent = 3,
            //    Description = "Trafalgar Law, de son vrai nom Trafalgar D. Water Law, est le Capitaine et Docteur de l'Équipage du Heart, un équipage pirate constitué surtout de docteurs. Il vient de la Ville Blanche, une île de North Blue . Il fait partie d'un groupe de onze pirates qu'on surnomme les Onze Supernovae sur l'Archipel Sabaody, des pirates de renom dont la prime dépasse les Symbole Berry 100 000 000. Avant l’ellipse, il avait la cinquième plus haute prime parmi les Onze Supernovae, avec une prime de Symbole Berry 200 000 000. Law, comme plusieurs autres pirates, rêve aussi de trouver le One Piece. Durant l'ellipse de deux ans, il est devenu un Grand Corsaire, agissant directement sous les ordres du Gouvernement Mondial et se retrouve avec une ancienne prime de Symbole Berry 440 000 000. Cependant, son titre a été révoqué par l'Amiral Fujitora, lorsque ce dernier a appris qu'il s'était allié à L'Équipage du Chapeau de Paille. Après les événements survenus à Dressrosa, sa prime est désormais de Symbole Berry 500 000 000. Après les événements de Wano Kuni, sa prime atteint les Symbole Berry 3 000 000 000.",
            //    Prime = 3000000000,
            //    Nom = "trafalgar Law",
            //    NomFruitDemon = "Ope Ope no Mi",
            //    Equipage = "Heart pirates",
            //    Occupation = "Docteur",
            //    ImageURL = "/images/trafalgarLaw.png",
            //    ageDebut = 22,
            //    agePrensent = 24,
            //    typeDeFruit = "Paramecia",
            //    EstVedette = true
            //});

            //Enfants.Add(new Enfant()
            //{
            //    id = 12,
            //    IdParent = 3,
            //    Description = "Edward Newgate, aussi appelé Barbe Blanche (白ひげ, Shirohige), \"L'Homme le Plus Fort au Monde\", également considéré comme étant l'homme \"le plus proche du One Piece\", était le capitaine de L'Équipage de Barbe Blanche. Il faisait partie des Quatre Empereurs de son vivant, il a été tué pendant la Bataille de Marine Ford par son ancien subordonné Marshall D. Teach (et son équipage). Il y représentait symboliquement, à la fois par sa seule présence, tous les Pirates libres dont les Empereurs, le Nouveau Monde, l'ancienne ère de Roger et la sienne qui s'est achevée et la nouvelle difficile qui débute en étant une de ses premières et principale victime. Il connaissait la signification de la volonté du D. Ses dernières paroles furent de prédire qu'une personne défiera le monde entier, une guerre plus importante encore que celle de Marineford viendra et de déclarer pour finir que le One Piece existait vraiment.[7] Il est le premier protagoniste de l'Arc Marineford avant Luffy en deuxième et Ace en troisième.",
            //    Prime = 5046000000,
            //    Nom = "WhiteBeard",
            //    NomFruitDemon = "Gura Gura no Mi",
            //    Equipage = "WhiteBeard pirates",
            //    Occupation = "Yonko",
            //    ImageURL = "/images/WhiteBeard.png",
            //    ageDebut = 55,
            //    agePrensent = 57,
            //    typeDeFruit = "Paramecia",
            //    EstVedette = false
            //});

            //lier les objets enfant aux differents parent
            foreach (var parent in Parents)
            {
                parent.Enfants = new List<Enfant>();
                parent.Enfants.AddRange(Enfants.Where(e => e.IdParent == parent.Id));
            }

            //lier les objets parents aux different enfants
            foreach (var enfants in Enfants)
            {
                enfants.Parent = Parents.Where(p => p.Id == enfants.IdParent).Single();
            }
        }
    }
}

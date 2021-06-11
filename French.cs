using System.Collections.Generic;

namespace ABI.CCK.Scripts.Translation
{
    public class French
    {
        public static readonly Dictionary<string, string> Localization = new Dictionary<string, string>()
        {
            {"ABI_UI_BUILDPANEL_HEADING_BUILDER", "Constructeur de Contenu"},
            {"ABI_UI_BUILDPANEL_HEADING_SETTINGS", "Réglages & Options"},
            {"ABI_UI_BUILDPANEL_HEADING_DOCUMENTATION", "Voir notre documentation"},
            {"ABI_UI_BUILDPANEL_HEADING_FEEDBACK", "Envoyer une remarque"},
            {"ABI_UI_BUILDPANEL_HEADING_FOUNDCONTENT", "Contenu trouvé dans la scène active"},
            {"ABI_UI_BUILDPANEL_HEADING_ACCOUNT_INFO", "Informations du compte"},
            {"ABI_UI_BUILDPANEL_LOGIN_CREDENTIALS_INCORRECT", "Les identifiants de connexion saisis sont incorrects."},
            {"ABI_UI_BUILDPANEL_LOGIN_BUTTON", "Se connecter"},
            {"ABI_UI_BUILDPANEL_LOGOUT_BUTTON", "Se déconnecter"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_TITLE", "Supprimer les identifiants locaux pour le CCK"},
            {
                "ABI_UI_BUILDPANEL_LOGOUT_DIALOG_BODY",
                "Ceci va supprimer les identifiants stockés localement. Vous devrez vous réauthentifier. Voulez-vous continuer ?"
            },
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_ACCEPT", "Oui !"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_DECLINE", "Non !"},

            {
                "ABI_UI_BUILDPANEL_UPLOADER_NO_AVATARS_FOUND",
                "Aucun avatar configuré trouvé dans la scène - CVRAvatar ajouté ?"
            },
            {
                "ABI_UI_BUILDPANEL_UPLOADER_NO_SPAWNABLES_FOUND",
                "Aucun objet instanciable configuré trouvé dans la scène - CVRSpawnable ajouté ?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_WARNING_SPAWNPOINT",
                "Votre monde n'a aucun point d'apparition assigné. Veuillez ajouter un ou plusieurs points d'apparitions dans le composant CVRWorld ou la position de l'objet contenant le CVRWorld sera utilisé à la place."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_REFERENCE_CAMERA",
                "Vous n'avez pas de caméra de référence assignée à votre monde. Les réglages de caméra par défaut seront utilisés."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_RESPAWN_HEIGHT",
                "La hauteur du point de réapparition est en dessous de -500. Cela prendra un long moment pour réapparaître après une chute hors de la carte. Ce n'est probablement pas ce que vous souhaitez."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_MULTIPLE_CVR_WORLD",
                "Plusieurs objets CVR World sont présents dans la scène. Ceci va casser le monde. Veuillez vous assurer qu'il n'y ait qu'un seul objet CVR World dans la scène ou utilisez notre prefab CVRWorld."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_WORLD_CONTAINS_AVATAR",
                "Les scènes chargées ne devraient jamais contenir à la fois des descripteurs d'objets avatar et monde. Veuillez configurer vos scènes en conséquence."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_NO_CONTENT",
                "Aucun contenu trouvé dans la scène courante. Avez-vous oublié d'ajouter un composant descripteur à votre objet de jeu ?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_UNITY_UNSUPPORTED",
                "Vous utilisez une version d'Unity qui n'est pas compatible. Veuillez utiliser une version compatible d'Unity. Vous pouvez vérifier la version compatible correspondant à votre version du CCK dans notre documentation."
            },
            {"ABI_UI_BUILDPANEL_UPLOAD_WORLD_BUTTON", "Mettre en ligne Monde"},
            {"ABI_UI_BUILDPANEL_UPLOAD_AVATAR_BUTTON", "Mettre en ligne Avatar"},
            {"ABI_UI_BUILDPANEL_UPLOAD_PROP_BUTTON", "Mettre en ligne Objet Instanciable"},
            {"ABI_UI_BUILDPANEL_FIX_IMPORT_SETTINGS", "Réparer les réglages d'import"},
            {"ABI_UI_BUILDPANEL_UTIL_REMOVE_MISSING_SCRIPTS_BUTTON", "Supprimer les scripts manquants"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_USERNAME", "Nom d'utilisateur"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_ACCESSKEY", "Clé-Accès"},
            {
                "ABI_UI_BUILDPANEL_INFOTEXT_DOCUMENTATION",
                "Utilisez notre documentation pour en savoir plus sur comment créer du contenu pour nos jeux. Vous trouverez aussi des tutoriaux pratiques sur comment utiliser la plupart des fonctionnalités principales du moteur et du jeu ici."
            },
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN1", "Veuillez vous identifier avec vos identifiants CCK."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN2", "Vous pouvez trouver ces derniers sur hub.abinteractive.net."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN3", "Veuillez générer une clé CCK dans le gestionnaire de clés."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_AUTHENTICATED_AS", "Authentifié(e) en tant que"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_USER_RANK", "Rang utilisateur API"},
            {"ABI_UI_BUILDPANEL_SETTINGS_HEADER", "Réglages de mise en ligne"},
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_ENCRYPTION", "Changer le Chiffrement de Connexion :"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_ENCRYPTION",
                "Si vous rencontrez des problèmes pour la mise en ligne essayez de passer en http."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_REGION", "Région de mise en ligne :"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_REGION",
                "Vous pouvez changer la Région de mise en ligne pour augmenter votre vitesse d'émission. Votre contenu sera toujours disponible à travers le monde."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CCK_LANGUAGE", "Langue du CCK :"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CCK_LANGUAGE",
                "Vous pouvez changer la langue du CCK ici afin de recevoir les notifications et les textes de l'UI dans votre langue préférée."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FOLDERPATH",
                "Veuillez ne pas déplacer l'emplacement des dossiers CCK ou CCK Mods. Ceci rendrait le CCK inutilisable."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FEEDBACK",
                "Vous voulez faire une demande de fonctionnalité ? Trouvé un bug ? Publiez le sur notre plateforme de retours utilisateur !"
            },
            {"ABI_UI_BUILDPANEL_WARNING_MESH_FILTER_MESH_EMPTY", "MeshFilter avec maillage manquant détecté"},
            {
                "ABI_UI_BUILDPANEL_AVATAR_ERROR_ANIMATOR",
                "Aucun animateur n'a été détecté pour cet avatar. Faites en sorte que l'animateur soit présent sur le même GameObject qui contient le composant CVRAvatar."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_GENERIC",
                "L'Emplacement pour Avatar dans votre Animateur Avatar n'est pas rempli. Votre Avatar sera considéré comme un Avatar générique."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_POLYGONS",
                "Attention : Cet avatar a plus de 100k ({X}) polygones au total. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_SKINNED_MESH_RENDERERS",
                "Attention : Cet avatar contient plus de 10 ({X}) composants SkinnedMeshRenderer. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_MATERIALS",
                "Attention : Cet avatar utilise plus de 20 ({X}) emplacements de materiaux. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_VIEWPOINT",
                "Attention : La position de la vue de cet avatar est défini par défaut à X=0,Y=0,Z=0. Celà veut dire que la position de votre vue est au sol. Ce n'est probablement pas ce que vous souhaitez."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_NON_HUMANOID",
                "Attention : Votre Avatar n'est pas défini en tant qu'Humanoid."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_LEGACY_BLENDSHAPES",
                "Attention: Cet avatar n'a aucune legacy blend shape normals. Cela va engendrer une taille de fichier plus grande et des erreurs d'éclairages."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_POLYGONS",
                "Info : Cet avatar a plus de 50k ({X}) polygones au total. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SKINNED_MESH_RENDERERS",
                "Info : Cet avatar contient plus de 5 ({X}) composants SkinnedMeshRenderer. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_MATERIALS",
                "Info : Cet avatar utilise plus de 10 ({X}) emplacements de materiaux. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SMALL",
                "Info : La hauteur de la position de la vue de cet avatar est en dessous de 0.5. Cet avatar est considéré comme extrêmement petit."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_HUGE",
                "Info : La hauteur position de la vue de cet avatar est au dessus de 3.0. Cet avatar est considéré comme extrêmement énorme."
            },
            {"ABI_UI_BUILDPANEL_AVATAR_UPLOAD_BUTTON", "Mettre en ligne Avatar"},
            {
                "ABI_UI_BUILDPANEL_PROPS_ERROR_MISSING_SCRIPT",
                "Des objets instanciables ou leur enfants contiennent des scripts manquants. La mise en ligne va échouer tel quel. Supprimez les références de scripts manquants avant la mise en ligne ou cliquez sur Supprimer tous les scripts manquants pour le faire automatiquement pour vous."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_POLYGONS",
                "Attention : Cet objet instanciable a plus de 100k ({X}) polygones au total. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_SKINNED_MESH_RENDERERS",
                "Attention : Cet objet instanciable contient plus de 10 ({X}) composants SkinnedMeshRenderer. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_MATERIALS",
                "Attention : Cet objet instanciable utilise plus de 20 ({X}) emplacements de materiaux. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_LEGACY_BLENDSHAPES",
                "Attention : Cet objet instanciable n'a aucune legacy blend shape normals. Cela va engendrer une taille de fichier plus grande et des erreurs d'éclairages."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_POLYGONS",
                "Info : Cet objet instanciable a plus de 50k ({X}) polygones au total. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_SKINNED_MESH_RENDERERS",
                "Info : Cet objet instanciable contient plus de 5 ({X}) composants SkinnedMeshRenderer. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_MATERIALS",
                "Info : Cet objet instanciable utilise plus de 10 ({X}) emplacements de materiaux. Cela peut poser des problèmes de performances en jeu. Cela ne vous empêche pas sa mise en ligne."
            },
            {"ABI_UI_BUILDPANEL_PROPS_UPLOAD_BUTTON", "Mettre en ligne Objet Instanciable (Prop)"},
            {
                "ABI_UI_BUILDPANEL_ERROR_WORLD_MISSING_SCRIPTS",
                "La scène contient des scripts manquants. La mise en ligne va échouer tel quel. Supprimez les références de scripts manquants avant la mise en ligne ou cliquez sur Supprimer tous les scripts manquants pour le faire automatiquement pour vous."
            },
            {
                "ABI_UI_BUILDPANEL_ERROR_AVATAR_MISSING_SCRIPTS",
                "L'avatar ou ses enfants contiennent des scripts manquants. La mise en ligne va échouer tel quel. Supprimez les références de scriptes manquants avant la mise en ligne ou cliquez sur Supprimer tous les scripts manquants pour le faire automatiquement pour vous."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_MULTIPLE_TRIGGER_HELPBOX",
                "Avoir plusieurs Déclencheurs sur le même GameObject va engendrer un comportement imprévisible!"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_POINTERS_HELPBOX",
                "Ajouter des Pointeurs à la liste \"Pointeurs Autorisés\" va ignorer tous les autres Pointeurs qui n'en font pas partie."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_TYPES_HELPBOX",
                "Ajouter des Types dans la liste \"Types Autorisés\" va ignorer tous les Pointeurs qui ne sont pas associés aux Types dans la liste."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_PARTICLE_HELPBOX",
                "Activer cette option autorisera les systèmes de particules qui ont un pointeur sur le même GameObject pour activer ce trigger. Une particule ne peut délencher que le Trigger On Enter."
            },
            {
                "ABI_UI_INFOTEXT_WORLDS_NO_AVATARS",
                "Un objet ChilloutVR World a été trouvé dans cette scène. Les avatars ne peuvent pas être mis en ligne tant que l'objet World n'est pas supprimé. Avatars / objets instantiables feront partie du monde et seront visible dans ce monde à moins qu'ils ne soient désactivés ou supprimés."
            },
            {
                "ABI_UI_ASSET_INFO_HEADER_INFORMATION",
                "Ce script est utilisé pour stocker les metadonnées de l'objet. Veuillez ne pas modifier les données dedans à moins ce que vous sachiez ce que vous faites. Pour remettre en ligne un avatar, détachez le Guid et remettez-le en ligne."
            },
            {"ABI_UI_ASSET_INFO_GUID_LABEL", "Le Guid stocké actuellement est : "},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON", "Détacher l'identifiant unique d'asset"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_TITLE", "Détacher le Guid du Gestionnaire d'Info d'Asset"},
            {
                "ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_BODY",
                "L'identifiant unique d'asset va être détaché. Ce qui veut dire que votre contenu sera mis en ligne comme nouveau à l'exécution. Continuer ?"
            },
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_ACCEPT", "Oui !"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_DENY", "Non !"},
            {"ABI_UI_ASSET_INFO_ATTACH_LABEL", "Identifiant unique"},
            {
                "ABI_UI_ASSET_INFO_ATTACH_INFO",
                "Vous n'avez pas besoin de réattacher un Guid si vous ne planifiez pas d'écraser une ancienne mise en ligne. Un nouveau sera généré à la mise en ligne si aucun n'était attaché."
            },
            {"ABI_UI_ASSET_INFO_ATTACH_BUTTON", "Réattacher le guid"},
            {
                "ABI_UI_AVATAR_INFO_VIEWPOINT",
                "Controle la position de la caméra du joueur dans le jeu. Ceci devrait être placé entre les yeux."
            },
            {
                "ABI_UI_AVATAR_INFO_VOICE_POSITION",
                "Controle la position de la voix du joueur dans le jeu. Ceci devrait être placé sur la bouche."
            },
            {
                "ABI_UI_AVATAR_INFO_OVERRIDE_CONTROLLER",
                "Pour que les overrides fonctionnent, veuillez faire en sorte que le bon animateur soit assigné dans le contrôleur d'override. Ou sinon, vous ne verrez pas les emplacements de l'animateur à override. Un example pour cela se trouve dans le dossier CCK Player Prefabs."
            },
            {
                "ABI_UI_AVATAR_INFO_BLinking",
                "L'usage du blend shape de clignement d'oeil est optionnel. Il peut être activé pour générer des clignements aléatoire à l'exécution."
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_MOVEMENT",
                "Cocher cette option activera une animation semi-réaliste des yeux."
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_VISEMES",
                "Pour que la fonctionnalité de sélection automatique des visemes marche, vous devez sélectionner le mesh qui inclus le visage en premier. Ce sera le mesh du corp (body) dans la plupart des cas."
            }, {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_TITLE",
                "Dépendances manquants dans le projet !"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_WARNING_PREFACE",
                "Les dépendances suivantes ne sont pas présentes"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_FINAL_WARNING",
                "Veuillez installer toutes les dépendances avant d'installer ce module !"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_DIALOG_ACCEPT",
                "Compris"
            }
        };
    }
}

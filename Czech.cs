using System.Collections.Generic;

namespace ABI.CCK.Scripts.Translation
{
    public class Czech
    {
        public static readonly Dictionary<string, string> Localization = new Dictionary<string, string>()
        {
            {"ABI_UI_BUILDPANEL_HEADING_BUILDER", "Content Builder"},
            {"ABI_UI_BUILDPANEL_HEADING_SETTINGS", "Settings & Options Nastavení a možnosti"},
            {"ABI_UI_BUILDPANEL_HEADING_DOCUMENTATION", "View our documentation"},
            {"ABI_UI_BUILDPANEL_HEADING_FEEDBACK", "Submit feedback Odeslat zpětnou odezvu"},
            {"ABI_UI_BUILDPANEL_HEADING_FOUNDCONTENT", "Content found in active scene Obsah nalezený v aktivní scéně"},
            {"ABI_UI_BUILDPANEL_HEADING_ACCOUNT_INFO", "Account Information Info o účtu"},
            {"ABI_UI_BUILDPANEL_LOGIN_CREDENTIALS_INCORRECT", "The provided login credentials are incorrect. Poskytnuté přihlašovací údaje jsou nesprávné."},
            {"ABI_UI_BUILDPANEL_LOGIN_BUTTON", "Log in Přihlásit"},
            {"ABI_UI_BUILDPANEL_LOGOUT_BUTTON", "Log out Odhlásit"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_TITLE", "Remove local credentials for CCK Odstranit místní přihlašovací údaje"},
            {
                "ABI_UI_BUILDPANEL_LOGOUT_DIALOG_BODY",
                "This will remove the locally stored credentials. You will have to re-authenticate. Do you want to continue? Tohle odstraní lokálně uložené přihlašovací údaje. Budete se muset znovu autorizovat. Přejete si pokračovat?"
            },
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_ACCEPT", "Ano!"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_DECLINE", "Ne!"},

            {"ABI_UI_BUILDPANEL_UPLOADER_NO_AVATARS_FOUND", "No configured avatars found in scene - CVRAvatar added? Žádní nastavení avataři, nebyli nalezeni v scéně - CVRAvatar je přidán?"},
            {
                "ABI_UI_BUILDPANEL_UPLOADER_NO_SPAWNABLES_FOUND",
                "No configured spawnable objects found in scene - CVRSpawnable added? Žádné nastavené spawnovatelné objekty, nebyly nalezeny v scéně - CVRSpawnable je přidán?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_WARNING_SPAWNPOINT",
                "Your world does not have any spawn points assigned. Please add one or multiple spawn points in the CVRWorld component or the location of the CVRWorld holder object will be used. Tvůj svět nemá přiřazené žádné spawnovací body. Prosím přidejte jeden nebo několik spawnovacích bodů v CVRWorld komponentě nebo bude použito umístění CVRworld jako spawnovací bod."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_REFERENCE_CAMERA",
                "You do not have a reference camera assigned to your world. Default camera settings will be used. Nemáte přiřazenou kameru pro svůj svět. Výchozí nastavení kamery bude použito"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_RESPAWN_HEIGHT",
                "The respawn height is under -500. It will take a long time to respawn when falling out of the map. This is probably not what you want. Respawnovací výška je pod -500. Bude trvat dlouho než se respawnete, poté co spadnete mimo mapu"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_MULTIPLE_CVR_WORLD",
                "Multiple CVR World objects are present in the scene. This will break the world. Please ensure that there is only one CVR World object in the scene or use our CVRWorld prefab. Několik CVR World objektů je přítomno v scéně. Tohle může rozbít svět. Prosím ujistěte se, že je zde pouze jeden CVR World objekt v scéně nebo použijte náš CVRWorld prefab."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_WORLD_CONTAINS_AVATAR",
                "Loaded scenes should never contain both avatar and world descriptor objects. Please setup your scenes accordingly. Načtené scény by nikdy němeli obsahovat avatar ..."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_NO_CONTENT",
                "No content found in present scene. Did you forget to add a descriptor component to a game object? Žádný obsah nebyl nalezen v přítomné scéně. Zapoměli jste přidat depsriptor komponentu na herní objekt?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_UNITY_UNSUPPORTED",
                "You are using a unity version that is not supported. Please use a supported unity version. You can check the supported version corresponding to your CCK version in our documentation. Používáte Unity verzi která není podporována. Prosím použijte podporovanou Unity verzi."
            },
            {"ABI_UI_BUILDPANEL_UPLOAD_WORLD_BUTTON", "Upload World Nahrát svět"},
            {"ABI_UI_BUILDPANEL_UPLOAD_AVATAR_BUTTON", "Upload Avatar Nahrát Avatar"},
            {"ABI_UI_BUILDPANEL_UPLOAD_PROP_BUTTON", "Upload Spawnable Object Nahrát spawnovatelný objekt"},
            {"ABI_UI_BUILDPANEL_FIX_IMPORT_SETTINGS", "Fix import settings Opravit importovací nastavení"},
            {"ABI_UI_BUILDPANEL_UTIL_REMOVE_MISSING_SCRIPTS_BUTTON", "Remove missing scripts Odstranit chybějíci skripty"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_USERNAME", "Username Uživatelské jméno"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_ACCESSKEY", "Access-Key Přistupový klíč"},
            {
                "ABI_UI_BUILDPANEL_INFOTEXT_DOCUMENTATION",
                "Use our documentation to find out more about how to create content for our games. You will also find some handy tutorials on how to utilize most of the core engine features and core game features there. Použijte naši dokumentaci aby jste nalezli více o tom, jak vytvářet obsah pro naše hry. Také tam můžete najít užitečné tutoriály, o tom jak nejvíce využít základní funkce enginu a zakladní herní funkce.  "
            },
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN1", "Please authenticate using your CCK credentials. Prosím autorizujte se, použitím svých přihlašovacích CCK údajů."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN2", "You can find those on hub.abinteractive.net. Můžete je nalézt na hub.abinteractive.net."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN3", "Please generate a CCK Key in the key manager. Prosím vygenerujte si CCK klíč v key manageru"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_AUTHENTICATED_AS", "Authenticated as Autorizován jako"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_USER_RANK", "API user rank API uživatelská hodnost"},
            {"ABI_UI_BUILDPANEL_SETTINGS_HEADER", "Upload Settings Nahrávací nastavení"},
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_ENCRYPTION", "Switch Connection Encryption: Přepnout šifrování připojení:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_ENCRYPTION",
                "If you have Problems uploading try switching to http. Pokud máte problémy s nahráváním, zkuste přepnout na http."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_REGION", "Upload Region: Nahrávací region"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_REGION",
                "You can switch the Upload Region to increase your upload speed. Your content will still be available worldwide. Můžete přepnout nahrávací region, aby jste zvýšili svoji nahrávací rychlost."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CCK_LANGUAGE", "CCK Language: CCK jazyk:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CCK_LANGUAGE",
                "You can switch your CCK language here in order to get notifications and UI texts in your preferred language. Můžete přepnout svůj CCK jazyk zde, aby jste získali oznámení a UI v svém preferovaném jazyce."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FOLDERPATH",
                "Please do not move the folder location of the CCK or CCK Mods folder. This will render the CCK unusable. Prosím nepřesouvejte umístění složky CCK nebo CCK Mods složku."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FEEDBACK",
                "Want to request a feature? Found a bug? Post on our feedback platform! Chcete přidat nějakou funkci? Nalezli jste chybu? Pošlete to na naši platformu zpetné odezvy! "
            },
            {"ABI_UI_BUILDPANEL_WARNING_MESH_FILTER_MESH_EMPTY", "MeshFilter with missing Mesh detected           MeshFilter s chybějící Meshí zjištěn"},
            {
                "ABI_UI_BUILDPANEL_AVATAR_ERROR_ANIMATOR",
                "No Animator was detected for this Avatar. Make sure, that an Animator is present on the same GameObject as the CVRAvatar Component. Žádný animátor nebyl detekován pro tento avatar. Ujistěte se, že animátor je přitomen na stejném GameObjetu jako CVRAvatar komponenta."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_GENERIC",
                "The Avatar Slot in your Avatar Animator is not filled. Your Avatar will be considered as generic Avatar. Avatar slot v tvém avatar animátorovi, není vyplněn. Tvůj avatar bude považován za generický avatar"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_POLYGONS",
                "Warning: This avatar has more than 100k ({X}) polygons in total. This can cause performance problems in game. This does not prevent you from uploading. Varování: Tento avatar má dohromady více jak 100k ({X}) polygonů. Tohle může způsobit vykonostní problémy v hře."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_SKINNED_MESH_RENDERERS",
                "Warning: This avatar contains more than 10 ({X}) SkinnedMeshRenderer components. This can cause performance problems in game. This does not prevent you from uploading. Varování: Tento avatar obsahuje více jak 10 ({X}) SkinnedMeshRender komponentů."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_MATERIALS",
                "Warning: This avatar utilizes more than 20 ({X}) material slots. This can cause performance problems in game. This does not prevent you from uploading. Varování: Tento avatar využívá více jak 20 ({X}) materialových slotů."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_VIEWPOINT",
                "Warning: The view position of this avatar defaults to X=0,Y=0,Z=0. This means your view position is on the ground. This is probably not what you want. Varování: Pohledová pozice tehoto avataru je v výchozím stavu na X=0,Y=0,Z=0. To znamená že pozice tvého pohledu je na zemi. To pravděpodobně není, něco co by jste chtěli. "
            },
            {"ABI_UI_BUILDPANEL_AVATAR_WARNING_NON_HUMANOID", "Warning: Your Avatar is not setup as Humanoid. Varování: Tvůj avatar není nastaven jako Humanoid."},
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_LEGACY_BLENDSHAPES",
                "Warning: This Avatar has none legacy blend shape normals. This will lead to an increased filesize and lighting errors   Varování: Tento avatar nemá žádné legacy blend shape normals. Tohle může vést k zvýšení velikosti souboru a chybám v osvětlení "
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_POLYGONS",
                "Info: This avatar has more than 50k ({X}) polygons in total. This can cause performance problems in game. This does not prevent you from uploading. Info: Tento avatar má dohromady více jak 50 ({X}) polygonů."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SKINNED_MESH_RENDERERS",
                "Info: This avatar contains more than 5 ({X}) SkinnedMeshRenderer components. This can cause performance problems in game. This does not prevent you from uploading. Info: Tento avatar má více jak 5 ({X}) SkinnedMeshRenderer komponentů-"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_MATERIALS",
                "Info: This avatar utilizes more than 10 ({X}) material slots. This can cause performance problems in game. This does not prevent you from uploading. Info: Tento avatar využívá více jak 10 materiálových slotů. To může způsobit výkonostní problémy v hře."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SMALL",
                "Info: The view position of this avatar is under 0.5 in height. This avatar is considered excessively small. Info: Pohledová pozice tehohle avataru je pod 0.5 výškou. Tento avatar je považován za nadměrně malého."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_HUGE",
                "Info: The view position of this avatar is over 3.0 in height. This avatar is considered excessively huge. Info: Pohledová pozice tehohle avatara je přes 3.0 výšku. Tento avatar je považován za nadměrně obrovského."
            },
            {"ABI_UI_BUILDPANEL_AVATAR_UPLOAD_BUTTON", "Upload Avatar Nahrát avatar"},
            {
                "ABI_UI_BUILDPANEL_PROPS_ERROR_MISSING_SCRIPT",
                "Spawnable Objects or its children contains missing scripts. The upload will fail like this. Remove all missing script references before uploading or click Remove all missing scripts to automatically have this done for you. Spawnovatelné objekty nebo jejich pod-objekty (children), obsahují chybějící sripty. Nahrání takovehéhle objektu selže. Odstrantě všechny odkazy na chybějící sripty před nahráním nebo klikněte na -Odstranit chybějící sripty- pro automatické odstranění."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_POLYGONS",
                "Warning: This spawnable object has more than 100k ({X}) polygons in total. This can cause performance problems in game. This does not prevent you from uploading. Varování: Tento spawnovatelný objekt má dohromady více jak 100K ({X}) polygonů."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_SKINNED_MESH_RENDERERS",
                "Warning: This spawnable object contains more than 10 ({X}) SkinnedMeshRenderer components. This can cause performance problems in game. This does not prevent you from uploading. Varování: Tento spawnovatelný objekt obsahuje více jak 10 ({X}) SkinnedMeshRenderer komponentů."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_MATERIALS",
                "Warning: This spawnable object utilizes more than 20 ({X}) material slots. This can cause performance problems in game. This does not prevent you from uploading. Varování: Tento spawnovatelný objekt využívá více jak 20 ({X}) materialových slotů."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_LEGACY_BLENDSHAPES",
                "Warning: This spawnable object has none legacy blend shape normals. This will lead to an increased filesize and lighting errors Varování: Tento spawnovatelný objekt nemá žádné legacy blend shape normals. To může vést k zvyšení velikosti souboru a chybám v osvětelní."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_POLYGONS",
                "Info: This spawnable object has more than 50k ({X}) polygons in total. This can cause performance problems in game. This does not prevent you from uploading. Info: Tento spawnovatelný objekt má dohromady více jak 50K ({X}) polygonů. "
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_SKINNED_MESH_RENDERERS",
                "Info: This spawnable object contains more than 5 ({X}) SkinnedMeshRenderer components. This can cause performance problems in game. This does not prevent you from uploading. Info: tento spawnovatelný objekt obsahuje více jak 5 ({X}) SkinnedMeshRenderer komponentů."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_MATERIALS",
                "Info: This spawnable object utilizes more than 10 ({X}) material slots. This can cause performance problems in game. This does not prevent you from uploading. Info: Tento spawnovatelný objekt využívá dohromady více jak 10 ({X}) materiálových slotů."
            },
            {"ABI_UI_BUILDPANEL_PROPS_UPLOAD_BUTTON", "Upload Spawnable Object (Prop)   Nahrát spawnovatelný objekt (Prop)"},
            {
                "ABI_UI_BUILDPANEL_ERROR_WORLD_MISSING_SCRIPTS",
                "Scene contains missing scripts. The upload will fail like this. Remove all missing script references before uploading or click Remove all missing scripts to automatically have this done for you. Scéna obsahuje chybějící skripty. Takovéhle nahrání selže. Odstrantě všechny odkazy na chybějící sripty před nahráním nebo klikněte na -Odstranit chybějící sripty- pro automatické odstranění."
            },
            {
                "ABI_UI_BUILDPANEL_ERROR_AVATAR_MISSING_SCRIPTS",
                "Avatar or its children contains missing scripts. The upload will fail like this. Remove all missing script references before uploading or click Remove all missing scripts to automatically have this done for you. Avatar nebo jeho pod-objekty (children) obsahují chybějící skripty. Takovéhle nahrání selže. Odstrantě všechny odkazy na chybějící sripty před nahráním nebo klikněte na -Odstranit chybějící sripty- pro automatické odstranění."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_MULTIPLE_TRIGGER_HELPBOX",
                "Having multiple Triggers on the same GameObject will lead to unpredictable behavior! Máte několik Triggerů na stejném GameObjektu, to může vést k nepředvídatelnému chování!"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_POINTERS_HELPBOX",
                "Adding Pointers to the \"Allowed Pointers\" List will Ignore all other Pointers that are not contained in it. Přidávání ukazatelů na \"Allowed Pointers\" Seznam bude ignorovat všechny ostatní ukazatele, které nejsou obsaženy. "
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_TYPES_HELPBOX",
                "Adding Types in the \"Allowed Types\" List will ignore all Pointers that do not match the Types in the List. Přidávání typů v \"Allowed Types\" Seznam bude ignorovat všechny ukazatele které se neshodují s typy v seznamu. "
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_PARTICLE_HELPBOX",
                "Enabling this option will allow particle systems that have a pointer on the same GameObject to activate this trigger. Particle can only trigger On Enter Trigger. Aktivování tehlé možnosti, povolí particle systemům, které mají ukazatel na stejném GameObjektu, aby aktivovali tento trigger. Particle může být spuštěn pouze On Enter Trigger. "
            },
            {
                "ABI_UI_INFOTEXT_WORLDS_NO_AVATARS",
                "A ChilloutVR World object has been found in the scene. Avatars can not be uploaded until the world object has been removed. Avatars / spawnable objects will be part of the world and visible in-world unless they are disabled or removed. A ChilloutVR World objekt byl nalezen v scéně. Avataři nemohou být nahráni, dokud nebudou world objekty odstraněny. Avataři/spawnovatelné objekty budou součástí světa a viditelné v světe, dokud nebudou deaktivovány nebo odstraněni."
            },
            {
                "ABI_UI_ASSET_INFO_HEADER_INFORMATION",
                "This script is used to store object metadata. Please do not modify the data on it unless you know what you are doing. To reupload an avatar, detach the Guid and reupload. Tento skript je použit k uložení metadat objektu. Prosím neupravujte data v něm, pokud nevíte co děláte. Pro znovu-nahrání avatara odpojte Guid a znovu nahrajte."
            },
            {"ABI_UI_ASSET_INFO_GUID_LABEL", "The currently stored Guid is:    Aktualní uložené Guid je: "},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON", "Detach asset unique identifier    Odpojit unikátní identifikátor assetu"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_TITLE", "Detach Guid from Asset Info Manager    Odpojit Guid z Asset Info Manageru"},
            {
                "ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_BODY",
                "The asset unique identifier will be detached. This means that your content will most likely be uploaded as new on runtime. Continue? Unikátní identifikátor assetu bude odpojen. To znamená že tvůj obsah bude většinou nahrán jako nový."
            },
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_ACCEPT", "Ano!"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_DENY", "Ne!"},
            {"ABI_UI_ASSET_INFO_ATTACH_LABEL", "Unique identifier Unikátní identifikátor"},
            {
                "ABI_UI_ASSET_INFO_ATTACH_INFO",
                "You do not need to re-attach a Guid if you do not plan to overwrite any old upload. A new one will be generated on upload if none is attached. Nepotřebuješ znovu připojit Guid, pokud neplánuješ přepsat dříve nahraný objekt. Nové Guid bude vygenerováno při nahrávání, pokud žádné není připojeno."
            },
            {"ABI_UI_ASSET_INFO_ATTACH_BUTTON", "Re-Attach guid Znovu připojit guid"},
            {
                "ABI_UI_AVATAR_INFO_VIEWPOINT",
                "Controls your player rigs camera position in game. This should be between both eyes. Ovládá pozici hráčovy kamery v hře. Tohle by mělo být mezi dvěma očima."
            },
            {
                "ABI_UI_AVATAR_INFO_VOICE_POSITION",
                "Controls your player rigs voice position in game. This should be on your mouth. Ovládá pozici hráčova hlasu v hře. Tohle by mělo být na tvé puse."
            },
            {
                "ABI_UI_AVATAR_INFO_OVERRIDE_CONTROLLER",
                "For the overrides to work, please make sure, that the correct animator is assigned in the override controller. Otherwise you will not see animator slots to override. An example for this is in the CCK Player Prefabs folder."
            },
            {
                "ABI_UI_AVATAR_INFO_BLinking",
                "Blinking blend shape usage is optional. It can be enabled to generate random blinks on runtime. Použití mrkacího blend shape je volitelné. Může být aktivováno pro generování nahodného mrkání. "
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_MOVEMENT",
                "Checking this option will enable a semi realistic animation of the eyes. Označení této možnosti, aktivuje semi-realistikou animaci očí."
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_VISEMES",
                "For the auto-select visemes feature to work, you will have to select the mesh that includes the face first. This will be the body mesh in most cases. Aby funkce automatického zvolení visemes fungovala, musíte nejdřive vybrat mesh která obsahuje tvář. To je vetšinou body mesh v většině případů"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_TITLE",
                "Dependencies missing in project! Chybějící zásvislosti v projektu!"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_WARNING_PREFACE",
                "The following dependencies are not met    Nasledující závislosti, nejsou přitomny"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_FINAL_WARNING",
                "Please install all dependencies before installing this module! Prosím nainstalujte všechny závislosti před instalovaním tehohle modulu!"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_DIALOG_ACCEPT",
                "Understood Chápu"
            }
        };
    }
}
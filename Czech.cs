using System.Collections.Generic;

namespace ABI.CCK.Scripts.Translation
{
    public class Czech
    {
        public static readonly Dictionary<string, string> Localization = new Dictionary<string, string>()
        {
            {"ABI_UI_BUILDPANEL_HEADING_BUILDER", "Tvůrce obsahu"},
            {"ABI_UI_BUILDPANEL_HEADING_SETTINGS", "Nastavení a možnosti"},
            {"ABI_UI_BUILDPANEL_HEADING_DOCUMENTATION", "Prohlédněte si naši dokumentaci"},
            {"ABI_UI_BUILDPANEL_HEADING_FEEDBACK", "Odeslat zpětnou odezvu"},
            {"ABI_UI_BUILDPANEL_HEADING_FOUNDCONTENT", "Obsah nalezený v aktivní scéně"},
            {"ABI_UI_BUILDPANEL_HEADING_ACCOUNT_INFO", "Informace o účtu"},
            {"ABI_UI_BUILDPANEL_LOGIN_CREDENTIALS_INCORRECT", "Poskytnuté přihlašovací údaje jsou nesprávné."},
            {"ABI_UI_BUILDPANEL_LOGIN_BUTTON", "Přihlásit"},
            {"ABI_UI_BUILDPANEL_LOGOUT_BUTTON", "Odhlásit"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_TITLE", "Odstranit místní přihlašovací údaje pro CCK"},
            {
                "ABI_UI_BUILDPANEL_LOGOUT_DIALOG_BODY",
                "Tohle odstraní lokálně uložené přihlašovací údaje. Budete se muset znovu autorizovat. Přejete si pokračovat?"
            },
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_ACCEPT", "Ano!"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_DECLINE", "Ne!"},

            {"ABI_UI_BUILDPANEL_UPLOADER_NO_AVATARS_FOUND", "Žádní nastavení avataři, nebyli nalezeni v scéně - je přidán CVRAvatar?"},
            {
                "ABI_UI_BUILDPANEL_UPLOADER_NO_SPAWNABLES_FOUND",
                "Žádné nastavené spawnovatelné objekty, nebyly nalezeny v scéně - je přidán CVRSpawnable?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_WARNING_SPAWNPOINT",
                "Váš svět nemá přiřazené žádné spawnovací body. Prosím přidejte jeden nebo několik spawnovacích bodů v CVRWorld komponentě nebo bude použito umístění CVRworld jako spawnovací bod."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_REFERENCE_CAMERA",
                "Nemáte přiřazenou referenční kameru pro svůj svět. Výchozí nastavení kamery bude použito"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_RESPAWN_HEIGHT",
                "Respawnovací výška je pod -500. Bude trvat dlouho než se respawnete, jakmile začnete padat mimo mapu. To pravděpodobně nechcete."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_MULTIPLE_CVR_WORLD",
                "Několik CVR World objektů je přítomno v scéně. Tohle může rozbít svět. Prosím ujistěte se, že je zde pouze jeden CVR World objekt v scéně nebo použijte náš CVRWorld prefab."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_WORLD_CONTAINS_AVATAR",
                "Načtené scény by nikdy němeli obsahovat Avatar a World komponentu zároveň. Prosím nastavte své scény, v souhladu s tímto."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_NO_CONTENT",
                "No content found in present scene. Did you forget to add a descriptor component to a game object? Žádný obsah nebyl nalezen v přítomné scéně. Zapoměli jste přidat komponentu na herní objekt?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_UNITY_UNSUPPORTED",
                "Používáte Unity verzi která není podporována. Prosím použijte podporovanou Unity verzi. Můžete si oveřit podporovanou verzi, odpovídající CCK verzi kterou používáte, v naší dokumentaci."
            },
            {"ABI_UI_BUILDPANEL_UPLOAD_WORLD_BUTTON", "Nahrát svět"},
            {"ABI_UI_BUILDPANEL_UPLOAD_AVATAR_BUTTON", "Nahrát Avatar"},
            {"ABI_UI_BUILDPANEL_UPLOAD_PROP_BUTTON", "Nahrát spawnovatelný objekt"},
            {"ABI_UI_BUILDPANEL_FIX_IMPORT_SETTINGS", "Opravit importovací nastavení"},
            {"ABI_UI_BUILDPANEL_UTIL_REMOVE_MISSING_SCRIPTS_BUTTON", "Odstranit chybějíci skripty"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_USERNAME", "Uživatelské jméno"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_ACCESSKEY", "Přistupový klíč"},
            {
                "ABI_UI_BUILDPANEL_INFOTEXT_DOCUMENTATION",
                "Použijte naši dokumentaci aby jste nalezli více o tom, jak vytvářet obsah pro naše hry. Také tam můžete najít užitečné tutoriály, o tom jak nejvíce využít základní funkce enginu a zakladní herní funkce.  "
            },
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN1", "Prosím autorizujte se, použitím svých přihlašovacích CCK údajů."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN2", "Můžete je nalézt na hub.abinteractive.net."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN3", "Please generate a CCK Key in the key manager. Prosím vygenerujte si CCK key v key manageru"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_AUTHENTICATED_AS", "Autorizován jako"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_USER_RANK", "API uživatelská hodnost"},
            {"ABI_UI_BUILDPANEL_SETTINGS_HEADER", "Nahrávací nastavení"},
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_ENCRYPTION", "Přepnout šifrování připojení:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_ENCRYPTION",
                "Pokud máte problémy s nahráváním, zkuste přepnout na http."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_REGION", "Nahrávací region:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_REGION",
                "Můžete přepnout nahrávací region, aby jste zvýšili svoji nahrávací rychlost. Váš obsah, bude stále dostupný celosvětově."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CCK_LANGUAGE", "CCK jazyk:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CCK_LANGUAGE",
                "Můžete přepnout svůj CCK jazyk zde, aby jste získali oznámení a UI v svém preferovaném jazyce."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FOLDERPATH",
                "Prosím nepřesouvejte umístění CCK nebo CCK Mods složky. To způsobí že CCK bude nepoužitelné."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FEEDBACK",
                "Chcete přidat nějakou funkci? Nalezli jste chybu? Pošlete to na naši platformu zpětné odezvy! "
            },
            {"ABI_UI_BUILDPANEL_WARNING_MESH_FILTER_MESH_EMPTY", "MeshFilter s chybějící Meshí zjištěn"},
            {
                "ABI_UI_BUILDPANEL_AVATAR_ERROR_ANIMATOR",
                "Žádný animátor nebyl detekován pro tento avatar. Ujistěte se, že animátor je přitomen na stejném GameObjectu jako CVRAvatar komponenta."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_GENERIC",
                "Avatar slot v vašem avatar animátorovi, není vyplněn. Váš avatar bude považován za generický avatar"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_POLYGONS",
                "Varování: Tento avatar má dohromady více jak 100k ({X}) polygonů. Tohle může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_SKINNED_MESH_RENDERERS",
                "Varování: Tento avatar obsahuje více jak 10 ({X}) SkinnedMeshRender komponentů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_MATERIALS",
                "Varování: Tento avatar využívá více jak 20 ({X}) materialových slotů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_VIEWPOINT",
                "Varování: Pohledová pozice tehoto avataru je v výchozím stavu na X=0,Y=0,Z=0. To znamená že pozice vašeho pohledu je na zemi. To pravděpodobně není, něco co by jste chtěli. "
            },
            {"ABI_UI_BUILDPANEL_AVATAR_WARNING_NON_HUMANOID", "Varování: Tvůj avatar není nastaven jako Humanoid."},
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_LEGACY_BLENDSHAPES",
                "Varování: Tento avatar nemá žádné legacy blend shape normals. Tohle může vést k zvýšení velikosti souboru a chybám v osvětlení "
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_POLYGONS",
                "Info: Tento avatar má dohromady více jak 50 ({X}) polygonů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SKINNED_MESH_RENDERERS",
                "Info: Tento avatar má více jak 5 ({X}) SkinnedMeshRenderer komponentů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_MATERIALS",
                "Info: Tento avatar využívá více jak 10 materiálových slotů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SMALL",
                "Info: Pohledová pozice tehohle avataru je pod 0.5 výškou. Tento avatar je považován za nadměrně malého."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_HUGE",
                "Info: Pohledová pozice tehohle avatara je přes 3.0 výšku. Tento avatar je považován za nadměrně obrovského."
            },
            {"ABI_UI_BUILDPANEL_AVATAR_UPLOAD_BUTTON", "Nahrát avatar"},
            {
                "ABI_UI_BUILDPANEL_PROPS_ERROR_MISSING_SCRIPT",
                "Spawnovatelné objekty nebo jejich pod-objekty (children), obsahují chybějící sripty. Nahrání takovehéhle objektu selže. Odstraňte všechny odkazy na chybějící skripty před nahráním nebo klikněte na -Odstranit chybějící skripty- pro automatické odstranění."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_POLYGONS",
                "Varování: Tento spawnovatelný objekt má dohromady více jak 100K ({X}) polygonů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_SKINNED_MESH_RENDERERS",
                "Varování: Tento spawnovatelný objekt obsahuje více jak 10 ({X}) SkinnedMeshRenderer komponentů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_MATERIALS",
                "Varování: Tento spawnovatelný objekt využívá více jak 20 ({X}) materialových slotů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_LEGACY_BLENDSHAPES",
                "Varování: Tento spawnovatelný objekt nemá žádné legacy blend shape normals. To může vést k zvyšení velikosti souboru a chybám v osvětelní."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_POLYGONS",
                "Info: Tento spawnovatelný objekt má dohromady více jak 50K ({X}) polygonů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání. "
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_SKINNED_MESH_RENDERERS",
                "Info: tento spawnovatelný objekt obsahuje více jak 5 ({X}) SkinnedMeshRenderer komponentů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_MATERIALS",
                "Info: Tento spawnovatelný objekt využívá dohromady více jak 10 ({X}) materiálových slotů. To může způsobit výkonostní problémy v hře. Tohle vám nebrání v nahrání."
            },
            {"ABI_UI_BUILDPANEL_PROPS_UPLOAD_BUTTON", "Nahrát spawnovatelný objekt (Prop)"},
            {
                "ABI_UI_BUILDPANEL_ERROR_WORLD_MISSING_SCRIPTS",
                "Scéna obsahuje chybějící skripty. Takovéhle nahrání selže. Odstraňte všechny odkazy na chybějící skripty před nahráním nebo klikněte na -Odstranit chybějící skripty- pro automatické odstranění."
            },
            {
                "ABI_UI_BUILDPANEL_ERROR_AVATAR_MISSING_SCRIPTS",
                "Avatar nebo jeho pod-objekty (children) obsahují chybějící skripty. Takovéhle nahrání selže. Odstrantě všechny odkazy na chybějící skripty před nahráním nebo klikněte na -Odstranit chybějící skripty- pro automatické odstranění."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_MULTIPLE_TRIGGER_HELPBOX",
                "Máte několik Triggerů na stejném GameObjektu, to může vést k nepředvídatelnému chování!"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_POINTERS_HELPBOX",
                "Přidáním ukazatelů do \"Allowed Pointers\" Budou ignorovány všechny ostatní ukazatelé, kteří nejsou obsaženy v seznamu. "
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_TYPES_HELPBOX",
                "Přidáním typů do \"Allowed Types\" Budou ignorováni, všichni ukazatelé kteří se neshodují s typy v seznamu. "
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_PARTICLE_HELPBOX",
                "Aktivování tehlé možnosti, povolí particle systemům, které mají ukazatel na stejném GameObjektu, aby aktivovali tento trigger. Particle může být spuštěn pouze On Enter Trigger. "
            },
            {
                "ABI_UI_INFOTEXT_WORLDS_NO_AVATARS",
                "ChilloutVR World objekt byl nalezen v scéně. Avataři nemohou být nahráni, dokud nebudou world objekty odstraněny. Avataři/spawnovatelné objekty budou součástí světa a viditelné v světe, dokud nebudou deaktivovány nebo odstraněni."
            },
            {
                "ABI_UI_ASSET_INFO_HEADER_INFORMATION",
                "Tento skript je použit k uložení metadat objektu. Prosím neupravujte data v něm, pokud nevíte co děláte. Pro znovu-nahrání avatara odpojte Guid a znovu nahrajte."
            },
            {"ABI_UI_ASSET_INFO_GUID_LABEL", "Aktuální uložené Guid je: "},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON", "Odpojit unikátní identifikátor assetu"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_TITLE", "Odpojit Guid z Asset Info Manageru"},
            {
                "ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_BODY",
                "Unikátní identifikátor assetu bude odpojen. To znamená že váš obsah bude většinou nahrán jako nový. Pokračovat?"
            },
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_ACCEPT", "Ano!"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_DENY", "Ne!"},
            {"ABI_UI_ASSET_INFO_ATTACH_LABEL", "Unikátní identifikátor"},
            {
                "ABI_UI_ASSET_INFO_ATTACH_INFO",
                "Nepotřebujete znovu připojit Guid, pokud neplánujete přepsat dříve nahraný objekt. Nové Guid bude vygenerováno při nahrávání, pokud žádné není připojeno."
            },
            {"ABI_UI_ASSET_INFO_ATTACH_BUTTON", "Znovu připojit guid"},
            {
                "ABI_UI_AVATAR_INFO_VIEWPOINT",
                "Ovládá pozici hráčovy kamery v hře. Tohle by mělo být mezi očima."
            },
            {
                "ABI_UI_AVATAR_INFO_VOICE_POSITION",
                "Ovládá pozici hráčova hlasu v hře. Tohle by mělo být na vaší puse."
            },
            {
                "ABI_UI_AVATAR_INFO_OVERRIDE_CONTROLLER",
                "Pro to aby overrides fungovaly, prosím ujistěte se. Že máte přiřazen správný override controller. Jinak neuvidíte sloty animátoru pro override. Přiklad pro tohle je v CCK Player Prefab složce."
            },t
            {
                "ABI_UI_AVATAR_INFO_BLinking",
                "Použití mrkacího blend shape je volitelné. Může být aktivováno pro generování nahodného mrkání. "
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_MOVEMENT",
                "Označení této možnosti, aktivuje semi-realistikou animaci očí."
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_VISEMES",
                "Aby funkce automatického zvolení visemes fungovala, musíte nejdříve vybrat mesh která obsahuje tvář. To je vetšinou body mesh v většině případů."
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_TITLE",
                "Chybějící závislosti v projektu!"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_WARNING_PREFACE",
                "Následující závislosti, nejsou přitomny"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_FINAL_WARNING",
                "Prosím nainstalujte všechny závislosti před instalovaním tehohle modulu!"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_DIALOG_ACCEPT",
                "Chápu"
            }
        };
    }
}
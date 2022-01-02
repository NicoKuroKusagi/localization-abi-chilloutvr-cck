using System.Collections.Generic;

namespace ABI.CCK.Scripts.Translation
{
    public class Norwegian
    {
        public static readonly Dictionary<string, string> Localization = new Dictionary<string, string>()
        {
            {"ABI_UI_BUILDPANEL_HEADING_BUILDER", "Innholds Bygger"},
            {"ABI_UI_BUILDPANEL_HEADING_SETTINGS", "Instillinger & Justeringer"},
            {"ABI_UI_BUILDPANEL_HEADING_DOCUMENTATION", "Se dokumentasjon"},
            {"ABI_UI_BUILDPANEL_HEADING_FEEDBACK", "Gi tilbakemelding"},
            {"ABI_UI_BUILDPANEL_HEADING_FOUNDCONTENT", "Innholdet funnet is den aktive scenen"},
            {"ABI_UI_BUILDPANEL_HEADING_ACCOUNT_INFO", "Bruker Informasjon"},
            {"ABI_UI_BUILDPANEL_LOGIN_CREDENTIALS_INCORRECT", "Den oppgitte inn-loggings informasjonen er feil."},
            {"ABI_UI_BUILDPANEL_LOGIN_BUTTON", "Logg inn"},
            {"ABI_UI_BUILDPANEL_LOGOUT_BUTTON", "Logg ut"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_TITLE", "Fjærn lokal registrering for CCK-en"},
            {
                "ABI_UI_BUILDPANEL_LOGOUT_DIALOG_BODY",
                "Dette vil fjærne den lokal lagrede legitemasjonen. Du må autorisere igjen. Vil du fortsette?"
            },
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_ACCEPT", "Ja!"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_DECLINE", "Nei!"},

            {"ABI_UI_BUILDPANEL_UPLOADER_NO_AVATARS_FOUND", "Ingen konfigurerte avatarer funnet i scenen - Er CVRAvatar lagt til?"},
            {
                "ABI_UI_BUILDPANEL_UPLOADER_NO_SPAWNABLES_FOUND",
                "Ingen konfigurerte skapende objekter funnet i scenen - Er CVRSpawnable lagt til?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_WARNING_SPAWNPOINT",
                "Verdenen din har ingen skapende objekter tildelt. Vennligst legg til èn eller flere instans punkter i CVRWorld komponenten ellers vil posisjonen til CVRWorld holder objektet bli brukt."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_REFERENCE_CAMERA",
                "Du har ikke et referanse kamera i verdenen din. De orginale kamera instillingene vil bli brugkt."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_RESPAWN_HEIGHT",
                "Gjenoppstå høyden er under -500. Når en faller ut av spill området vil det nok ta tid for å gjenoppstå. Dette er nok ikke dette du ønsker."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_MULTIPLE_CVR_WORLD",
                "Flere CVR Verden objekter er i scenen. Dette kan ødelegge verdenen. Vennligst bekreft at det bare er èn CVR Verden objekt i scenen eller bruk CVRWorld prefab-en våres."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_WORLD_CONTAINS_AVATAR",
                "Aktive scener burde ikke ha både en avatar og verden beskrivende objekter. Vennligst set opp scenene dine ordentlig."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_NO_CONTENT",
                "Ingen innhold er funnet i scenen. Har du glemt å legge til en descriptor komponent til et game-object?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_UNITY_UNSUPPORTED",
                "Du bruker en Unity versjon som ikke støttes. Vennligst bruk en versjon som er støttet. Du kan finne ut hvilken versjoner som støttes til CCK versjonen din i dokumentasjonen våres."
            },
            {"ABI_UI_BUILDPANEL_UPLOAD_WORLD_BUTTON", "Last opp Verden"},
            {"ABI_UI_BUILDPANEL_UPLOAD_AVATAR_BUTTON", "Last opp Karakter"},
            {"ABI_UI_BUILDPANEL_UPLOAD_PROP_BUTTON", "Last opp Skapende Objekt"},
            {"ABI_UI_BUILDPANEL_FIX_IMPORT_SETTINGS", "Fiks import instillinger"},
            {"ABI_UI_BUILDPANEL_UTIL_REMOVE_MISSING_SCRIPTS_BUTTON", "Fjærn manglende skripts"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_USERNAME", "Brukernavn"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_ACCESSKEY", "Tilgangs-Nøkkel"},
            {
                "ABI_UI_BUILDPANEL_INFOTEXT_DOCUMENTATION",
                "Bruk dokumentasjonen våres til å finne ut mer om hvordan en lager innhold til spillet vårt. Du kan også finne noen kjekke tutorials om hvordan en bruker de fleste egenskapene til motoren og andre sentrale funksjoner."
            },
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN1", "Vennligst autoriser med CCK legitemasjonen din."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN2", "Du kan finne dem på hub.abinteractive.net."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN3", "Vennligst generer en CCK nøkkel i nøkkel-manageren."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_AUTHENTICATED_AS", "Autentisert som"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_USER_RANK", "API bruker rang"},
            {"ABI_UI_BUILDPANEL_SETTINGS_HEADER", "Last opp Instillinger"},
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_ENCRYPTION", "Bytter Kryptert Tilkobling:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_ENCRYPTION",
                "Hvis du har problemer med å laste opp, prøv å bytt til http."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_REGION", "Foretrukken Opplastnings Region:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_REGION",
                "For å få raskere opplastnings hastighet kan du bytte til en annen Opplastings Region. Hvis den foretrekkende regionen er nede, vil en annen region automatisk bli valgt. Innholdet ditt er synelig over alt, uansett hvilken region du valgte."
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CCK_LANGUAGE", "CCK Språk:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CCK_LANGUAGE",
                "Du kan bytte språk på CCK-en her for å få opplysninger og UI tekst på ditt morsmål."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FOLDERPATH",
                "Vennligst ikke endre på plasseringen av CCK og CCK Mods filene. CCK-en vil bli ubrukelig."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FEEDBACK",
                "Ønsker du utvidet funksjonalitet...? Fant en feil? Post på tilbakemeldings platformen våres!"
            },
            {"ABI_UI_BUILDPANEL_WARNING_MESH_FILTER_MESH_EMPTY", "MeshFilter uten en Mesh funnet"},
            {
                "ABI_UI_BUILDPANEL_AVATAR_ERROR_ANIMATOR",
                "Ingen Animator var funnet for denne avataren. Vær sikker på at GameObject har en Amatør vesiden av CVRAvatar Komponenten."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_GENERIC",
                "Avatar slotten i Animator-en er tom. Avataren din vil bli regnet som en alminnelig avatar."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_POLYGONS",
                "Advarsel: Avataren har flere enn 100k ({X}) polygoner totalt. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_SKINNED_MESH_RENDERERS",
                "Advarsel: Denne avataren har flere enn 10 ({X}) SkinnedMeshRenderer komponenter. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_MATERIALS",
                "Advarsel: Denne avataren bruker flere enn 20 ({X}) material slots. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_VIEWPOINT",
                "Advarsel: Se posisjonen på denne avataren er X=0,Y=0,Z=0. Dette betyr at view posisjonen er på bakken. Dette er kanskje ikke det du ønsker."
            },
            {"ABI_UI_BUILDPANEL_AVATAR_WARNING_NON_HUMANOID", "Advarsel: Avataren din er ikke innstilt som Humanoid."},
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_LEGACY_BLENDSHAPES",
                "Advarsel: Denne avataren har ikke arv blend shape normaler. Dette vil øke filstørrelsen og lys feil"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_POLYGONS",
                "Info: Denne avataren har mer enn 50k ({X}) polygoner totalt. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SKINNED_MESH_RENDERERS",
                "Info: Denne avataren har flere enn 5 ({X}) SkinnedMeshRenderer komponenter. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_MATERIALS",
                "Info: Denne avataren bruker flere enn 10 ({X}) materialspor. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SMALL",
                "Info: Se posisjon høyden på denne avataren er under 0.5. Denne avataren er ansett som ekstremt liten."
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_HUGE",
                "Info: Se posisjon høyden på denne avataren er over 3.0. Denne avataren er ansett som ekstremt stor."
            },
            {"ABI_UI_BUILDPANEL_AVATAR_UPLOAD_BUTTON", "Last opp Avatar"},
            {
                "ABI_UI_BUILDPANEL_PROPS_ERROR_MISSING_SCRIPT",
                "Spawnable Objects eller ungene mangler skripter. Opplastingen vil feile i en slik tilstand. Fjern alle manglende skript referanser før du laster opp eller for å gjøre det automatisk, trykk på Fjern alle manglende skripter."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_POLYGONS",
                "Advarsel: Spawnable objektet har flere enn 100k ({X}) polygoner totalt. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_SKINNED_MESH_RENDERERS",
                "Advarsel: Spawnable objektet har flere enn 10 ({X}) SkinnedMeshRenderer komponenter. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_MATERIALS",
                "Advarsel: Spawnable objektet bruker flere enn 20 ({X}) materialspor. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_LEGACY_BLENDSHAPES",
                "Advarsel: Spawnable objektet har ikke blend shape normaler arving. Dette vil øke filstørrelsen og lys feil"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_POLYGONS",
                "Info: Spawnable objektet har mer enn 50k ({X}) polygoner totalt. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_SKINNED_MESH_RENDERERS",
                "Info: Spawnable objektet har flere enn 5 ({X}) SkinnedMeshRenderer komponenter. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_MATERIALS",
                "Info: Spawnable objektet bruker flere enn 10 ({X}) materialspor. Dette kan forårsake ytelsesproblemer i spillet. Dette forhindrer deg ikke i å laste opp."
            },
            {"ABI_UI_BUILDPANEL_PROPS_UPLOAD_BUTTON", "Last opp Spawnable Objekt (Prop)"},
            {
                "ABI_UI_BUILDPANEL_ERROR_WORLD_MISSING_SCRIPTS",
                "Scenen mangler skripter. Opplastingen vil feile i en slik tilstand. Fjern alle manglende skript referanser før du laster opp eller for å gjøre det automatisk, trykk på Fjern alle manglende skripter."
            },
            {
                "ABI_UI_BUILDPANEL_ERROR_AVATAR_MISSING_SCRIPTS",
                "Avateren eller ungene til den mangler skripter. Opplastingen vil feile i en slik tilstand. Fjern alle manglende skript referanser før du laster opp eller for å gjøre det automatisk, trykk på Fjern alle manglende skripter."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_MULTIPLE_TRIGGER_HELPBOX",
                "Hvis du har mange Triggere på det samme GameObjectet, vil det føre til uforutsigbar oppførsel!"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_POINTERS_HELPBOX",
                "Legg til Pekere i \"Tillatte Pekere\" listen, alle andre Pekere som ikke er i den vil bli ignorert."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_TYPES_HELPBOX",
                "Legg til Typer i \"Tillatte Typer\" listen, alle Pekere som ikke stemmer med Type listen vil bli ignorert."
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_PARTICLE_HELPBOX",
                "Ved å aktivere dette alternativet, vil det gi partikel systemer som har en peker på det samme GameObjektet evnen til å aktiveres gjennom en trigger. Partikler kan bare slås på ved On Enter Trigger."
            },
            {
                "ABI_UI_INFOTEXT_WORLDS_NO_AVATARS",
                "Et ChilloutVR World objekt er funnet i scenen. Avatarer kan ikke lastes opp før world objektet har blitt fjærnet. Avatarer / Spawnable objekter vil bli en del av verdenen og det synelige inni verdenen med mindre de er deaktivert eller fjernet."
            },
            {
                "ABI_UI_ASSET_INFO_HEADER_INFORMATION",
                "Denne skripten brukes til å lagre metadata. Vennligst ikke endre på dataene med mindre du vet hva du gjør. For å laste opp en avatar på nytt, så må du frakoble Guid-en og laste opp igjen."
            },
            {"ABI_UI_ASSET_INFO_GUID_LABEL", "Den nåværende Guid-en er: "},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON", "Løsne ressurs unik identifikator"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_TITLE", "Løsne Guid fra Konfigurer Ressursansvarlig"},
            {
                "ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_BODY",
                "Den unike ressurs-identifikatoren vil bli løsnet. Dette betyr at innholdet ditt vil mest sannsynelig bli lastet opp som ny på kjøretid. Fortsett?"
            },
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_ACCEPT", "Ja!"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_DENY", "Nei!"},
            {"ABI_UI_ASSET_INFO_COPY_BUTTON", "Kopier unik ressurs identifikator"},
            {"ABI_UI_ASSET_INFO_ATTACH_LABEL", "Unik identifikator"},
            {
                "ABI_UI_ASSET_INFO_ATTACH_INFO",
                "Du trenger ikke å feste en Guid igjen hvis du ikke planlegger å overskrive gammelt opplastet innhold. En ny en vil bli generert når man laster opp igjen hvis ingen er festet."
            },
            {"ABI_UI_ASSET_INFO_ATTACH_BUTTON", "Fest en ny guid"},
            {
                "ABI_UI_AVATAR_INFO_VIEWPOINT",
                "Kontrollerer spiller riggen sin kamera posisjon i spillet. Dette burde være mellom begge øynene."
            },
            {
                "ABI_UI_AVATAR_INFO_VOICE_POSITION",
                "Kontrollerer spiller riggen sin stemme posisjonen i spillet. Dette burde være munnen din."
            },
            {
                "ABI_UI_AVATAR_INFO_OVERRIDE_CONTROLLER",
                "For å overskriving til å fungere, vennligst legg merke til, at den riktige animatøren er brukt i animatør kontrolleren. Ellers vil du ikke se noen animatør slots til å overskrive. Det ligger et eksempel i CCK Player Prefabs filen."
            },
            {
                "ABI_UI_AVATAR_INFO_BLinking",
                "Å bruke Blinkende blendshape er valgfritt. Du kan slå det på for å generere tilfeldig øye-blinking imens spillet går."
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_MOVEMENT",
                "Kryss av denne innstillingen for å slå på semi ekte animerte øyer."
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_VISEMES",
                "For å få auto-valgt visemes funksjonen til å fungere, må du velge den mesh-en som har fjeset først. Dette er nok kropp mesh-en i de fleste situasjoner."
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_TITLE",
                "Kan ikke finne avhengighetene du trenger til prosjektet!"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_WARNING_PREFACE",
                "De følgene avhengighetene har ikke blitt oppfylt"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_FINAL_WARNING",
                "Vennligst installer alle avhengighetene før du installerer denne modulen!"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_DIALOG_ACCEPT",
                "Forstått"
            },
            { "ABI_UI_BUILD_RUNTIME_HEADER", "Last opp innhold til ChilloutVR" },
            { "ABI_UI_BUILD_RUNTIME_BTN_NEXT", "Fortsett til neste steg" },
            { "ABI_UI_BUILD_RUNTIME_BTN_PREV", "Tilbake til forrige steg" },
            { "ABI_UI_BUILD_RUNTIME_BTN_NEW_PICTURE", "Bytt bilde" },
            { "ABI_UI_BUILD_RUNTIME_FILEINFO_ASSETBUNDLE", "Eiendelspakke Fil Størrelse" },
            { "ABI_UI_BUILD_RUNTIME_FILEINFO_IMAGE", "Bilde Fil Størrelse" },
            { "ABI_UI_BUILD_RUNTIME_FILEINFO_MANIFEST", "Manifest Fil Størrelse" },
            { "ABI_UI_BUILD_RUNTIME_FILEINFO_PANO1K", "1080P Pano Fil Størrelse" },
            { "ABI_UI_BUILD_RUNTIME_FILEINFO_PANO4K", "4K Pano Fil Størrelse" },
            { "ABI_UI_BUILD_RUNTIME_HINT_CLICK_TO_CAPTURE", "Ta et mindre bilde for å ha et miniatyrbilde" },
            { "ABI_UI_BUILDSTEP_FILTERTAGS", "Filtrer Markører" },
            { "ABI_UI_BUILDSTEP_DETAILS", "Detaljer" },
            { "ABI_UI_BUILDSTEP_LEGAL", "Retts-Forsikring" },
            { "ABI_UI_BUILDSTEP_UPLOAD", "Last opp Innhold" },
            { "ABI_UI_BUILDSTEP_DETAILS_NAME_ROW", "Navn:" },
            { "ABI_UI_BUILDSTEP_DETAILS_DESC_ROW", "Beskrivelse:" },
            { "ABI_UI_BUILDSTEP_DETAILS_NAME_PLACEHOLDER", "Objekt navn (nødvendig!)" },
            { "ABI_UI_BUILDSTEP_DETAILS_DESC_PLACEHOLDER", "Objekt beskrivelse" },
            { "ABI_UI_BUILDSTEP_DETAILS_CHANGELOG_PLACEHOLDER", "Objekt endringslogg - fortell brukere om hva du har endret eller lagt til" },
            {
                "ABI_UI_BUILDSTEP_DETAILS_WARNING_NEW_OBJECT", 
                "Objektet blir lastet opp for første gang. Du må laste opp et profilbilde også, derfor er ikke muligheten til å laste opp uten å legge til et profilbilde der."
            },
            {
                "ABI_UI_BUILDSTEP_DETAILS_WARNING_UPDATING_OBJECT",
                "Du er på vei til å oppdatere dette objektet. Endring av beskrivelsen eller navn er ikke tilgjengelig når man oppdaterer objektet. Vennligst endre navn og slikt på hub-en hvis du må."
            },
            {
                "ABI_UI_BUILDSTEP_DETAILS_SET_ACTIVE_FILE", 
                "Sett denne opplastningen som den aktive filen for den målrettede plattformen"
            },
            {
                "ABI_UI_BUILDSTEP_DETAILS_LEGAL_PERMISSION",
                "Herfra bekrefter jeg at innholdet er mitt eller lisensiert til meg. Jeg er obs på at å laste opp opphavsrettbeskyttet innhold uten tillatelse fra andre |authors|, kan jeg få brukeren min |restricted| og eller få juridiske konsekvenser. Jeg vet at jeg må følge alt og alle innholds lagnings-regler nevnt i Alpha Blend Interactive sin vilkår for bruk."
            },
            {
                "ABI_UI_BUILDSTEP_DETAILS_LEGAL_TAGS",
                "Herfra bekrefter jeg at jeg har tagget riktig og at det passer til innholdet jeg laster opp. Jeg vet at hvis jeg er bevisst på å sette gale tags er et alvorlig lovbrudd. Jeg vet at brukeren min vil bli straffet hvis jeg fortsetter å sette gale tags."
            },
            {
                "ABI_UI_BUILDSTEP_UPLOAD_STEP_DETAILS", 
                "Innholdet ditt blir nå lastet opp til nettverket vårt. Opplastnings prosessen blir splittet i diverse trinn. Etter at filen har blitt lastet opp på nettverket vårt, vil den gå gjennom automatiske sikkerhets skjekker, etter at de er ferdige, vil vi kryptere bundle-en din og pushe den til CDN-en våres. Du kan se den nåværende statusen for opplastningen din."
            },
            {
                "ABI_UI_BUILDSTEP_UPLOAD_DETAILS_MISSING", 
                "For å laste opp innholdet til platformen våres, må det ha et navn. Når en laster opp et nytt objekt, gi det et passende navn. Du vil nå bli sendt tilbake til detalj siden for å taste inn et navn."
            },
            {
                "ABI_UI_BUILDSTEP_UPLOAD_LEGAL_MISSING",
                "For å laste opp til platformen våres, må du klargjøre at du har tillatelse til å laste opp, og at du har rett til å laste opp nevnte innhold, og at alle taggene er riktig. Du vil nå bli returnert til retts-siden for å evaluere og akseptere den juridiske forsikringa."
            },
            { "ABI_UI_DETAILS_HEAD_CHANGELOG", "Innhold Endringslogg" },
            { "ABI_UI_DETAILS_HEAD_STATISTICS", "Fil Statestikk" },
            { "ABI_UI_LEGAL_HEAD_OWNERSHIP", "Retts-Forsikring: Eierskap & Opphavsrett" },
            { "ABI_UI_LEGAL_HEAD_TAGS", "Retts-Forsikring: Markering" },
            { "ABI_UI_TAGS_HEADER_AUDIO", "Hørbar Opplevelse" },
            { "ABI_UI_TAGS_HEADER_VISUAL", "Visuell Opplevelse" },
            { "ABI_UI_TAGS_HEADER_CONTENT", "Innhold" },
            { "ABI_UI_TAGS_HEADER_NSFW", "Alder Port Klassifikasjon" },
            { "ABI_UI_TAGS_LOUD_AUDIO", "Høylytt" },
            { "ABI_UI_TAGS_LR_AUDIO", "Lang-Distanse Lyder" },
            { "ABI_UI_TAGS_SPAWN_AUDIO", "Skaper Lyder" },
            { "ABI_UI_TAGS_CONTAINS_MUSIC", "Har Musikk" },
            { "ABI_UI_TAGS_FLASHING_COLORS", "Blinkende Farger" },
            { "ABI_UI_TAGS_FLASHING_LIGHTS", "Blinkende Lys" },
            { "ABI_UI_TAGS_EXTREMELY_BRIGHT", "Ekstremt Lyst" },
            { "ABI_UI_TAGS_SCREEN_EFFECTS", "Skjerm Effekter" },
            { "ABI_UI_TAGS_PARTICLE_SYSTEMS", "Partikkel Systemer" },
            { "ABI_UI_TAGS_VIOLENCE", "Vold" },
            { "ABI_UI_TAGS_GORE", "Gore" },
            { "ABI_UI_TAGS_HORROR", "Skrekk" },
            { "ABI_UI_TAGS_JUMPSCARE", "Jumpscare" },
            { "ABI_UI_TAGS_HUGE", "Overdrivende Stor" },
            { "ABI_UI_TAGS_SMALL", "Overdrivende Lite" },
            { "ABI_UI_TAGS_SUGGESTIVE", "Antydende" },
            { "ABI_UI_TAGS_NUDITY", "Naken" },
            { "ABI_UI_API_RESPONSE_HEAD", "Nåværende Status" },
            { "ABI_UI_API_RESPONSES_UPLOADED", "Filen er lastet opp. Behandler nå filen." },
            { "ABI_UI_API_RESPONSES_SECURITY_CHECKING", "Ressurs-pakken blir nå sjekket av sikkerhetssystemet vårt." },
            { "ABI_UI_API_RESPONSES_ENCRYPTING", "Ressurs-pakke-filen din blir nå kryptert." },
            { "ABI_UI_API_RESPONSES_PUSHING", "Ferdig Skannet. Filen blir nå sendt til lageret våres." },
            { "ABI_UI_API_RESPONSES_FINISHED", "Ferdig med å laste opp. Innholdet ditt er nå tilgjengelig i spillet." },
            { "ABI_UI_API_RESPONSES_FLAGGED_BY_SECURITY_SYSTEM", "Ferdig med å laste opp. Filen din er markert av sikkerhetssystemet vårt og kommer kanskje ikke til å bli vist til visse brukere." }
        };
    }
}

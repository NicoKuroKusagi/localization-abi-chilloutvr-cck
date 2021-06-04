using System.Collections.Generic;

namespace ABI.CCK.Scripts.Translation
{
    public class German
    {
        public static readonly Dictionary<string, string> Localization = new Dictionary<string, string>()
        {
            {"ABI_UI_BUILDPANEL_HEADING_BUILDER", "Content Builder"},
            {"ABI_UI_BUILDPANEL_HEADING_SETTINGS", "Einstellungen & Optionen"},
            {"ABI_UI_BUILDPANEL_HEADING_DOCUMENTATION", "Unsere Dokumentation anzeigen"},
            {"ABI_UI_BUILDPANEL_HEADING_FEEDBACK", "Gib uns Feedback"},
            {"ABI_UI_BUILDPANEL_HEADING_FOUNDCONTENT", "Inhalte, die in der aktuellen Szene gefunden wurden"},
            {"ABI_UI_BUILDPANEL_HEADING_ACCOUNT_INFO", "Account Informationen"},
            {"ABI_UI_BUILDPANEL_LOGIN_CREDENTIALS_INCORRECT", "Die Login-Daten sind fehlerhaft"},
            {"ABI_UI_BUILDPANEL_LOGIN_BUTTON", "Anmelden"},
            {"ABI_UI_BUILDPANEL_LOGOUT_BUTTON", "Abmelden"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_TITLE", "Lokale Anmeldeinformationen für die CCK entfernen"},
            {
                "ABI_UI_BUILDPANEL_LOGOUT_DIALOG_BODY",
                "Dies entfernt die lokal gespeicherten Anmeldeinformationen. Du musst dich danach erneut authentifizieren. Möchtest du fortfahren?"
            },
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_ACCEPT", "Ja!"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_DECLINE", "Nein!"},
            
            {"ABI_UI_BUILDPANEL_UPLOADER_NO_AVATARS_FOUND", "Keine konfigurierten Avatare in der Scene gefunden. - Wurde CVRAvatar hinzugefügt?"},
            {
                "ABI_UI_BUILDPANEL_UPLOADER_NO_SPAWNABLES_FOUND",
                "Keine konfigurierten spawnable objects in der Scene gefunden. - Wurde CVRSpawnable hinzugefügt?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_WARNING_SPAWNPOINT",
                "Deine Welt hat keine spawn points festgelegt. Bitte füge einen oder mehrere spawn points in der CVRWorld Komponente hinzu. Ansonsten wird der Standort des CVRWorld holder objects genutzt."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_REFERENCE_CAMERA",
                "Du hast keine Referenz Kamera deiner Welt zugeordnet. Es werden die Standard-Einstellungen der Kamera genutzt."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_RESPAWN_HEIGHT",
                "Die Respawn-Höhe ist unter -500. Wenn man aus der Map gefallen ist, wird es lange dauern bis man zum Respawn-Punkt wiederkehrt. Das ist warscheinlich nicht etwas was du willst."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_MULTIPLE_CVR_WORLD",
                "Es sind mehrere CVR World objects in der scene vorhanden. Die Welt wird somit nicht funktionieren. Bitte stell sicher, dass sich nur ein CVR World object in der scene befindet oder verwende unser CVRWorld-Prefab."
            },
             {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_WORLD_CONTAINS_AVATAR",
                "Geladene scenes sollten niemals avatar und world descriptor objects gleichzeitig besitzen. Bitte richte deine scenes entsprechend ein."
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_NO_CONTENT",
                "Es wurde kein Inhalt in der aktuellen scene gefunden. Hast du vergessen einen descriptor component zu einem game object hinzuzufügen?"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_UNITY_UNSUPPORTED",
                "Du nutzt eine Unity-Version, welche nicht mehr unterstützt wird. Bitte nutze Unity 2019.3.1f1 (das Verwenden vom Unity Hub erleichtert das Versions-Management)."
            },
            {"ABI_UI_BUILDPANEL_UPLOAD_WORLD_BUTTON", "Welt hochladen"},
            {"ABI_UI_BUILDPANEL_UPLOAD_AVATAR_BUTTON", "Avatar hochladen"},
            {"ABI_UI_BUILDPANEL_UPLOAD_PROP_BUTTON", "Prop hochladen"},
            {"ABI_UI_BUILDPANEL_FIX_IMPORT_SETTINGS", "Import-Einstellungen anpassen"},
            {"ABI_UI_BUILDPANEL_UTIL_REMOVE_MISSING_SCRIPTS_BUTTON", "Fehlende Skripte entfernen"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_USERNAME", "Benutzername"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_ACCESSKEY", "Zugangs-Schlüssel"},
            {
                "ABI_UI_BUILDPANEL_INFOTEXT_DOCUMENTATION",
                "Benutze unsere Dokumentation, um herauszufinden, wie man Inhalte für unsere Spiele erstellt. Dort findest du auch Informationen, wie du das Meiste aus unseren Spielen herausholen kannst."
            },
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN1", "Bitte melde dich mit deinen CCK-Zugangsdaten an."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN2", "Diese kannst du auf hub.abinteractive.net finden."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN3", "Bitte generiere einen Zugangs-Schlüssel im Community Hub."},
            {"ABI_UI_BUILDPANEL_INFOTEXT_AUTHENTICATED_AS", "Angemeldet als"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_USER_RANK", "API Benutzer-Rang"},
            {
                "ABI_UI_BUILDPANEL_WARNING_FOLDERPATH",
                "Bitte benenne die Ordner des CCK nicht um und ändere nicht die Ordnerstruktur. Dies wird dazu führen, dass das CCK nicht korrekt funktioniert."
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FEEDBACK",
                "Einen Fehler gefunden? Du möchtest ein Feature vorschlagen? Gib uns Feedback!"
            },
            {"ABI_UI_BUILDPANEL_WARNING_MESH_FILTER_MESH_EMPTY", "MeshFilter mit fehlendem Mesh erkannt"},
            {
                "ABI_UI_ADVAVTR_TRIGGER_MULTIPLE_TRIGGER_HELPBOX",
                "Mehrere Trigger auf dem selben GameObject können zu unvorhersehbarem Verhalten führen!"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_POINTERS_HELPBOX",
                "Wenn Pointer zur \"Allowed Pointers\" Liste hinzugefügt werden, kann der Trigger nur noch von diesen Pointern ausgelöst werden."
            }
        };
    }
}

#define MyAppURL "https://github.com/Eqke/ContactsApp"
#define MyAppExeName "ContactsApp.exe"
#define MyAppName "ContactsApp"
#define MyAppVersion "1.0.0"
[Setup]
AppId={{F786CD3E-3A63-4282-B639-5DE65EAD7B71}
AppName = {#MyAppName}
AppVersion={#MyAppVersion}
AppPublisherURL = {#MyAppURL}
AppSupportURL = {#MyAppURL}
AppUpdatesURL = {#MyAppURL}
DefaultDirName = {pf}\{#MyAppName}
SetupIconFile = "C:\Users\Krazy\source\repos\ContactsApp\icon\MainFormIcon.ico"
DisableProgramGroupPage = yes
OutputBaseFilename = ContactAppSetup
Compression = lzma
SolidCompression = yes
OutputDir = "C:\Users\Krazy\source\repos\ContactsApp\src\ContactApp\InstallScripts\Installers"

[languages]
Name: "en"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Krazy\source\repos\ContactsApp\src\ContactApp\InstallScripts\Release\ContactsApp.dll"; DestDir: "{app}"
Source: "C:\Users\Krazy\source\repos\ContactsApp\src\ContactApp\InstallScripts\Release\Newtonsoft.Json.dll"; DestDir: "{app}"
Source: "C:\Users\Krazy\source\repos\ContactsApp\src\ContactApp\InstallScripts\Release\ContactAppUI.exe"; DestDir: "{app}"

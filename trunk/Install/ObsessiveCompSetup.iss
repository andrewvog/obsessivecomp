[Setup]
AppName=ObsessiveComp
AppVerName=ObsessiveComp 1.0
DefaultDirName={pf}\AceTools\ObsessiveComp
DefaultGroupName=
DisableDirPage=yes
DisableProgramGroupPage=yes
UninstallDisplayIcon={app}\ObsessiveComp.exe
OutputBaseFileName=ObsessiveCompSetup

[Files]
Source: "..\bin\Debug\ObsessiveComp.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\bin\Debug\AceLib.dll"; DestDir: "{app}"; Flags: ignoreversion

[Registry]
Root: HKCR; Subkey: "{code:FileExt}"; ValueType: string; ValueName: ""; ValueData: "{code:FileTag}"; Flags: uninsdeletevalue
Root: HKCR; Subkey: "{code:FileTag}"; ValueType: string; ValueName: ""; ValueData: "{code:FileDesc}"; Flags: uninsdeletekey
Root: HKCR; Subkey: "{code:FileTag}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{code:ExeBaseName}.EXE,0"
Root: HKCR; Subkey: "{code:FileTag}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{code:ExeBaseName}.EXE"" ""%1"""

[Code]
function FileDesc(Param: String): String;
begin
  Result := 'Steps File';
end;
function FileExt(Param: String): String;
begin
  Result := '.steps';
end;
function FileTag(Param: String): String;
begin
  Result := 'StepsFile';
end;
function ExeBaseName(Param: String): String;
begin
  Result := 'ObsessiveComp';
end;

:: x64 version of 7z
@ECHO OFF
@SET szpath=C:\Program Files\7-Zip
@SET path=%path%;%szpath%
@SET SDADDIN=AnotherSDThemeTool-0.1.0.sdaddin
@SET ADDINS=%APPDATA%\ICSharpCode\SharpDevelop5\AddIns
::@CMD.EXE /E:ON /V:ON /K


pushd %~dp0

  ::DEL mu.sdaddin
  ::http://7zip.bugaco.com/7zip/MANUAL/switches/type.htm
  ::7z a -r -tzip %SDADDIN% ../source/bin/debug/*
  7z a -r -tzip AnotherSDThemeTool-0.1.0.sdaddin ../source/bin/debug/*
  ::copy %SDADDIN% 


  ECHO.
  ECHO TO SHARP DEVELOP INSTALL
  ECHO.
  7z -y x %SDADDIN% -o%ADDINS%\AnotherThemeTool

popd

pause
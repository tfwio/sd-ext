:: x64 version of 7z
@ECHO OFF
@SET szpath=C:\Program Files\7-Zip
@SET path=%path%;%szpath%
::@CMD.EXE /E:ON /V:ON /K

DEL mu.sdaddin
::http://7zip.bugaco.com/7zip/MANUAL/switches/type.htm
7z a -r -tzip AnotherSDThemeTool-0.1.0.sdaddin ../source/bin/debug/*

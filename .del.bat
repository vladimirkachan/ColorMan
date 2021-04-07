rd /s /q "%ProgramFiles(x86)%\ColorMan" 
rd /q /s "%userprofile%\AppData\Local\ColorMan"
reg delete "HKCU\SOFTWARE\ColorManSoft" /f

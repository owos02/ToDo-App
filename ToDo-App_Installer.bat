@echo off
echo ---------------------------------------------------
echo ToDo-App erstellt von O. W. und M. D.
echo ToDo-App V1.0.
echo ---------------------------------------------------
pause
cls
echo ---------------------------------------------------
echo Installation wird jetzt beginnen.
echo Folgen Sie den Instruktionen.
echo ---------------------------------------------------
pause
cls
echo ---------------------------------------------------	
echo Folgen Sie den Instruktionen.
echo ---------------------------------------------------
pause
cls
echo ---------------------------------------------------
echo Druecken sie auf 'Datei Behalten'.
echo Erst wenn die Datei fertig installiert ist weiter machen
echo ---------------------------------------------------
pause
echo Chrome wird geoeffnet...
start chrome https://www.dropbox.com/sh/i9ld2c737xew5nr/AACDdQYhXuvyrd9rwGpqP_zba?dl=1
pause
cls
echo ---------------------------------------------------
echo Programm wird jetzt Installiert
echo ---------------------------------------------------
pause
cd C:\Users\%USERNAME%\Documents\
mkdir ToDo-App
copy C:\Users\%USERNAME%\Downloads\ToDo-App.zip C:\Users\%USERNAME%\Documents\ToDo-App\ToDo-App.zip
powershell -Executionpolicy Bypass -Command "Expand-Archive -Path 'C:\Users\%USERNAME%\Documents\ToDo-App\ToDo-App.zip' -DestinationPath 'C:\Users\%USERNAME%\Documents\ToDo-App\'"
del /f C:\Users\%USERNAME%\Documents\ToDo-App\ToDo-App.zip
cd C:\Users\%USERNAME%\Desktop
mklink /j C:\Users\%USERNAME%\Desktop\ToDo-App\ C:\Users\%USERNAME%\Documents\ToDo-App\
pause
cls
echo ---------------------------------------------------
echo Eine Verknuepfung des Ordners befindet sich nun auf dem Desktop!
echo Hiermit ist die Installation abgeschlossen. Sie duerfen das Fenster nun schließen.
echo ---------------------------------------------------
pause

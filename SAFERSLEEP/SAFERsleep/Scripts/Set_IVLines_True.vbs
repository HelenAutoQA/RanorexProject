Const ForReading = 1

Const ForWriting = 2

Set objFSO = CreateObject("Scripting.FileSystemObject")

Set objTextFile = objFSO.OpenTextFile("C:\Program Files\SAFERsleep\SAFERsleep OR\SAFERsleepOR.ini", ForReading)


Do Until objTextFile.AtEndOfStream

    strNextLine = objTextFile.Readline


    intLineFinder = InStr(strNextLine, "required.allivlinesflushed=false")

    If intLineFinder <> 0 Then

        strNextLine = "required.allivlinesflushed=true"

    End If

    strNewFile = strNewFile & strNextLine & vbCrLf

Loop


objTextFile.Close


Set objTextFile = objFSO.OpenTextFile("C:\Program Files\SAFERsleep\SAFERsleep OR\SAFERsleepOR.ini", ForWriting)


objTextFile.WriteLine strNewFile

objTextFile.Close
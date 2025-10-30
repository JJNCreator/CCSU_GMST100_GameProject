INCLUDE globals.ink
->Start
===Start===
# speaker:You # portrait:portrait55 # layout:right
Welcome to the game!!! Text <b>Text</b> Text Text Text Text Text Text Text
Text Text Text...
Text Text Text...
Text Text Text...
+[Check Left]->Check
+[Continue]->Continue
====Continue===
# speaker:You # portrait:portrait55 # layout:right
You continue on!
+[Onwards!]
~scenechange = 2
->DONE
===Check===
# speaker:You # portrait:portrait55 # layout:left
Portrait on the left, did it switch?!
You continue on!
+[Onwards!]
~scenechange = 2
->DONE
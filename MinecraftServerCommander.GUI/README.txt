MSC - Minecraft Server Commander

 *  How do i use this application?
When you load it up, you will notice all the controls are grayed out, this is because you haven't told it where your server executable is yet.
Click the browse button in the top right corner and browse to your server exe (usually Minecraft_Server.exe).
Now the controls will be enabled. Press "Start Minecraft Server" to load up the server.
The "Give" window enables you to give an amount of an item to one or multiple players without retyping it every time.
Simply write the player(s) name(s) in the name box (multiple names separated with a semi-colon (;)) choose an item in the dropdown list and how many of it to give.
Then press the Give! button and you're done! You can press the give button multiple times to give them more of that item.

 *  The Auto Command System
The auto command system (ACS) can be used to automatically execute one or more commands on the server with X seconds between each execution.
Simply write a command in the textbox and click "Add Command" to add it to the ACS. Select a command and click "Remove Command" to remove it from the list.
Click "Clear list" to remove all commands.
Choose how many seconds you want it to wait before executing the commands and then click "Start Auto Command System".
It will not start if there are no items in the command list.

 *  Executing a file
The app supports execution of files. The files are simple text files (with the extension "mcfg") with one command on each line.
Lines starting with the hash/sharp(?) character (#) are ignored as comments.
An example of such a file could be:
  say This is a mcfg file
  #Epic comment
  # Nicer comment
   #This is not a comment (starts with a space)
  say This is another command on another line
  save-all
  say I just did a save-all command!
Then you save that as a text file with the mcfg extension.
Then go into the app, browse for the file and click "Execute!".


 *  More information
For more information, please visit http://www.f16gaming.com/?id=8 or read the README file in the root directory.

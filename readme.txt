Hello!

This is my TES3MP Server Manager. This manager will allow you to start/stop your TES3MP server, view live server output, and view/manage players' data.
Due to this being the first iteration of the project, so some things may be missing or unfinished, but the core functionality and many useful features already exist.

A few things to note due to the program's early state:
- You will need to run the server using Linux. This is because of the way the program writes server commands. I will eventually write a wrapper class to allow for different kinds of OS's to work. I've run and tested this on Ubuntu, and so far this works with no problems.
- You will need to log in using a .PEM file. Again, due to the early state of this program, this is the only way of connecting; however, I do plan to add different ways of connecting.
- You will need to have port 22 open to connect.
- While I've done my best to make the program as safe and non-volatile as possible, there is still room for bugs and errors, so I'd recommend backing up your server/precious data that you don't want to risk losing, mainly the player data.
- This is assuming you've got administrator access on your OS. I've not tested it with limited permissions
- I have not tested if this works with a modded server. I've only ever used/tested it on 100% vanilla.
- If there is trouble with keeping the values in the properties.txt file, simply delete it and do not modify it. A new properties.txt file will be created upon running the program. It can be inconsistent.

IMPORTANT STEPS:
- In the Server Files folder, there is a shell script called "feedcmd.sh". Do not rename this or change it. Add it to the directory where the other server files are located.
- Make sure you have tmux installed. This is so that you can run both the server and the output feed without having to have an open SSH session to keep it running. Even if not using this software, it's a useful tool to have at your disposal.

# TES3MP Server Manager
## Overview
- This is a tool used to manage a TES3MP server, mainly reading server output and modifying player data.
- This version currently supports Linux servers only, with planned support for other operating systems in the future (Windows, macOS).
- You must use a .PEM/private key file to log in currently. There will be future support for other SSH login methods.
- Tmux must be installed on your version of Linux to run the server from this software.
## How To Set Up
### NOTE: This software has only been tested on a clean, Vanilla version of TES3MP.
- Download the files for TES3MP and extract it into a directory (https://github.com/TES3MP/openmw-tes3mp/releases).
- Upload the `feedcmd.sh` script (Server/feedcmd.sh) into the main directory of the server
- Launch the program, and give proper credentials
- Type the directory of your TES3MP server
- Confirm it is in the right directory by reading the files that are shown
- You're all set! If you put in the feedcmd.sh file into the main server directory, you can now receive an output from the server when you start it.
#
Due to the early stages of this software, there may be bugs and other errors that I may not have accounted for. 
I'm doing my best to keep it as safe and error-proof as possible, but there may be mistakes. 
If you find any errors, please email me at michaelkellamcs@gmail.com

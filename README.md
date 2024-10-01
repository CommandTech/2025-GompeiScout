2024 Scouting Code Redone from scratch.
Rewritten to help make it easier for new users to understand, modify, and use.


Wants:

--Code Changes--
- [x] Modular design (Code that doesn't change stays in a folder that doesn't get touched. Code that changes every year is in a different folder.)

- [x] See if you can overlay different screens on top of each other

- [x] Make a way to refresh the amount of controllers connected while running. (Either always looking or a button on the screen to look)

- [x] Make the API key in 1 spot in the entire code

- [x] Have a save/load option (Try out ini files)

- [ ] Event checklist screen (Not having to load excess events that you don't care about)

- [x] Select where controllers are located in base program (the addon made in 2024 but better and designed from the start)

- [ ] Training mode or interface with sound cues

--Match Preview Report\Website--
- [ ] Modular data interface (be able to see what other teams also are looking at for data)

- [ ] Alliance selection stuff (show the strengths of each alliance during alliance selection and hide teams that have been selected already)

- [ ] Paper scouting and drive team notes that only show up for our team


# Scouting Code Redo
Credit to Team 842 Falcon Robotics for the original scouting system.
https://www.chiefdelphi.com/t/falcon-scouting-system-release/126808

## Software
Coded and run inside Microsoft Visual Studio

Database using SQLite and SQL Server Management Studio

Match Preview Report and data visualization using Excel

## Setup
To use the software, you need at least one Xbox Controller plugged into the laptop running the software, a maximum of 6 controllers. Need SQL server installed onto the laptop for the code to connect to and Excel getting the data from the database.

To get the data from The Blue Alliance you will need to create a Read Me API Key from https://www.thebluealliance.com/account. After that,  go into Settings.settings inside the Properties folder and change the API_KEY value to your api key

## Usage
![UI](https://imgur.com/a/o93N5I5.png)

When the code starts up, the interface will be prompted.
The user will need to load the events through the **Load** button at the top. This connects to The Blue Alliance API. After the code gets the events, the user will need to find the name of the event in the list of events, sorted by event code. 

After the event is selected, the user will need to press **Get Matches** to load the matches into the software. It will then ask if the red alliance is on your right[^1]. Then it will ask if you want to start from match 1. After you select your option, the interface will automatically select the teams for each scouter.

At the end of the match, when every scouter is ready to go to the next match. The user will check the box for the end match at the top and click the right arrow. This will send the data for EndMatch to the database.

In case of code exiting during an event, the code should automatically save the current data (match number, event code, red right, priority scouting) just re-open the code, click on load previous data.
If it does not save the data, just load events and get matches and use the arrow at the top until you get to the match

## Controls
![Auto Mode Controls](https://i.imgur.com/aaHGLxW.png?1)
![Teleop Mode Controls](https://i.imgur.com/SaYmYmg.png)
![Endgame Mode Controls](https://i.imgur.com/8mVOZt8.png)

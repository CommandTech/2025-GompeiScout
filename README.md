2025 Scouting System for FRC 190: Gompei and The H.E.R.D.






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
![UI](https://i.imgur.com/sNAvQks.png)

When the code starts up, the interface will be prompted.
The user will need to load the events through the **Load** button at the top. This connects to The Blue Alliance API. After the code gets the events, the user will need to find the name of the event in the list of events, sorted by event code. 

After the event is selected, the user will need to press **Get Matches** to load the matches into the software. It will then ask if the red alliance is on your right[^1]. Then it will ask if you want to start from match 1. After you select your option, the interface will automatically select the teams for each scouter.

At the end of the match, when every scouter is ready to go to the next match. The user will check the box for the end match at the top and click the right arrow. This will send the data for EndMatch to the database.

In case of code exiting during an event, the code should automatically save the current data (match number, event code, red right, priority scouting) just re-open the code, click on load previous data.
If it does not save the data, just load events and get matches and use the arrow at the top until you get to the match

## 2024 Controls
![Auto Mode Controls](https://imgur.com/a/ToLluo7)
![Teleop Mode Controls](https://imgur.com/0vDOqkX)
![Defense Mode Controls](https://imgur.com/Gn8Pd11)
![Surfacing Mode Controls](https://imgur.com/OWMkUOq)

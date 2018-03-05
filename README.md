# NieR: Automata - Chapter Select + Debug Mode Unlocker
Allows users to unlock Chapter Select and Debug Menu/Room by editing their save files.

**Make backup of your saves and use at own risk!**

## Usage

1. Download the latest release from the [Releases](https://github.com/Idearum/NieRAutomata_Chapter_Select_Debug_Mode_Unlocker/releases) tab.
2. Run the application and open the appropriate SaveSlot_#.dat file.
3. Tick the boxes for what you want unlocked.
4. Click Save to write the changes to the file.
4. Play the game!

## About

A single byte stores four different states using half its bits.

0000 0001
        ^-Unknown state #1.
0000 0010
       ^- Unknown state #2.
0000 0100
      ^- Enables Chapter Select and Debug Room
0000 1000
     ^- Enables the Debug Menu (RT + Back)

A finished save will have all of these states enabled, meaning 0000 1111.

# MuhammadMohsin_WRLDFlightProject
## Description
WRLD flight project is simulator based "Shoot'em up" game in which the player controls an aicraft to fly over a real world based map and shoots enemies on the ground.
## Components
### Player POV
A third person view camera is used to give the player a good view of both the helicopter and the map. Player can drag the mouse on screen to get a different angle view of the screen.
### Player Controls
Player controls include the following:
1. Ascend helicopter (Key used: "Z").
2. Descend helicopter (Key used: "X").
3. Movement in X-Z plane (Keys used: "WASD" & "Arrow keys").
### Main Objectives
Following were the objectives of this project:
1. Users should be able to fly the helicopter over the map. The helicopter should move
forward and backward. It should also rotate left and right. It does not need to have
realistic movement. Just basic movement in each direction is acceptable.
2. You will need to place enemies on top of buildings around the area. The enemies can be
hard coded to be placed at fixed locations (Latitudes and Longitudes) but they must be
placed on top of buildings using the building api.
3. Enemies should also be placed on the roads just like on buildings.
4. The player’s helicopter should fire bullets at the enemies. It should auto target whatever
enemy that is roughly in front of the helicopter. Enemies should be destroyed after a few
hits from the player and respawn after some fixed time.

Objectives 1 and 2 are complete and objective 3 and 4 are in progress.
### Bonus Objectives
1. Implement movement in a way that the helicopter stays still but the map scrolls instead
so the player simply feels that helicopter is flying.
2. Place enemies on buildings by adding POIs in the Map Designer tool instead of
hardcoding enemy locations. Use the WRLD POI API to load those POIs in Unity as
enemies.
3. Use an object pool to avoid instantiating and destroying 3D objects.

Work on bonus objectives has not been started yet.

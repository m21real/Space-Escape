# Space-Escape by Mark Ojo

#### Player Controls:
WASD / Arrow Keys - Movement

Space - Jump

E - Enter Door (Only when in front of door)

Q - Enable/Disable Anti-Gravity (Only in anti-gravity room / Level 2)

MouseClick - Fireball (Only in Level 1)

## Newtonian physics
Added gravity and basic physics

Player has anti-gravity function which changes the gravity scale of the player to -1, allowing them to float up to the ceiling and walk on it

## Collision detection
Door only opens when the player is standing near it and presses “E”

Spike traps detect player and take a life away, appropriate collision volume for traps and player RigidBody

Enemy patrols specific area which I set using invisible Colliders

Collectibles around the map detect the player and get picked up when the player goes into their field

Platforms where the player can jump on and have appropriate RigidBody volume

Player can shoot fireballs at enemy, which causes -1 health to enemy (yet to implement death animation)

## Collision response and feedback
Player loses life when on spike traps

Patrolling enemy stops when player is in front of them (have not implemented taking damage from enemy)

Player gains points when picking up crystals

Player gains life when picking up heart (have yet to implement keeping lives the same across scenes)


## State based behaviour
Main menu where player can quit or start game

Overworld where player can enter levels by going through doors, and on return player is positioned outside the door they just returned from

Simple opponent that patrols specific area and detects when player is in sight

Finite state machine that detects when player is moving and when the player is idle (state is displayed on screen, top left corner)

Hierarchical state machine that detects when player is moving & idle (sub-states of Grounded state), and when the player is jumping 

## Probability and game design
Scene management between levels that handles scene switching

Health system for player and enemy

Scoring and points system, positive feedback loop

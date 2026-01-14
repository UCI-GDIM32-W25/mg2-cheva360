[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog

### Write about how the plan you wrote in the MG2 break-down activity connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

In my diagram I specifically labeled which attributes (components) each gameobject would have as well their interactions with each other game object.
- The penguin gameobject had a rigidbody2d and a collider2d which allowed for movement and colliding with the coin prefab
- The coin prefab had a collider2d set to trigger which allowed for the penguin to collect it
- The text gameobject is referenced in the player script to update when the player collects a coin which updates the score.
- The ground also had a box collider with the tag ground which allowed the penguin to jump on top of it

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
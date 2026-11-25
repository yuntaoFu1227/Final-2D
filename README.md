# GDIM 31 Final: 2D
## Devlogs
### Milestone 1
TODO.
One technical problem I encountered while developing my game was that the items moved upward instead of falling down when I entered Play Mode. I initially thought there was a problem with gravity, so I checked the Rigidbody2D components of the items, including their Gravity Scale and Mass. I also checked the Transform positions and the Kickable script to understand whether the problem was related to physics settings or the force applied to the items.
To solve this problem, I undid my recent changes and checked the settings again. I made sure the Rigidbody2D components were set to Dynamic with a Gravity Scale of 1. I also adjusted the items’ positions and tested the game again. After restoring the settings, the items behaved normally. This experience helped me understand how Rigidbody2D, gravity, and object positions affect the movement of GameObjects in Unity.
### Milestone 2
TODO.

## Playtesting Reports
### Milestone 1
#### Report 1
TODO.
The game was enjoyable, and the character movement felt smooth. The controls were simple and easy to learn.
Bugs: No bugs found during playtesting.
#### Report 2
TODO.
I really liked the decorations and the overall visual design of the game. The environment was creative and made the game more enjoyable.
Bugs: No bugs found during playtesting.
### Milestone 2
#### Report 1
TODO.

#### Report 2
TODO.

## Open-Source Assets
- [Interior sprites](https://rcpstd.itch.io/interior-tileset-asset-pack-16x16)
- [Ninja cat sprites](https://opengameart.org/content/cat-fighter-sprite-sheet)
- [Food sprites](https://ghostpixxells.itch.io/pixelfood)
- [More food and item sprites](https://ipixl.itch.io/pixel-art-items-part-1)
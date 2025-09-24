# Revisions List  

Month, Day, Year  

9/10/25
9/15/25
9/17/25
9/20/25
9/21/25
9/22/25


## Game Vision and Outcome

Initial idea of utilizing the classic *Tanks* type gameplay of navigating, strategizing and eliminating foes through maze-like maps and the ability to ricochet bullets.  
Furthermore augmenting the gameplay through the idea of destructible walls in a level to open up new strategies and ways to play.  

Due to technical issues we'd pivoted to a 2D sidescroller to which we'd change movement options to diversify player's ways they interact with the level and environment.  
Thus we'd landed on the vision of a **Projectile Hopper**  in which the player inherently doesn't move and instead uses a **tool** of some kind to *move, explore, and experience the game*  

### Objective Statement  

Players will feel accomplished as they master the use of a revolver to both navigate through levels *and* eliminate enemies.  

### Design Rationale  

The experience we envision and want to deliver is one where the player understands the simple control scheme and can engage in a multitude of playstyles when making their way through levels, all while balancing a resource.  

Whether that be to do it as fast as possible, or to take out the enemies and get the highest score or gain rewards for it, or to meld those two things and play somewhere in the middle. The desire is to allow the player to practice something simple and understand how they can develop that skill it to an extreme, perhaps to engage with levels that ramp in difficulty.  

Furthermore, due to the simplistic control scheme it would allow for obstacles and level design to take the stage and make navigation as a whole the main focus of the game/contract. Maximising the fun of the movement through *where and how* the player moves is the goal and makes proper depth in the design.  

### Code Rationale  

Due to the focus of the controls, much of the code would revolve around tracking the mouse position and adding force in the opposite direction when clicking to fire the gun. That is in addition to spawning a projectile with the force and approrpiate direction. Additionally, a function to count the bullets used and to disable the shooting once a certain amount was exceeded.  

That however would be reset on contact with the ground, *raycasting* proved invaluable in the process of determining how and when the player was grounded.  

Much of the aiming had the player model used as a **Transform** for tracking the position of the cursor to calculate the proper angle the bullet would travel and propel the player in the other direction.  

## Aesthetics  

We are realistically limited to the assets we could pull quickly and for free or cheap from the unity store, and ideally due to the firearm it would be something like a wild west aesthetic however the classic private eye noir aesthetic was also under a potiential consideration were we to take the contract further.  

## Difficulties and Hurdles  

We'd initially experienced many design hurdles over how to engage with the contract and what exactly to do. Our first idea wasn't easily cloned and modified so we were left brainstorming for quite a while, without real direction. That was all until Allister had compiled a list we'd sifted through and gave opinions on, and when we'd settled on an idea we were all familiar with and filled with nostalgia for everything began to fall into place much easier.  

When it came to the coding, much of the difficulties came from the vector math when determining how to allow the bullet to shoot *from* a specific angle origin as well as determining how to properly reload the gun without providing extra ammunition. The latter solution was simple and found relatively quickly with minimal pains whereas the former took much more time and rigorous testing but eventually it was quashed.  

### Roles  

Allister Wylie took a great lead of the greater team and gave the rest of us direction and instruction when we needed it. He'd also taken on the task of finding assets and coding and modifying code as needed to make the project function as intended. They'd also aided Josh in properly setting up the GitHub for LFS and use of release tags.  

Olwyn Roberts aided greatly in design of the project, expanding the scope, and recording the game demo video as well as the script for it.  

Josh Simon was a late addidtion but he'd helped keep proper scope of the project and produced possible level designs when this contract will continue. He'd also playtested the game-feel of the demo, assuring it's quality.  

Elijah Francis was and is in charge of writing the GDD, this document and parsing information and how to properly log and register all happenings throughout the contract, good and bad.  

## Citations and References  

Marel, I. (2020, October 6). Aim at mouse in Unity 2d (Shoot Weapon, unity tutorial for beginners). Unity. https://discussions.unity.com/t/trying-to-make-a-2d-object-launch-towards-the-mouse-when-i-left-click-can-anyone-help/240477  

Monkey, C. (2019, February 29). Aim at mouse in Unity 2d (Shoot Weapon, unity tutorial for beginners). (Text - Code Monkey). https://unitycodemonkey.com/text.php?v=fuGQFdhSPg4  

Technologies, U. (n.d.). Lost Crypt - 2D sample project: Tutorial projects: Unity asset store. Tutorial Projects | Unity Asset Store. https://assetstore.unity.com/packages/essentials/tutorial-projects/lost-crypt-2d-sample-project-158673  

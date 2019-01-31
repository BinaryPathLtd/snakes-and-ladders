For this project I wrote everything test-first.  I have attempted to ensure that in order to make tests pass, I implemented the *simplest* possible code.  For me this is a fundamental requirement for doing TDD.  This 'simplest possible' approach should explain code such as: 

``` public void RollDie()
        {
            // random number generator to be used here :)
            this.Move(4);
        }```
		
and 

```public void Start()
        {
            this.Players[0] = new Player(1, boardSize);
        }
```

Given more time I would have of course allowed for multiple players to work correctly in the game.  

In other areas, I would have improved the ```Move()``` method in the Player class to ensure that a player could not remain on a board position larger than the board size.   I note from the kata that this scenario is covered by other feature specs.

Game Objects and code assumptions:
=
The following is a list of assumptions and object properties. 

Game
 - can start
 - can be won (any player on square 100) 
 - has Player(s)
 - has a winning square (board size in this domain)

Player
 - can move by rolling die
 - has die (?)
 - can win by landing on exactly 100
 [not implemented] 
 - can move backwards (snake)
 - can move more than 6 spaces (ladder)
 - cannot move more than <board size> places forwards or backwards (implicit) 

Die (could be coupled to player) 
 - can return between 1 - 6 randomly
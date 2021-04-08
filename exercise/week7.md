# Week7 Exercise

Now, you are an engineer who accept a commission from New York Yankees coaching team. You need to write 3 programs to complete this commission.

To learn more about your client, refer to [Yankees official Website](https://www.mlb.com/yankees/) 


Please note that 
* 1 unit of Y means 100m, so gravity should be defined as
```c#
const double g = 0.1 
```
* 1 unit of X means 1m
* 1 unit of time means 1's

## Easy
#### Question: Drawing Horizontal Projectile Motion Trajectory
First, you need to write a program to stimulate how baseball falling. 

The coaching team would like to input maximum horizontal distance NX, maximum vertical distance NY, and initial of velocity v0 in the beginning. Output how long does the ball stay in the air and draw the trajectory. 


Utilize 3 function to complete this program:

* Update screen:
```c#
void updateScreen(int x, int y, int NX, int NY,  char[,] screen) 
```
* Get horizontal distance:
```C#
int getHorizontalDistance(double v0, int time)
``` 
* Get vertical distance:
```C#
int getVerticalDistance(double gravity, int time)
``` 
call `Console.Clear()` each time unit.
'o' present the ball.
ball's initial position is (0, NY).


#### Example1:
```
Please Input NX:
70
Please Input NY:
24
Please Input V0:
3.0
```
then
```
o  o  o  o  o
               o  o
                     o
                        o
                           o
                              o
                                 o
                                    o
                                       o
                                          o

                                             o
                                                o

                                                   o

                                                      o

                                                         o

                                                            o

                                                               o

Reach ground at 22's
```
#### Hint
1. refer to *plottingtrajectory.Program.cs* in the lecture, CH6.

## Medium
#### Question: Catch The Fly Ball
For this program, you need to judge if a baseball player can catch the fly ball.

The coaching team would like to input maximum horizontal distance NX, maximum vertical distance NY, and baseball player running speed V in the beginning. Output if the baseball player can catch ball, and draw the ball falling trajectory and player running locus.

Plese uniformly random initial velocity of ball v0 in range [0.5, 5.0], and sample initial height of ball randomly from normal distribution (mean = <img src="http://www.sciweavers.org/tex2img.php?eq=%5Cdfrac%7B3%7D%7B4%7D%5Ccdot%20NY&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0" align="center" border="0" alt="\dfrac{3}{4}\cdot NY" width="53" height="43" />, std = <img src="http://www.sciweavers.org/tex2img.php?eq=%5Cdfrac%7B1%7D%7B12%7D%5Ccdot%20NY&bc=White&fc=Black&im=jpg&fs=12&ff=arev&edit=0" align="center" border="0" alt="\dfrac{1}{12}\cdot NY" width="64" height="43" />)  

Note that both initial x axis of ball and player are 0. Print message "Catch the Ball!" if player catch ball, otherwise, print "Cannot Catch the Ball!"

Catch ball is that `player x >= ball x, when y = 0.`

- 'o' present the ball.
- 'I' present the baseball player.


Utilize 4 functions to complete this program:

* Update screen:
```c#
void updateScreen(char symbol, int x, int y, int NX, int NY,  char[,] screen) 
```
* Get horizontal distance:
```C#
int getHorizontalDistance(double v0, int time)
``` 
* Get vertical distance:
```C#
int getVerticalDistance(double gravity, int time)
``` 
* if catch ball
```C#
bool catchBall(int xBall, int xPlayer)
``` 



#### Example1:
```
Please Input NX:
70
Please Input NY:
24
Please Input player velocity V:
3.0
```
then

```C#
oo oo o
       o o
           o
            o
              o
               o
                 o
                   o
                    o
                      o

                       o
                         o

                          o

                            o

                              o

                               o

                                 o
I  I  I  I  I  I  I  I  I  I  I  I  I  I  I  I  I  I  I  I  I  I
Catch the Ball!
```
### Example2:
```
Please Input NX:
70
Please Input NY:
24
Please Input player velocity V:
0.1
```
then
```
ooooo
     oo
       o
        o
         o
           o
            o
             o
              o
               o

                o
                 o

                  o

                   o

                    o

                      o

                       o
III
Cannot Catch the Ball!
```



#### Hint
1. random.NextDouble() sample from unifrom distribution, you can learn more information about how to sample random variable from gaussian distribution by searching keyword **random gaussian c#**. 

## Hard
#### Question: User Control (Catch Fly Ball Game)

Follow to previous problem, in this program, you need to allow user to control baseball player and strive to catch fly ball.

The coaching team would like to input maximum horizontal distance NX, maximum vertical distance NY in the beginning. Allow user control baseball player action. Output if the baseball player catch ball, and draw the current position of ball and player each time unit.

keyboard input
- `Space`, player stand still.
- `W`, player jump 1 unit along y axis, then return original position at time *t+1*.
- `D`, player run forward 1 unit along x axis.
- `A`, player run backward 1 unit along x axis.
- `S`, player diving catch, forward 2 unit along x axis, then freeze at time *t+1*.

please print out 
- "Nice play! Out." if player use diving catch to cath the ball.
- "Out." if player catch the ball without diving catch.
- "Hit!" if player cannot catch the ball.
- "Home Run!!" if the ball reach the bound of x axis without reach ground yet.

Catch ball means `player x = ball x, and player y = ball y`

Utilize 4 functions to complete this program:

* Update screen:
```c#
void updateScreen(char symbol, int x, int y, int NX, int NY,  char[,] screen) 
```
* Get horizontal distance:
```C#
int getHorizontalDistance(double v0, int time)
``` 
* Get vertical distance:
```C#
int getVerticalDistance(double gravity, int time)
``` 
* if catch ball
```C#
bool catchBall(int xBall, int xPlayer, int yBall, int yPlayer)
```

initial ball position is (0, NY)


For more info about funny game and user control, refer to *GUI and UserEvent* in the lecture, Ch12.

#### Example1:
```
Please Input NX:
70
Please Input NY:
24
player action:
D
```
then
```
 o
     
       
        
         
           
            
             
              
               

                
                 

                  

                   

                    

                      

 I
player action:
D
```
then
```
  o
     
       
        
         
           
            
             
              
               

                
                 

                  

                   

                    

                      

  I
player action:
W
```
then
```

   o
     
       
        
         
           
            
             
              
               

                
                 

                  

                   

                    

                      

  I                    

player action:

```

#### Hint
1. Use infinite loop to enable unlimited user input.

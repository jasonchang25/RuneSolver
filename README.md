<strong>RuneSolver</strong>

_Note - Method has been patched a long time ago and source code has been released for educational purposes only._

RuneSolver is a SaaS desktop application used in conjunction with macro programs to solve Maplestory's directional arrow captcha puzzles with a 90% degree of accuracy. In addition several other in game quality of life features have automated to improve farming rates.

<strong>Specifications:</strong>
    
    Build & software used:
    - .Net core - Back End
    - MSSQL - Production Database (Sql Express for MVP)
    - SSMS - Database Management
    - .Net Winforms - Front End
    - Azure Cognitive Services - Production Image recognition Service (Tensorflow EfficientDet model used for MVP)
    
    Host:
    Hosted on Microsoft Azure (has been removed)
          
 <strong>Details:</strong>
  
The main grunt of the program is the 'rune' solving aspect. To conform with compatibility across other popular Maplestory macro softwares at the time, the program takes a folder directory as the input. Every x amount of time the software will detect if a new captcha image is added and query an API endpoint of the trained model to receive the result in JSON format. 

![rune_example](https://user-images.githubusercontent.com/21240686/121875579-f87b3f00-cd4b-11eb-8212-6f4fc73ee6f9.png)

The correct permutation of the result is then found by ordering the outputs based on x,y coordinate from left to right. After the correct solution is found, the keystrokes are then inputted into the game via DirectX keyboard inputs (other methods are detected and blocked from my knowledge).

To prevent severe inflation of the in-game economy a capped concurrent session limit has been enforced on each account based on subscription level.

<strong>Application UI Screenshot:</strong>

![image](https://user-images.githubusercontent.com/21240686/121875985-658ed480-cd4c-11eb-95ce-0d8fc58a4ce6.png)

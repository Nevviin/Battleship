# Battleship

battle ship api to create board, add a battle ship and take an attack and report it as hit or miss
navigate to the url http://nevinsbattleship.azurewebsites.net/

# Api is exposing one endpoint  as showing in screenshot below 

![image](https://user-images.githubusercontent.com/11384742/105646305-4f928b80-5ef3-11eb-8fb1-c4ef829725c3.png)

# Only battleship(one type of ship) is configured via constructor dependency injection in application start
Battleship has 4 squares and here it is confgured from A1 to A4 

highlighted in green sqaure in below screenshot

![image](https://user-images.githubusercontent.com/11384742/105646430-02fb8000-5ef4-11eb-9b12-cf6379df2831.png)

# To attack or take a shot 
navigate to the url http://nevinsbattleship.azurewebsites.net/
Click on the "Try it out" button and enter the coordiates here for eg its entered as A6

![image](https://user-images.githubusercontent.com/11384742/105646489-5a99eb80-5ef4-11eb-9255-c2533293e91c.png)


result 

![image](https://user-images.githubusercontent.com/11384742/105646596-d4ca7000-5ef4-11eb-90f1-38b957d5917c.png)

the result is a miss , since battleship has only 4 sqaures and here we have confugired from A1 to A4 

IF we try A4 result is hit as below 


![image](https://user-images.githubusercontent.com/11384742/105646661-2f63cc00-5ef5-11eb-90ff-ea29618665d7.png)



# TempMan
A CLI application that converts a unit of temperature into every other unit of temperature.

## Getting Started
* Fork the project

* Clone YOUR fork:
```git clone https://github.com/[YourUserName]/LearnCsharp-TempMan```
***Note**: This will create a folder in what ever your current directory is...*

* open the project in **Visual Studio**
* Start `coding`.

### Prerequisites
[Git-scm](https://git-scm.com/) - The tool used to interact with github. 
***Note**: This isn't required. if you want to use git kraken or just download the project go for it,*

[VisualStudio - Community Edition](https://visualstudio.microsoft.com/vs/community/) - The IDE being used.

## Features
#### Arguments
|Flag| Description |
|--|--|
|-F| the number in the args is Fahrenheit |
| -C |  the number in the args is Celsius|
|-K| the number in the args is Kevlin|
| -Ro | the number in the args is Romer|
| -Re | the number in the args is Reaumur|
| -N | the number in the args is Newton|
| -R | the number in the args is Rankine|
| -De | the number in the args is Delisle|
| -to | takes a unit and converts only to that unit, i.e tempman.exe 60 -f -to c|
| -RandCon | returns a random unit that is not the passed in unit|
| -Out | takes a path and writes the conversions to a file.|
| -Ui | runs the app in UI MODE!?!|

***Note:*** more features are  to come when I think of them, just so you know.


## Demo
* [Download](https://github.com/JamilAbdelfattah/LearnCsharp-TempMan/blob/master/LICENSE) the executable.
* Open command-prompt and [cd](https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/cd) to its Directory:
* Run this command: 
```TempMan.exe -f 52```
***Output:***
    ```
    units for 52F:

    ================
    Conversions
    ================
    Celsius:	26C
    Kevlin:		29K
    Romer:		60Ro
    Reaumur:	80Re
    Newton:		85N
    Rankine:	452R
    Delisle:	54De
    ================
this is the functionality you will be replicating, when you create your solution, fimilarize your self with how it works, so you can replicate it as best as possible.


## Wiki
Confused about the units?<br/>
Here are some Wiki articles with formulas!<br/>
##### [Units of Temperature Conversions:](https://en.wikipedia.org/wiki/Conversion_of_units_of_temperature)<br/>
[Fahrenheit](https://en.wikipedia.org/wiki/Fahrenheit)
[Celsius](https://en.wikipedia.org/wiki/Celsius)
[Kelvin](https://en.wikipedia.org/wiki/Kelvin)
[Rømer](https://en.wikipedia.org/wiki/R%C3%B8mer_scale)
[Réaumur](https://en.wikipedia.org/wiki/R%C3%A9aumur_scale)
[Newton](https://en.wikipedia.org/wiki/Newton_scale)
[Rankine](https://en.wikipedia.org/wiki/Rankine_scale)
[Delisle](https://en.wikipedia.org/wiki/Delisle_scale)

## Finished?
Push to your branch by:<br/>
```git add .```<br/>
```git commit -m "Your message here"```<br/>
```git push origin [ForkName]```<br/>
#### Still need help?
[Git guide](http://rogerdudler.github.io/git-guide/)
[String Args don't make sense](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args/command-line-arguments)

## License
This project is licensed under the Mozilla Public License 2.0 - see the [LICENSE](https://github.com/JamilAbdelfattah/LearnCsharp-TempMan/blob/master/LICENSE) file for details


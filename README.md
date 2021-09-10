# pepegaDownloader
### This stupid little piece of software basically fills up your desktop with pepe images,

~~*Small warning though, may contain nsfw btw.*~~
~~*+ it may be categorised as malware so i dunno, watch out for that.*~~

Written over the course of 3,5 days in C# and .net 3.1, whilst having some kind of flu idk.

All pepe images are taken from [The Eye](https://the-eye.eu/), So big thanks to them!

### Features

 - Makes your desktop more interesting.
 - As one satisfied customer said, `"Where's my fucking disk space?"`
 - Blue screens your computer on any try of terminating.
 - Doesn't require any elevation. (:megathonk:)
 - Downloads them straight from ***tEH iNTeRweBZ!1***.

### Compiling instructions.
#### If you wish to compile this for some reason, then this is how you do it.

 1. Grab the source code [here](https://github.com/PokusPollo/pepegaDownloader/archive/refs/heads/main.zip) or click the green **Code** button and click **Download ZIP**
 2. Fire up Visual Studio and open the **.sln** file.
 3. In VS on the top bar do the following:
	   1. **Build** > Publish pepegaDownloader > Add a publish profile > Local Folder > Local Folder *again* > Choose your target location (For this example i used `(C:\a)` > **Finish**
 4. Once on the screen with the **Publish** button, press **Show all settings**
 5. Set Configuration to **Release | Any CPU**
 6. Set Deployment mode to **Self-contained**
 7. Set Target runtime to **win-86**
 8. Now expand **File publish options**
 9. Tick everything in that menu you just expanded.
 10. Press **Save**
 11. Press **Publish** on the top right.
 12. Wait until it compiles.
 13. Once it compiles, go to your **Target location** and you should see a single executable.

Wow. you done it. you could've just got the [release](https://github.com/japannt/pepegaDownloader/releases/latest/download/pepegaDownloader.exe). 

PS. I dont know how to compile .net shit to Linux, just use wine or something lol.

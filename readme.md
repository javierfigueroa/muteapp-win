# MuteApp for Windows

Basic console app that toggles the microphone mute state in Windows.

## _Why?_

I wanted a quick and simple way to mute my microphone system wide.  I put this tiny app together and now I can trigger it from my Logitech Master MX 2 mouse middle button.

## _Requirements_

* .NET Core 6 framework installed.
* Visual Studio 2022 installed.

## _Building_

1. Open solution in VS2022.
2. Click on Build / Build Solution.  Verify the build was successful.
3. Right click on MuteAppConsole project.
4. Click Publish
5. Under "More actions" click edit and ensure the following settings are set in the profile.

* Configuration: Release | x64
* Target framework: net6.0
* Deployment mode: Framework-dependent
* Target runtime: win-x64
* Under File publish options, check Produce single file
 
 6. Click on the Publish button. This will build and generate your executable in the target location directory.
 7. Check the Target location directory for the generated .exe
 8. Run the executable to toggle the microphone state.
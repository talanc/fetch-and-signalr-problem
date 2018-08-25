# fetch-and-signalr-problem
testing problems with signalr using a computer name instead of localhost

# Steps to reproduce
- Open in Visual Studio 2017
- Start program, expect results from fetch and signalR
- Go to launchSettings.json and change applicationUrl from `localhost` to your computer name (find via `echo %COMPUTERNAME%`)
- Start program, expect results from fetch but not signalR

# Notes
Kestrel works, HTTP.sys doesn't.

### Tests
Windows 7 Workstation:
Doesn't work

Windows 7 Server VM:
Doesn't work

Windows 10 Home Computer:
Works

Windows 10 Home Computer, Windows 7 VM:
Works

Windows 10 Workstation:
???

Windows 7 Workstation, 2.2 Preview:
???

Windows 7 Workstation, not on corporate network:
???

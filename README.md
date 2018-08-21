# fetch-and-signalr-problem
testing problems with signalr using a computer name instead of localhost

# Steps to reproduce
- Open in Visual Studio 2017
- Start program, expect results from fetch and signalR
- Go to launchSettings.json and change applicationUrl from `localhost` to your computer name (find via `echo %COMPUTERNAME`)
- Start program, expect results from fetch but not signalR

# Notes
I think I've narrowed the problem down to using HTTP.sys

Kestrel + localhost: Works
Kestrel + compname: Works
Http.Sys + localhost: Works
Http.Sys + compname: Doesn't work...

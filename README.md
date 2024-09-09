# csharp-tutorjgz
Materi Tutorial Pelatihan C# untuk JavaGenzLabs

# install plugin yang diperlukan, lalu buat
# launch,json
{
    "version": "0.2.0",
    "configurations": [
        
      {
        "name": ".NET Core Launch (BasicBagianSatu)",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "build",
        "program": "${workspaceFolder}/bin/Debug/net8.0/Tutorpartone.dll",
        "args": [],
        "cwd": "${workspaceFolder}",
        "stopAtEntry": false,
        "serverReadyAction": {
          "action": "openExternally",
          "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
        },
        "env": {
          "ASPNETCORE_ENVIRONMENT": "Development"
        },
        "envFile": "${workspaceFolder}/.env",
        "console": "internalConsole",
        "launchBrowser": {
          "enabled": false,
          "args": "${auto-detect-url}",
          "windows": {
            "command": "cmd.exe",
            "args": ["/c", "start", "${auto-detect-url}"]
          },
          "osx": {
            "command": "open",
            "args": ["-a", "Safari", "${auto-detect-url}"]
          },
          "linux": {
            "command": "xdg-open",
            "args": ["${auto-detect-url}"]
          }
        },
        "internalConsoleOptions": "openOnSessionStart",
        "remoteMachineName": ""
      },
      {
        "name": ".NET Core Launch (BasicBagianDua)",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "build",
        "program": "${workspaceFolder}/bin/Debug/net8.0/Tutorpartone.dll",
        "args": [],
        "cwd": "${workspaceFolder}",
        "stopAtEntry": false,
        "serverReadyAction": {
          "action": "openExternally",
          "pattern": "\\bNow listening on:\\s+(https?://\\S+)"
        },
        "env": {
          "ASPNETCORE_ENVIRONMENT": "Development"
        },
        "envFile": "${workspaceFolder}/.env",
        "console": "internalConsole",
        "launchBrowser": {
          "enabled": false,
          "args": "${auto-detect-url}",
          "windows": {
            "command": "cmd.exe",
            "args": ["/c", "start", "${auto-detect-url}"]
          },
          "osx": {
            "command": "open",
            "args": ["-a", "Safari", "${auto-detect-url}"]
          },
          "linux": {
            "command": "xdg-open",
            "args": ["${auto-detect-url}"]
          }
        },
        "internalConsoleOptions": "openOnSessionStart",
        "remoteMachineName": ""
      }
    ]
  }
  # lalu buat  tasks.json
  {
    "version": "2.0.0",
    "tasks": [
      {
        "label": "build",
        "command": "dotnet",
        "args": [
          "build",
          "/Users/bonie/Documents/Net/Materi Tutorial Jgz/csharp-tutorjgz/Tutorpartone/Tutorpartone.csproj"
        ],
        "problemMatcher": "$msCompile"
      }
    ]
  }
  # note di bagian build, di set sesuai path url .csproj
  # lalu buat .env di root project  touch .env
  # ctrl+shift+d pilih project yang akan di debug
  # jalankan script berikut untuk memastikan bisa di debug per masing2 file 
  dotnet run --project /Users/bonie/Documents/Net/Materi\ Tutorial\ Jgz/csharp-tutorjgz/Tutorpartone/Tutorpartone.csproj
  # perhatikan jika nama folder ada spacy makan tambahkan \ 
  
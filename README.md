# fint-felles-model-csharp

[![Build status](https://ci.appveyor.com/api/projects/status/43s38b09uxq929g6/branch/master?svg=true)](https://ci.appveyor.com/project/eidjord/fint-felles-model-csharp/branch/master)
[ ![Download](https://api.bintray.com/packages/fint/nuget/fint-felles-model-csharp/images/download.svg) ](https://bintray.com/fint/nuget/fint-felles-model-csharp/_latestVersion)


## Pack and deploy to Bintray
```
msbuild /t:pack /p:Configuration=Release
nuget push FINT.Model.Felles\bin\Release\FINT.Model.Felles.0.0.1.nupkg -Source https://api.bintray.com/nuget/fint/nuget
```

For å sette nuget api-key: 
```
nuget setApiKey <Your-API-Key>
```
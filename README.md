# CSharp (C#)

## Create New Solution & Add New Project, Library

```bash

    # Create new Solution
    dotnet new sln --output Solution.Demos
    
    # Create new Project : 
    # with main -> $ dotnet new console --use-program-main
    dotnet new console --name Demo-Console --output Demo-Console
    
    # Add Project 
    dotnet sln add VivConsole 
    
    # Remove Project
    dotnet sln remove VivConsole
    
    # Get Solution Project list
    dotnet sln list
    
    # Solution build
    dotnet build
    
    # Solution restor
    dotnet restore

    # Add Reference
    dotnet add Demo-JiSikin.csproj reference ../Libs/Libs.csproj

    # Add Package examples 
    dotnet add Solution.Demos/BootCamp/BootCamp.csproj package Microsoft.Extensions.Hosting
    dotnet add Solution.Demos/BootCamp/BootCamp.csproj package Microsoft.Extensions.Configuration.Binder
    dotnet add Solution.Demos/BootCamp/BootCamp.csproj package Microsoft.Extensions.Configuration.Json
    dotnet add Solution.Demos/BootCamp/BootCamp.csproj package Microsoft.Extensions.Configuration.EnvironmentVariables

    dotnet new classlib -o StringLibrary
    dotnet sln add StringLibrary

    # editing StringLibrary class...
    dotnet build

    # create new console app project to the solution
    $ dotnet new console -o ShowCase 
    dotnet add ShowCase reference StringLibrary
```

## Include Resource : `.csproj`

```xml
    <ItemGroup>
        <Content Include="test.txt">
            <CopyToOutputDirectory>Always</CopyToOutputDirectory>
        </Content>
    </ItemGroup>
```

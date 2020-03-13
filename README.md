#create new sln

dotnet new sln codeCoverageSample.sln

#create new classlib

dotnet new classlib calculatorLibrary

#create new xunit tests

dotnet new xunit calculatorLibrary.Tests

#add projects to sln

dotnet sln codeCoverageSample.sln add ./**/*.csproj

# add project reference

dotnet add ./calculatorLibrary.Tests/calculatorLibrary.Tests.csproj reference ./calculatorLibrary/calculatorLibrary.csproj

# install nuget packages

#add nuget packages for :  
<PackageReference Include="coverlet.msbuild" Version="2.8.0"/>
                            <PackageReference Include="XunitXml.TestLogger" Version="2.1.26"/>
                            <PackageReference Include="Microsoft.CodeCoverage" Version="16.5.0"/>


#install reportgenerator as a global tool - but local to the project

dotnet tool install dotnet-reportgenerator-globaltool --tool-path tools


# uses coverlet to provide coverage data and convert it into a format that can be used by cobertura.
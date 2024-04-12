# SharpNslookup

CSharp implementation of nslookup functionality. Mainly useful in scenarios where you need .NET instead of a BOF (beacon).

Code originally from Doug Bell over at C# Corner. Modified to use non-deprecated DNS GetEntryHost.

Either build with VS or dotnet CLI : 

```dotnet publish /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true /p:IncludeAllContentForSelfExtract=true --self-contained true```
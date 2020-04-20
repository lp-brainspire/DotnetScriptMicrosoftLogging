//#r "nuget: Microsoft.Extensions.Logging, 3.1.2"
//#r "nuget: Microsoft.Extensions.Logging.Console, 3.1.2"
//#r "nuget: Microsoft.Extensions.Logging.Abstractions, 3.1.2"

#r "..\Company.Logging\bin\Debug\netcoreapp3.1\Company.Logging.dll"

//using Microsoft.Extensions.Logging;
using Company.Logging;
Company.Logging.Logger.LogInformation("Test Begin");

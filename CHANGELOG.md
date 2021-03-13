-------------------------------------------------------------------------------------------------------------
## OPC DA/AE/HDA Client Solution .NET - 1.2.0

###	Changes
- NuGet packages are now available under a commercial license

### Fixed Issues
- Fix Connect method(). It ended correctly even if connection is not established
- Disconnect() method is not executed correctly because of wrong implemented Dispose() methods.


-------------------------------------------------------------------------------------------------------------
## OPC DA/AE/HDA Client Solution .NET - 1.1.1

###	Changes
- Changed copyright year
- Examples are now using the NuGet packages

-------------------------------------------------------------------------------------------------------------
## OPC DA/AE/HDA Client Solution .NET - 1.1.0

###	Enhancements
- Support of .NET 5.0
- Added nuget packages

-------------------------------------------------------------------------------------------------------------
## OPC DA/AE/HDA Client Solution .NET - 1.0.0902

###	Enhancements
- Support of .NET Standard 2.1
- Also supported: .NET 4.8, .NET 4.7.2, .NET 4.6.2
- Support of OPC Classic Core Components 108.41
- Enhanced COM call tracing for OPC DA 
- For missing required OPC Interfaces a NotSupportedException is thrown and for optional ones just an entry in the log created.

###	Redistributables
- Redistributables are available via https://opcfoundation.org/developer-tools/samples-and-tools-classic/core-components/



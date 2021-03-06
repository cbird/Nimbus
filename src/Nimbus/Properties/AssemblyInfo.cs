﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("Nimbus")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Nimbus")]
[assembly: AssemblyCopyright("Copyright ©  2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("6c753fa6-3cf7-448b-898c-ea0cbcd8f638")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: InternalsVisibleTo("Nimbus.Tests.Common", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("Nimbus.UnitTests", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("Nimbus.IntegrationTests", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("Nimbus.StressTests", AllInternalsVisible = true)]
[assembly: InternalsVisibleTo("Nimbus.Autofac")]
[assembly: InternalsVisibleTo("Nimbus.Windsor")]
[assembly: InternalsVisibleTo("Nimbus.LargeMessages.Azure")]
[assembly: InternalsVisibleTo("Nimbus.LargeMessages.FileSystem")]
[assembly: InternalsVisibleTo("Nimbus.Logger.Serilog")]
[assembly: InternalsVisibleTo("Nimbus.Transports.InProcess")]
[assembly: InternalsVisibleTo("Nimbus.Transports.Redis")]
[assembly: InternalsVisibleTo("Nimbus.Transports.WindowsServiceBus")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2", AllInternalsVisible = true)]

#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Shirish Goyal")]
[assembly: AssemblyProduct(@"Visual Design Patterns")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"VisualDesignPatterns.DslPackage, PublicKey=0024000004800000940000000602000000240000525341310004000001000100FB0D3F2C4B300A4F8822A7245E21112225A7CB1E409AD56E38691B03EB9C88F2D3AF641FD34710045B1D53837C01597852BB88A9CF29FEEA83368F5FDE3E2A8BAC75856A57151860C1CFAFE9C1E729D55A89C696332BE26247C689B2E5141DA77AF781A91B1BCD110EF1139B97331E6FB70D7FE1FD5F21C1E4054599EE0469CF")]
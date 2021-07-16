using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(JetpackJoyride.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(JetpackJoyride.BuildInfo.Company)]
[assembly: AssemblyProduct(JetpackJoyride.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + JetpackJoyride.BuildInfo.Author)]
[assembly: AssemblyTrademark(JetpackJoyride.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(JetpackJoyride.BuildInfo.Version)]
[assembly: AssemblyFileVersion(JetpackJoyride.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(JetpackJoyride.JetpackJoyride), JetpackJoyride.BuildInfo.Name, JetpackJoyride.BuildInfo.Version, JetpackJoyride.BuildInfo.Author, JetpackJoyride.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]
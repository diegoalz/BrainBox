using System.Reflection;

namespace BrainBox.Web.API;

public class PresentationAssemblyReference
{
    internal static readonly Assembly Assembly = typeof(PresentationAssemblyReference).Assembly;
}
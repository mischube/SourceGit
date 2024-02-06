using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace SourceGit;

/// <summary>
/// A sample source generator that creates C# classes based on the text file (in this case, Domain Driven Design ubiquitous language registry).
/// When using a simple text file as a baseline, we can create a non-incremental source generator.
/// </summary>
[Generator]
public class GitRepositoryCloner : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        // No initialization required for this generator.
    }

    public void Execute(GeneratorExecutionContext context)
    {
        foreach (var file in context.AdditionalFiles)
        {
            if (Path.GetFileName(file.Path) == "GitExternal.json")
            {
                var text = file.GetText();
                
                // var gitExternal = JsonConvert.DeserializeObject<GitExternal>(text.ToString());
                // Console.WriteLine(gitExternal.Repository);
                // Console.WriteLine(gitExternal.OutputFolder);
            }
        }
    }
}
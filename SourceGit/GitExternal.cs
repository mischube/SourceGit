using System;
using JetBrains.Annotations;

namespace SourceGit;

[PublicAPI]
public class GitExternal(string repository, string outputFolder) : Attribute
{
    public string Repository { get; set; } = repository;

    public string OutputFolder { get; set; } = outputFolder;
}
using System;

using R5T.T0132;


namespace R5T.S0081
{
    [FunctionalityMarker]
    public partial interface IProjectFilePathScripts : IFunctionalityMarker
    {
        public void Get_PublishDirectoryDocumentationFilePath()
        {
            /// Inputs.
            // Needs to be a real project file path, since creating a tuple looks at the project file contents.
            var projectFilePath = Instances.FilePaths.Example_RealProjectFilePath;


            // Run.
            var textOutput = Instances.TextOutputOperator.Get_Console();

            var documentationXmlFilePath = Instances.Operations_F0115.CreateProjectFilesTuple(
                projectFilePath,
                textOutput)
                .DocumentationFilePath;

            Console.WriteLine($"Documentation XML file path:\n\t{documentationXmlFilePath}\n\nFor project file path:\n\t{projectFilePath}");
        }

        public void Get_BackupProjectFilePath()
        {
            /// Inputs.
            var projectFilePath = Instances.FilePaths.Example_ProjectFilePath;


            // Run.
            var backupProjectFilePath = Instances.ProjectFilePathOperations.Get_VisualStudioGeneratedBackupProjectFilePath(projectFilePath);

            Console.WriteLine($"Backup project file path:\n\t{backupProjectFilePath}\n\nFor project file path:\n\t{projectFilePath}");
        }
    }
}

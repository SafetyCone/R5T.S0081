using System;

using R5T.T0132;


namespace R5T.S0081
{
    [FunctionalityMarker]
    public partial interface IProjectFilePathScripts : IFunctionalityMarker
    {
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

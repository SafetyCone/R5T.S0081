using System;


namespace R5T.S0081
{
    public class ProjectFilePathScripts : IProjectFilePathScripts
    {
        #region Infrastructure

        public static IProjectFilePathScripts Instance { get; } = new ProjectFilePathScripts();


        private ProjectFilePathScripts()
        {
        }

        #endregion
    }
}

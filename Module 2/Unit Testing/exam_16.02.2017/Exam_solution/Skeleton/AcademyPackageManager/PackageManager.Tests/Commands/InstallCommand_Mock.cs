namespace PackageManager.Tests.Commands
{    
    using PackageManager.Commands;
    using PackageManager.Core.Contracts;
    using PackageManager.Models.Contracts;

    internal class InstallCommandMock : InstallCommand
    {
        public InstallCommandMock(Installer<IPackage> installer, IPackage package) 
            : base(installer, package)
        {                
        }

        public Installer<IPackage> Installer
        {
            get
            {
                return this.installer;
            }
        }

        public IPackage Package
        {
            get
            {
                return this.package;
            }
        }
    }
}

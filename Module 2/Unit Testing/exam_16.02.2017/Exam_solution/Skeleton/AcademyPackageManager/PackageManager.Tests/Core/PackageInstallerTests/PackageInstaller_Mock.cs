using PackageManager.Core;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Core.PackageInstallerTests
{
    internal class PackageInstaller_Mock : PackageInstaller
    {
        public PackageInstaller_Mock(IDownloader downloader, IProject project)
            : base(downloader, project)
        {
        }

        public IDownloader Downloader
        {
            get
            {
                return this.downloader;
            }
        }

        public IProject Project
        {
            get
            {
                return this.project;
            }
        }
    }
}

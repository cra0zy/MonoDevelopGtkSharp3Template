using System.Diagnostics;
using MonoDevelop.Core;
using MonoDevelop.Ide.Desktop;
using MonoDevelop.Ide.Gui;
using MonoDevelop.Projects;

namespace MonoDevelop
{
    public class GladeDisplayBinding : IExternalDisplayBinding
    {
        public DesktopApplication GetApplication(MonoDevelop.Core.FilePath fileName, string mimeType, Project ownerProject)
        {
            return new GladeDesktopApplication(fileName.FullPath, ownerProject);
        }

        public bool CanHandle(FilePath fileName, string mimeType, Project ownerProject)
        {
            return mimeType == "text/x-glade";
        }
        public bool CanUseAsDefault
        {
            get
            {
                return true;
            }
        }
    }

    class GladeDesktopApplication : DesktopApplication
    {
        private string _filename;

        public GladeDesktopApplication(string filename, Project ownerProject)
            : base("GladeApplication", "Glade GUI Designer", true)
        {
            this._filename = filename;
        }

        public override void Launch(params string[] files)
        {
            var process = new Process();
            process.StartInfo.FileName = "glade";
            process.StartInfo.Arguments = _filename;
            process.Start();
        }
    }
}

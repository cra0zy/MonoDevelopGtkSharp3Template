using System;
using System.Collections.Generic;
using MonoDevelop.Ide.Templates;
using MonoDevelop.Projects;

namespace MonoDevelop
{
    public class GtkSharp3ProjectWizard : TemplateWizard
    {
        public override string Id
        {
            get
            {
                return "MonoDevelop.GtkSharp3ProjectWizard";
            }
        }

        public override int TotalPages
        {
            get
            {
                return 0;
            }
        }

        public override WizardPage GetPage(int pageNumber)
        {
            return new GPage();
        }

        public override void ItemsCreated(IEnumerable<IWorkspaceFileObject> items)
        {
            foreach (var item in items)
            {
                var solution = item as Solution;

                if (solution == null)
                    continue;

                foreach (var project in solution.GetAllProjects())
                {
                    var file = new ProjectFile("", "EmbeddedResource");
                    file.ResourceId
                }
            }

            base.ItemsCreated(items);
        }
    }

    class GPage : WizardPage
    {
        public override string Title
        {
            get
            {
                return "";
            }
        }
    }
}


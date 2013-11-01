using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Redmine.Net.Api.Types;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RedmineClient.Model
{
    class ProjectsMapper
    {
        protected DatasService _DatasService;
        private ObservableCollection<ProjectObject> _ListProject = null;

        public ProjectsMapper()
        {
            _DatasService = DatasService.getInstance();
        }

        public ObservableCollection<ProjectObject> getAll()
        {
            IEnumerable<Project> ProjectList = _DatasService.getProjects();
            ProjectList = from Project project in ProjectList
                          where String.IsNullOrWhiteSpace(Convert.ToString(project.Parent))
                           select project;
            _ListProject = Tools<ProjectObject, Project>.Transform(ProjectList);
            return _ListProject;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using Redmine.Net.Api.Types;

namespace RedmineClient.Model
{
    public class ProjectObject  : ObservableObject
    {
        public ProjectObject()
        { }
        public ProjectObject(Project project)
        {
            Id = project.Id;
            Name = project.Name;
            Identifier = project.Identifier;
            Description = project.Description;
            Created_on = project.CreatedOn;
            Updated_on = project.UpdatedOn;
        }

        private int _Id;

        public int Id
        {
            get { return _Id; }
            set {
                RaisePropertyChanging("Id");
                _Id = value;
                RaisePropertyChanged("Id");
            }
        }
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set {
                RaisePropertyChanging("Name");
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }
        private string _Identifier;

        public string Identifier
        {
            get { return _Identifier; }
            set {
                RaisePropertyChanging("Identifier");
                _Identifier = value;
                RaisePropertyChanged("Identifier");
            }
        }
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set {
                RaisePropertyChanging("Description");
                _Description = value;
                RaisePropertyChanged("Description");
            }
        }
        private DateTime? _Created_on;

        public DateTime? Created_on
        {
            get { return _Created_on; }
            set {
                RaisePropertyChanging("Created_on");
                _Created_on = value;
                RaisePropertyChanged("Created_on");
            }
        }
        private DateTime? _Updated_on;

        public DateTime? Updated_on
        {
            get { return _Updated_on; }
            set {
                RaisePropertyChanging("Updated_on");
                _Updated_on = value;
                RaisePropertyChanged("Updated_on");
            }
        }


    }
}

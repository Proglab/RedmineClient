using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System.Collections.Specialized;


namespace RedmineClient.Model
{
    public class DatasService
    {
        static private DatasService _instance = null;
        private RedmineManager _manager;

        private DatasService()
        {
            string host = "http://95.142.170.190/";
            string apiKey = "b883e3ca808b4c58499f69b491d00f6c4ec5e4b7";
            _manager = new RedmineManager(host, apiKey);
        }

        public static DatasService getInstance()
        {
            if (_instance == null)
            {
                _instance = new DatasService();

            }
            return _instance;
        }

        public User getCurrentUser()
        {
            return _manager.GetCurrentUser();
        }

        public IList<Project> getProjects(NameValueCollection parameters)
        {
            return _manager.GetObjectList<Project>(parameters);
        }

        public IList<Project> getProjects()
        {
            return _manager.GetObjectList<Project>(null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;

namespace RedmineClient.Model
{
    static class Tools<T, Y>
        where T : new()
    {
        static public ObservableCollection<T> Transform(IList<Y> collection)
        {
            ObservableCollection<T>  _ListProject = new ObservableCollection<T>();
            foreach (Y item in collection)
            {
                _ListProject.Add((T)Activator.CreateInstance(typeof(T), item));
            }
            return _ListProject;
        }
    }
}

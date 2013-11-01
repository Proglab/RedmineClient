using GalaSoft.MvvmLight;
using RedmineClient.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RedmineClient.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        private ProjectsMapper projectMapper =  new ProjectsMapper();
         
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            
            ProjectsCol = projectMapper.getAll();
            
        }

        private ObservableCollection<ProjectObject> _ProjectsCol;

        public ObservableCollection<ProjectObject> ProjectsCol
        {
            get {
                return _ProjectsCol;
            }
            set { _ProjectsCol = value; }
        }
        
    }
}
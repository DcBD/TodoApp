using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopWPFUI.State.Navigators;
using TodoApp.Domain.Models;
using TodoApp.EntityFramework;
using TodoApp.EntityFramework.Services;

namespace DesktopWPFUI.ViewModels
{
    public class TagsViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();

        private List<Tag> _tags = new List<Tag>();
        /// <summary>
        /// Tags list
        /// </summary>
        public List<Tag> Tags {
            get { return _tags; }
            set { _tags = value; this.OnPropertyChanged("Tags"); }
        }

        public TagsViewModel()
        {
            UpdateTagsList();
        }

        public void UpdateTagsList()
        {
            GenericDataService<Tag> tagService = new GenericDataService<Tag>(new TodoAppDbContextFactory());

            Tags = tagService.GetAllItems();


            Console.WriteLine(Tags.Count);
        }

    }
}

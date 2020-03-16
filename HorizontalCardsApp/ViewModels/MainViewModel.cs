using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HorizontalCardsApp.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        public MainViewModel()
        {
            var list = new List<string>();
            list.Add("Action");
            list.Add("Adventure");
            list.Add("Sci-fi");
            list.Add("Romance");
            list.Add("Comedy");
            list.Add("Thriller");
            list.Add("Horror");
            list.Add("Fantasy");
            list.Add("Anime");
            Tags = new ObservableCollection<string>(list);
        }

        private ObservableCollection<string> tags;
        public ObservableCollection<string> Tags
        {
            get { return tags; }
            set
            {
                tags = value;
                OnPropertyChanged();
            }
        }
    }
}

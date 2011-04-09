using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using TwitterTiles.Model;

namespace TwitterTiles.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                Tweets.Add(new Tweet() { Avatar = "/Images/avatar.jpg", Handle = "Handle1", Location = "Frisco, TX", TweetText = "This is my latest tweet. There are many like them but this one is mine." });
                Tweets.Add(new Tweet() { Avatar = "/Images/avatar.jpg", Handle = "Handle2", Location = "Frisco, TX", TweetText = "This is my latest tweet. There are many like them but this one is mine." });
                Tweets.Add(new Tweet() { Avatar = "/Images/avatar.jpg", Handle = "Handle3", Location = "Frisco, TX", TweetText = "This is my latest tweet. There are many like them but this one is mine." });
                Tweets.Add(new Tweet() { Avatar = "/Images/avatar.jpg", Handle = "Handle4", Location = "Frisco, TX", TweetText = "This is my latest tweet. There are many like them but this one is mine." });
                Tweets.Add(new Tweet() { Avatar = "/Images/avatar.jpg", Handle = "Handle5", Location = "Frisco, TX", TweetText = "This is my latest tweet. There are many like them but this one is mine." });
                Tweets.Add(new Tweet() { Avatar = "/Images/avatar.jpg", Handle = "Handle6", Location = "Frisco, TX", TweetText = "This is my latest tweet. There are many like them but this one is mine." });
            }
            else
            {
                // Code runs "for real"
            }
        }

        #region Tweets property

        private ObservableCollection<Tweet> _tweets = new ObservableCollection<Tweet>();

        public ObservableCollection<Tweet> Tweets
        {
            get
            {
                return _tweets;
            }

            set
            {
                if (_tweets == value)
                {
                    return;
                }

                var oldValue = _tweets;
                _tweets = value;
                RaisePropertyChanged(() => this.Tweets);
            }
        }

        #endregion Tweets property

        #region SelectedTweet property

        private Tweet _selectedTweet = null;

        public Tweet SelectedTweet
        {
            get
            {
                return _selectedTweet;
            }

            set
            {
                if (_selectedTweet == value)
                {
                    return;
                }

                var oldValue = _selectedTweet;
                _selectedTweet = value;
                RaisePropertyChanged(() => this.SelectedTweet);
            }
        }

        #endregion SelectedTweet property
    }
}
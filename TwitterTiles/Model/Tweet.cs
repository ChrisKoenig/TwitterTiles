using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TwitterTiles.Model
{
    public class Tweet
    {
        public string Avatar { get; set; }

        public string Handle { get; set; }

        public string Location { get; set; }

        public string TweetText { get; set; }
    }
}
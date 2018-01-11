//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CleanTweets
//{
//    class Program
//    {
//        static void Main(string[] args) // Main is our entry point
//        {
//            // Object Initialization
//            var tweet = new Tweet
//            {
//                CleanTweetBody = "Martin is the best!"
//            };


//            tweet.PostTweet(":poop:", true); // I'm using the "overloaded" version here.
//        }
//    }

//    class Tweet
//    {
//        protected string _tweetBody; //<-- Field

//        public string CleanTweetBody //<-- Property
//        {
//            get // getter
//            {
//                return $"Your tweet is {_tweetBody}";
//            }
//            set // setter
//            {
//                // check for curse words
//                if (value == ":poop:")
//                {
//                    throw new Exception("that's gross");
//                }
//                _tweetBody = value;
//            }
//        }

//        public bool PostTweet(string tweetBody) // Method
//        {
//            _tweetBody = tweetBody;
//            return true;
//        }

//        public bool PostTweet(string dirtyTweet, bool cleanUpLanguage) // Method Overload
//        {
//            if (cleanUpLanguage == true)
//                CleanTweetBody = dirtyTweet; // An Exception is thrown here on this line.
//            return true;
//        }
//    }
//}
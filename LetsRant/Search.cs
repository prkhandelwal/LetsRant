using LetsRant.Models;
using LinqToTwitter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi;

namespace LetsRant
{
    public class Search
    {
        public static IEnumerable<Tweetinvi.Models.ITweet> Tweets;
        

        public async static Task<string> GetTweets(string query)
        {
            List<TweetSendData> tweetsendData = new List<TweetSendData>();
            Auth.SetUserCredentials(creds.ConsumerKey, creds.ConsumerSecret, creds.AccessToken, creds.AccessSecret);
            //var tweets = await SearchAsync.SearchTweets(query);
            Tweets = await SearchAsync.SearchTweets(query);
            List<Tweetinvi.Models.ITweet> tweetList = Tweets.ToList();
            foreach (Tweetinvi.Models.ITweet item in tweetList)
            {
                var k = new TweetSendData()
                {
                    TweetID = item.Id,
                    Tweet = item.FullText,
                    HashTags = item.Hashtags,
                    coordinates = item.Coordinates
                };
                if(item.Place != null)
                {
                    k.PlaceName = item.Place.Name;
                    k.Country = item.Place.Country;
                }

                tweetsendData.Add(k);
            }
            string tweetJson = JsonConvert.SerializeObject(tweetsendData);

            return tweetJson;

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetinvi.Models;
using Tweetinvi.Models.Entities;

namespace LetsRant.Models
{
    public class TweetSendData
    {
        public long TweetID { get; set; }
        public string Tweet { get; set; }
        public List<IHashtagEntity> HashTags { get; set;}
        public ICoordinates coordinates { get; set; }
        public string PlaceName { get; set; }
        public string Country { get; set; }
    }
}

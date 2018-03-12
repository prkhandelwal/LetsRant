using System;
using System.Collections.Generic;
using System.Text;

namespace RantServices.Models
{
    public class Datum
    {
        public Coordinates coordinates { get; set; }
        public string issue { get; set; }
        public string place { get; set; }
        public string sentneg { get; set; }
        public string sentpos { get; set; }
        public object tweetid { get; set; }
    }
}

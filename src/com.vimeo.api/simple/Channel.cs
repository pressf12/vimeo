using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace com.vimeo.api.simple
{
    public sealed class Channel
    {

        #region // Properties //

        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty("id")]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// Channel name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Channel description
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Channel logo (header)
        /// </summary>
        [JsonProperty("logo")]
        public string Logo
        {
            get;
            set;
        }

        /// <summary>
        /// URL for the channel page
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// RSS feed for the channel's videos
        /// </summary>
        [JsonProperty("rss")]
        public string Rss
        {
            get;
            set;
        }

        /// <summary>
        /// Date the channel was created
        /// </summary>
        [JsonProperty("created_on")]
        public DateTime CreatedOn
        {
            get;
            set;
        }

        /// <summary>
        /// User ID of the channel creator
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorID
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the User who created the channel
        /// </summary>
        [JsonProperty("creator_display_name")]
        public string CreatorDisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// The URL to the channel creator's profile
        /// </summary>
        [JsonProperty("creator_url")]
        public string CreatorUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of videos posted in the channel
        /// </summary>
        [JsonProperty("total_videos")]
        public int TotalVideos
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of users subscribed
        /// </summary>
        [JsonProperty("total_subscribers")]
        public int TotalSubscribers
        {
            get;
            set;
        }

        #endregion

        #region // Data Access //


        public static Channel Get(string name)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/channel/" + name + "/info.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<Channel>(json);
        }

        public static List<Video> Videos(string name)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/channel/" + name + "/videos.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<List<Video>>(json);
        }

        #endregion 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace com.vimeo.api.simple
{
    public sealed class Video
    {

        #region // Properties //

        /// <summary>
        /// Video title 
        /// </summary>
        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// URL to the Video Page
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Video ID
        /// </summary>
        [JsonProperty("id")]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// The description of the video
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// URL to a small version of the thumbnail
        /// </summary>
        [JsonProperty("thumbnail_small")]
        public string ThumbnailSmall
        {
            get;
            set;
        }

        /// <summary>
        /// URL to a medium version of the thumbnail
        /// </summary>
        [JsonProperty("thumbnail_medium")]
        public string ThumbnailMedium
        {
            get;
            set;
        }

        /// <summary>
        /// URL to a large version of the thumbnail
        /// </summary>
        [JsonProperty("thumbnail_large")]
        public string ThumbnailLarge
        {
            get;
            set;
        }

        /// <summary>
        /// The user name of the video's uploader
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// The URL to the user profile
        /// </summary>
        [JsonProperty("user_url")]
        public string UserUrl
        {
            get;
            set;
        }

        /// <summary>
        /// The date/time the video was uploaded on
        /// </summary>
        [JsonProperty("upload_date")]
        public DateTime UploadDate
        {
            get;
            set;
        }

        /// <summary>
        /// Small user portrait (30px)
        /// </summary>
        [JsonProperty("user_portrait_small")]
        public string UserPortraitSmall
        {
            get;
            set;
        }

        /// <summary>
        /// Medium user portrait (100px)
        /// </summary>
        [JsonProperty("user_portrait_medium")]
        public string UserPortraitMedium
        {
            get;
            set;
        }

        /// <summary>
        /// Large user portrait (300px)
        /// </summary>
        [JsonProperty("user_portrait_large")]
        public string UserPortraitLarge
        {
            get;
            set;
        }

        /// <summary>
        /// # of likes
        /// </summary>
        [JsonProperty("stats_number_of_likes")]
        public int StatsNumberOfLikes
        {
            get;
            set;
        }

        /// <summary>
        /// # of views
        /// </summary>
        [JsonProperty("stats_number_of_views")]
        public int StatsNumberOfViews
        {
            get;
            set;
        }

        /// <summary>
        /// # of comments
        /// </summary>
        [JsonProperty("stats_number_of_comments")]
        public int StatsNumberOfComments
        {
            get;
            set;
        }

        /// <summary>
        /// Duration of the video in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Standard definition width of the video
        /// </summary>
        [JsonProperty("width")]
        public int Width
        {
            get;
            set;
        }

        /// <summary>
        /// Standard definition height of the video
        /// </summary>
        [JsonProperty("height")]
        public int Height
        {
            get;
            set;
        }

        /// <summary>
        /// Comma separated list of tags
        /// </summary>
        [JsonProperty("tags")]
        public string Tags
        {
            get;
            set;
        }
        #endregion 

        #region // Data Access //

        public static Video Get(int id)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/video/" + id + ".json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<Video>(json);
        }

        #endregion 

    }
}

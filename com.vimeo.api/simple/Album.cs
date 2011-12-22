using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace com.vimeo.api.simple
{
    public sealed class Album
    {
        #region // Properties //

        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("id")]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// Date the album was created
        /// </summary>
        [JsonProperty("created_on")]
        public DateTime CreatedOn
        {
            get;
            set;
        }

        /// <summary>
        /// Date the album was last modified
        /// </summary>
        [JsonProperty("last_modified")]
        public DateTime LastModified
        {
            get;
            set;
        }

        /// <summary>
        /// Album title
        /// </summary>
        [JsonProperty("title")]
        public string Title 
        {
            get;
            set;
        }

        /// <summary>
        /// Album description
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// URL for the album page
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of videos added to the album
        /// </summary>
        [JsonProperty("total_videos")]
        public int TotalVideos
        {
            get;
            set;
        }

        /// <summary>
        /// User ID of the user who made the album
        /// </summary>
        [JsonProperty("user_id")]
        public int UserID
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the User who created the album
        /// </summary>
        [JsonProperty("user_display_name")]
        public string UserDisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// The URL to the album creator's profile
        /// </summary>
        [JsonProperty("user_url")]
        public string UserUrl
        {
            get;
            set;
        }

        #endregion 
        
        #region // Data Access //

        public static Album Get(string name)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/album/" + name + "/info.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<Album>(json);
        }

        public static List<Video> Videos(string name)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/album/" + name + "/videos.json",
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

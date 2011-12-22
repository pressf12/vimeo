using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace com.vimeo.api.simple
{
    public sealed class Group
    {

        #region // Properties // 

        /// <summary>
        /// Group ID
        /// </summary>
        [JsonProperty("id")]
        public string ID 
        {
            get;
            set;
        }

        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Group description
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// URL for the group page
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Group logo (header)
        /// </summary>
        [JsonProperty("logo")]
        public string Logo
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
        /// Date the group was created
        /// </summary>
        [JsonProperty("created_on")]
        public DateTime CreatedOn
        {
            get;
            set;
        }

        /// <summary>
        /// User ID of the group creator
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorID
        {
            get;
            set;
        }
        
        /// <summary>
        /// Name of the User who created the group
        /// </summary>
        [JsonProperty("creator_display_name")]
        public string CreatorDisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// The URL to the group creator's profile
        /// </summary>
        [JsonProperty("creator_url")]
        public string CreatorUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of users joined
        /// </summary>
        [JsonProperty("total_members")]
        public int TotalMembers
        {
            get;
            set;
        }
        
        /// <summary>
        /// Total # of videos posted to the group
        /// </summary>
        [JsonProperty("total_videos")]
        public int TotalVideos
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of files uploaded to the group
        /// </summary>
        [JsonProperty("total_files")]
        public int TotalFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of forum topics
        /// </summary>
        [JsonProperty("total_forum_topics")]
        public int TotalForumTopics
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of events
        /// </summary>
        [JsonProperty("total_events")]
        public int TotalEvents
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of upcoming events
        /// </summary>
        [JsonProperty("total_upcoming_events")]
        public int TotalUpcomingEvents
        {
            get;
            set;
        }

        #endregion

        #region // Data Access //

        public static Group Get(string name)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/group/" + name + "/info.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<Group>(json);
        }

        public static List<Video> Videos(string name)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/group/" + name + "/videos.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<List<Video>>(json);
        }

        public static List<User> Users(string name)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/group/" + name + "/users.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<List<User>>(json);
        }
        #endregion 

    }
}

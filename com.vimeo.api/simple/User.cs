using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace com.vimeo.api.simple
{
    public sealed class User
    {

        #region // Properties //

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("id")]
        public int ID 
        {
            get;
            set;
        }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Date the user signed up
        /// </summary>
        [JsonProperty("created_on")]
        public DateTime CreatedOn
        {
            get;
            set;
        }

        /// <summary>
        /// Is this user a staff member?
        /// </summary>
        [JsonProperty("is_staff")]
        public bool IsStaff
        {
            get;
            set;
        }

        /// <summary>
        /// Is this user a Vimeo Plus member?
        /// </summary>
        [JsonProperty("is_plus")]
        public bool IsPlus
        {
            get;
            set;
        }
            
        /// <summary>
        /// The location of the user
        /// </summary>
        [JsonProperty("location")]
        public string Location 
        {
            get;
            set;
        }

        /// <summary>
        /// User supplied url
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        {
            get;
            set;
        }

        /// <summary>
        /// The bio information from the user profile
        /// </summary>
        [JsonProperty("bio")]
        public string Bio
        {
            get;
            set;
        }

        /// <summary>
        /// URL to the user profile
        /// </summary>
        [JsonProperty("profile_url")]
        public string ProfileUrl
        {
            get;
            set;
        }

        /// <summary>
        /// URL to the video list for this user
        /// </summary>
        [JsonProperty("videos_url")]
        public string VideosUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of videos uploaded
        /// </summary>
        [JsonProperty("total_videos_uploaded")]
        public int TotalVideosUploaded
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of videos user appears in
        /// </summary>
        [JsonProperty("total_videos_appears_in")]
        public int TotalVideosAppearsIn
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of videos liked by user
        /// </summary>
        [JsonProperty("total_videos_liked")]
        public int TotalVideosLiked
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of contacts
        /// </summary>
        [JsonProperty("total_contacts")]
        public int TotalContacts
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of albums
        /// </summary>
        [JsonProperty("total_albums")]
        public int TotalAlbums
        {
            get;
            set;
        }

        /// <summary>
        /// Total # of channels moderated by user
        /// </summary>
        [JsonProperty("total_channels")]
        public int TotalChannels
        {
            get;
            set;
        }

        /// <summary>
        /// Small user portrait (30px)
        /// </summary>
        [JsonProperty("portrait_small")]
        public string PortraitSmall
        {
            get;
            set;
        }

        /// <summary>
        /// Medium user portrait (100px)
        /// </summary>
        [JsonProperty("portrait_medium")]
        public string PortraitMedium
        {
            get;
            set;
        }

        /// <summary>
        /// Large user portrait (300px)
        /// </summary>
        [JsonProperty("portrait_large")]
        public string PortraitLarge
        {
            get;
            set;
        }

        #endregion 

        #region // Data Access //

        public static User Info(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/info.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<User>(json);
        }

        public static List<Video> Videos(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/videos.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new VimeoException();

            return JsonConvert.DeserializeObject<List<Video>>(json);
        }

        public static List<Video> Likes(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/likes.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new VimeoException();

            return JsonConvert.DeserializeObject<List<Video>>(json);
        }


        public static List<Video> AppearsIn(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/likes.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new VimeoException();

            return JsonConvert.DeserializeObject<List<Video>>(json);
        }


        public static List<Video> Subscriptions(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/subscriptions.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new VimeoException();

            return JsonConvert.DeserializeObject<List<Video>>(json);
        }


        public static List<Album> Albums(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/albums.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new VimeoException();

            return JsonConvert.DeserializeObject<List<Album>>(json);
        }


        public static List<Channel> Channels(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/channels.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
                throw new VimeoException();

            return JsonConvert.DeserializeObject<List<Channel>>(json);
        }


        public static List<Group> Groups(string user)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/" + user + "/groups.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)            
                throw new VimeoException();

            return JsonConvert.DeserializeObject<List<Group>>(json);
        }

        #endregion

    }
}

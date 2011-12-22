using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace com.vimeo.api.simple
{
    public sealed class Activity
    {

        #region // Properties //

        [JsonProperty("type")]
        public string Type 
        {
            get;
            set;
        }

        [JsonProperty("date")]
        public DateTime Date
        {
            get;
            set;
        }

        [JsonProperty("user_id")]
        public int UserID 
        {
            get;
            set;
        }
        
        [JsonProperty("user_name")]
        public string UserName 
        {
            get;
            set;
        }
        
        [JsonProperty("user_url")]
        public string UserUrl
        {
            get;
            set;
        }
        
        [JsonProperty("user_portrait_small")]
        public string UserPortraitSmall
        {
            get;
            set;
        }

        [JsonProperty("user_portrait_medium")]
        public string UserPortraitMedium
        {
            get;
            set;
        }
        
        [JsonProperty("user_portrait_large")]
        public string UserPortraitLarge
        {
            get;
            set;
        }
        
        [JsonProperty("user_portrait_huge")]
        public string UserPortraitHuge
        {
            get;
            set;
        }
        
        [JsonProperty("subject_id")]
        public int SubjectID
        {
            get;
            set;
        }
        
        [JsonProperty("subject_name")]
        public string SubjectName
        {
            get;
            set;
        }
                
        [JsonProperty("subject_url")]
        public string SubjectUrl
        {
            get;
            set;
        }        
        
        [JsonProperty("subject_portrait_small")]
        public string SubjectPortraitSmall
        {
            get;
            set;
        }
        
        [JsonProperty("subject_portrait_medium")]
        public string subject_portrait_medium
        {
            get;
            set;
        }
        
        [JsonProperty("subject_portrait_large")]
        public string SubjectPortraitLarge
        {
            get;
            set;
        }
        
        [JsonProperty("subject_portrait_huge")]
        public string SubjectPortraitHuge
        {
            get;
            set;
        }
        
        [JsonProperty("video_id")]
        public int VideoID
        {
            get;
            set;
        }
        
        [JsonProperty("video_title")]
        public string VideoTitle
        {
            get;
            set;
        }
        
        [JsonProperty("video_description")]
        public string VideoDescription
        {
            get;
            set;
        }
        
        [JsonProperty("video_url")]
        public string VideoUrl
        {
            get;
            set;
        }
        
        [JsonProperty("video_thumbnail_small")]
        public string VideoThumbnailSmall
        {
            get;
            set;
        }

        [JsonProperty("video_thumbnail_medium")]
        public string VideoThumbnailMedium
        {
            get;
            set;
        }

        [JsonProperty("video_thumbnail_large")]
        public string VideoThumbnailLarge
        {
            get;
            set;
        }
        
        [JsonProperty("video_stats_number_of_likes")]
        public int VideoStatsNumberOfLikes
        {
            get;
            set;
        }
        
        [JsonProperty("video_stats_number_of_plays")]
        public int VideoStatsNumberOfPlays
        {
            get;
            set;
        }
        
        [JsonProperty("video_stats_number_of_comments")]
        public int VideoStatsNumbeOfComments
        {
            get;
            set;
        }
        
        [JsonProperty("video_tags")]
        public string VideoTags
        {
            get;
            set;
        }
        
        [JsonProperty("action_tags")]
        public string ActionTags
        {
            get;
            set;
        }

        #endregion

        #region // Data Access //

        public static List<Activity> UserDid(string username)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/activity/" + username + "/user_did.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<List<Activity>>(json);
        }

        public static List<Activity> HappenedToUser(string username)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/activity/" + username + "/happened_to_user.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<List<Activity>>(json);
        }

        public static List<Activity> ContactsDid(string username)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/activity/" + username + "/contacts_did.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<List<Activity>>(json);
        }

        public static List<Activity> EveryoneDid(string username)
        {
            var request = new Request
            {
                Url = "http://vimeo.com/api/v2/activity/" + username + "/everyone_did.json",
                Method = "GET"
            };

            var json = string.Empty;
            if (request.Execute(out json) != System.Net.HttpStatusCode.OK)
            {
                throw new VimeoException();
            }

            return JsonConvert.DeserializeObject<List<Activity>>(json);
        }
        #endregion 
    }
}

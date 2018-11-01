using System;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace Posterbot.Core.Models
{
    public class PosterTheme
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ImageSource Thumbnail { get; set; }

        public static PosterTheme FromJObject(JObject jobject)
        {
            PosterTheme result = new PosterTheme();
            result.Title = (jobject.ContainsKey("title")) ? jobject["title"].Value<string>() : "A Vague Title";
            result.Description = (jobject.ContainsKey("description")) ? jobject["description"].Value<string>() : "A short quippy description to entice the reader";
            if (jobject.ContainsKey("thumbnail"))
            {
                string thumbnail = jobject["thumbnail"].Value<string>();
                Uri thumbnailUri = new Uri(thumbnail);
                result.Thumbnail = ImageSource.FromUri(thumbnailUri);
            }
            else
            {
                result.Thumbnail = ImageSource.FromResource("Posterbot.Core.Assets.gears.png");
            }
            return result;
        }
    }
}

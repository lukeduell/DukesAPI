using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DukesAPI.Models
{
    public class TeamModel
    {
        [JsonPropertyName("team")]
        public TeamTI Team { get; set; }
    }

    public class TeamTI
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("shortDisplayName")]
        public string ShortDisplayName { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        [JsonPropertyName("record")]
        public RecordTI Record { get; set; }

        [JsonPropertyName("groups")]
        public GroupsTI Groups { get; set; }

        [JsonPropertyName("links")]
        public List<LinkTI> Links { get; set; }

        [JsonPropertyName("nextEvent")]
        public List<object> NextEvent { get; set; }
    }

    public class RecordTI
    {

    }

    public class GroupsTI
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("isConference")]
        public bool IsConference { get; set; }
    }

    public class LinkTI
    {
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("rel")]
        public List<string> Rel { get; set; }

        [JsonPropertyName("href")]
        public string Href { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("shortText")]
        public string ShortText { get; set; }

        [JsonPropertyName("isExternal")]
        public bool IsExternal { get; set; }

        [JsonPropertyName("isPremium")]
        public bool IsPremium { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DukesAPI.Models
{
    public class RankingsModel
    {
        [JsonPropertyName("sports")]
        public List<SportRank> Sports { get; set; }

        [JsonPropertyName("leagues")]
        public List<LeagueRank> Leagues { get; set; }

        [JsonPropertyName("rankings")]
        public List<RankingRank> Rankings { get; set; }
    }

    public class SportRank
    {
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("logos")]
        public List<LogoRank> Logos { get; set; }
    }

    public class LogoRank
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("alt")]
        public string Alt { get; set; }

        [JsonPropertyName("rel")]
        public List<string> Rel { get; set; }

        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class LeagueRank
    {
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("midsizeName")]
        public string MidsizeName { get; set; }
    }

    public class RankingRank
    {
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("occurrence")]
        public OccurrenceRank Occurrence { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("headline")]
        public string Headline { get; set; }

        [JsonPropertyName("shortHeadline")]
        public string ShortHeadline { get; set; }

        [JsonPropertyName("season")]
        public SeasonRank Season { get; set; }

        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("ranks")]
        public List<RankRank> Ranks { get; set; }
    }

    public class OccurrenceRank
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("last")]
        public bool Last { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("displayValue")]
        public string DisplayValue { get; set; }
    }

    public class SeasonRank
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("type")]
        public SeasonTypeRank Type { get; set; }

        [JsonPropertyName("athletes")]
        public ReferenceRank Athletes { get; set; }

        [JsonPropertyName("futures")]
        public ReferenceRank Futures { get; set; }

        [JsonPropertyName("leaders")]
        public ReferenceRank Leaders { get; set; }
    }

    public class SeasonTypeRank
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class ReferenceRank
    {
        [JsonPropertyName("$ref")]
        public string Ref { get; set; }
    }

    public class RankRank
    {
        [JsonPropertyName("current")]
        public int Current { get; set; }

        [JsonPropertyName("previous")]
        public int Previous { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("points")]
        public double Points { get; set; }

        [JsonPropertyName("firstPlaceVotes")]
        public int FirstPlaceVotes { get; set; }

        [JsonPropertyName("trend")]
        public string Trend { get; set; }

        [JsonPropertyName("team")]
        public TeamRank Team { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("conference")]
        public string Conference { get; set; }

        [JsonPropertyName("firstRoundBye")]
        public bool FirstRoundBye { get; set; }

        [JsonPropertyName("recordSummary")]
        public string RecordSummary { get; set; }
    }

    public class TeamRank
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("logos")]
        public List<LogoRank> Logos { get; set; }

        [JsonPropertyName("groups")]
        public TeamGroupRank Groups { get; set; }

        [JsonPropertyName("links")]
        public List<LinkRank> Links { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class TeamGroupRank
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("parent")]
        public GroupParentRank Parent { get; set; }

        [JsonPropertyName("isConference")]
        public bool IsConference { get; set; }
    }

    public class GroupParentRank
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("isConference")]
        public bool IsConference { get; set; }
    }

    public class LinkRank
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("rel")]
        public List<string> Rel { get; set; }
    }
}

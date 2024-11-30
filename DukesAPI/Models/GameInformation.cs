namespace DukesAPI.Models
{
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    public class EventSummary
    {
        [JsonPropertyName("header")]
        public Header Header { get; set; }

        [JsonPropertyName("boxscore")]
        public Boxscore Boxscore { get; set; }

        [JsonPropertyName("scoringPlays")]
        public List<ScoringPlay> ScoringPlays { get; set; }

        [JsonPropertyName("leaders")]
        public List<LeaderGI> Leaders { get; set; }

        [JsonPropertyName("teamStats")]
        public List<TeamStat> TeamStats { get; set; }

        [JsonPropertyName("winprobability")]
        public List<WinProbability> WinProbability { get; set; }

        [JsonPropertyName("gameInfo")]
        public GameInfo GameInfo { get; set; }

        [JsonPropertyName("pickcenter")]
        public List<PickCenter> PickCenter { get; set; }

        [JsonPropertyName("espnWP")]
        public List<EspnWP> EspnWP { get; set; }
    }

    public class Header
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("competitions")]
        public List<CompetitionGI> Competitions { get; set; }
    }

    public class CompetitionGI
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("competitors")]
        public List<CompetitorGI> Competitors { get; set; }
    }

    public class CompetitorGI
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("score")]
        public string Score { get; set; }

        [JsonPropertyName("team")]
        public TeamGI Team { get; set; }
    }

    public class TeamGI
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class Boxscore
    {
        [JsonPropertyName("teams")]
        public List<BoxscoreTeam> Teams { get; set; }
    }

    public class BoxscoreTeam
    {
        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("statistics")]
        public List<Statistic> Statistics { get; set; }
    }

    public class Statistic
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class ScoringPlay
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class LeaderGI
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("leaders")]
        public List<LeaderDetailGI> Leaders { get; set; }
    }

    public class LeaderDetailGI
    {
        [JsonPropertyName("athlete")]
        public AthleteGI Athlete { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class AthleteGI
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    }

    public class TeamStat
    {
        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("statistics")]
        public List<Statistic> Statistics { get; set; }
    }

    public class WinProbability
    {
        [JsonPropertyName("team")]
        public Team Team { get; set; }

        [JsonPropertyName("probability")]
        public double Probability { get; set; }
    }

    public class GameInfo
    {
        [JsonPropertyName("venue")]
        public VenueGI Venue { get; set; }
    }

    public class VenueGI
    {
        [JsonPropertyName("fullName")]
        public string FullName { get; set; }
    }

    public class PickCenter
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("provider")]
        public ProviderGI Provider { get; set; }

        [JsonPropertyName("spread")]
        public string Spread { get; set; }
    }

    public class ProviderGI
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class EspnWP
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("team")]
        public Team Team { get; set; }
    }

}

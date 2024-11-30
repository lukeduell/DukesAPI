using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DukesAPI.Models
{
    public class Scores
    {
        [JsonPropertyName("leagues")]
        public List<ScoresLeague> Leagues { get; set; }

        [JsonPropertyName("season")]
        public Season Season { get; set; }

        [JsonPropertyName("week")]
        public Week Week { get; set; }

        [JsonPropertyName("events")]
        public List<Event> Events { get; set; }
    }

    public class ScoresLeague
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("midsizeName")]
        public string MidsizeName { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("season")]
        public LeagueSeason Season { get; set; }

        [JsonPropertyName("logos")]
        public List<Logo> Logos { get; set; }

        [JsonPropertyName("calendarType")]
        public string CalendarType { get; set; }

        [JsonPropertyName("calendarIsWhitelist")]
        public bool CalendarIsWhitelist { get; set; }

        [JsonPropertyName("calendarStartDate")]
        public string CalendarStartDate { get; set; }

        [JsonPropertyName("calendarEndDate")]
        public string CalendarEndDate { get; set; }

        [JsonPropertyName("calendar")]
        public List<Calendar> Calendar { get; set; }
    }

    public class LeagueSeason
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
        public SeasonType Type { get; set; }
    }

    public class SeasonType
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class Logo
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

    public class Calendar
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }

        [JsonPropertyName("entries")]
        public List<CalendarEntry> Entries { get; set; }
    }

    public class CalendarEntry
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("alternateLabel")]
        public string AlternateLabel { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }
    }

    public class Season
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }
    }

    public class Week
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }
    }

    public class Event
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("season")]
        public EventSeason Season { get; set; }

        [JsonPropertyName("week")]
        public Week Week { get; set; }

        [JsonPropertyName("competitions")]
        public List<Competition> Competitions { get; set; }

        [JsonPropertyName("links")]
        public List<Link> Links { get; set; }

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }
    }

    public class EventSeason
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }

    public class Competition
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("attendance")]
        public int Attendance { get; set; }

        [JsonPropertyName("type")]
        public CompetitionType Type { get; set; }

        [JsonPropertyName("timeValid")]
        public bool TimeValid { get; set; }

        [JsonPropertyName("dateValid")]
        public bool DateValid { get; set; }

        [JsonPropertyName("neutralSite")]
        public bool NeutralSite { get; set; }

        [JsonPropertyName("conferenceCompetition")]
        public bool ConferenceCompetition { get; set; }

        [JsonPropertyName("playByPlayAvailable")]
        public bool PlayByPlayAvailable { get; set; }

        [JsonPropertyName("recent")]
        public bool Recent { get; set; }

        [JsonPropertyName("venue")]
        public Venue Venue { get; set; }

        [JsonPropertyName("competitors")]
        public List<Competitor> Competitors { get; set; }

        [JsonPropertyName("notes")]
        public List<object> Notes { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("broadcasts")]
        public List<Broadcast> Broadcasts { get; set; }

        [JsonPropertyName("leaders")]
        public List<Leader> Leaders { get; set; }

        [JsonPropertyName("groups")]
        public Group Groups { get; set; }

        [JsonPropertyName("format")]
        public Format Format { get; set; }

        [JsonPropertyName("tickets")]
        public List<Ticket> Tickets { get; set; }

        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }

        [JsonPropertyName("broadcast")]
        public string Broadcast { get; set; }

        [JsonPropertyName("geoBroadcasts")]
        public List<GeoBroadcast> GeoBroadcasts { get; set; }

        [JsonPropertyName("odds")]
        public List<Odds> Odds { get; set; }

        [JsonPropertyName("highlights")]
        public List<object> Highlights { get; set; }
    }

    public class CompetitionType
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class Venue
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("indoor")]
        public bool Indoor { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }

    public class Competitor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("homeAway")]
        public string HomeAway { get; set; }

        [JsonPropertyName("team")]
        public ScoresTeam Team { get; set; }

        [JsonPropertyName("score")]
        public string Score { get; set; }

        [JsonPropertyName("curatedRank")]
        public CuratedRank CuratedRank { get; set; }

        [JsonPropertyName("statistics")]
        public List<object> Statistics { get; set; }

        [JsonPropertyName("records")]
        public List<Record> Records { get; set; }

        [JsonPropertyName("leaders")]
        public List<Leader> Leaders { get; set; }
    }

    public class ScoresTeam
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("shortDisplayName")]
        public string ShortDisplayName { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("alternateColor")]
        public string AlternateColor { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        [JsonPropertyName("venue")]
        public TeamVenue Venue { get; set; }

        [JsonPropertyName("links")]
        public List<Link> Links { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("conferenceId")]
        public string ConferenceId { get; set; }
    }

    public class TeamVenue
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class ScoresLink
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

    public class CuratedRank
    {
        [JsonPropertyName("current")]
        public int Current { get; set; }
    }

    public class Record
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    }

    public class Leader
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("shortDisplayName")]
        public string ShortDisplayName { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("leaders")]
        public List<LeaderDetail> Leaders { get; set; }
    }

    public class LeaderDetail
    {
        [JsonPropertyName("displayValue")]
        public string DisplayValue { get; set; }

        [JsonPropertyName("value")]
        public double Value { get; set; } // Changed from int to double

        [JsonPropertyName("athlete")]
        public Athlete Athlete { get; set; }

        [JsonPropertyName("team")]
        public TeamId Team { get; set; }
    }

    public class ScoresAthlete
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("fullName")]
        public string FullName { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("links")]
        public List<Link> Links { get; set; }

        [JsonPropertyName("headshot")]
        public string Headshot { get; set; }

        [JsonPropertyName("jersey")]
        public string Jersey { get; set; }

        [JsonPropertyName("position")]
        public Position Position { get; set; }

        [JsonPropertyName("team")]
        public TeamId Team { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }
    }

    public class Position
    {
        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }
    }

    public class TeamId
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class Broadcast
    {
        [JsonPropertyName("market")]
        public string Market { get; set; }

        [JsonPropertyName("names")]
        public List<string> Names { get; set; }
    }

    public class Group
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("isConference")]
        public bool IsConference { get; set; }
    }

    public class Format
    {
        [JsonPropertyName("regulation")]
        public Regulation Regulation { get; set; }
    }

    public class Regulation
    {
        [JsonPropertyName("periods")]
        public int Periods { get; set; }
    }

    public class Ticket
    {
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        [JsonPropertyName("numberAvailable")]
        public int NumberAvailable { get; set; }

        [JsonPropertyName("links")]
        public List<Link> Links { get; set; }
    }

    public class GeoBroadcast
    {
        [JsonPropertyName("type")]
        public BroadcastType Type { get; set; }

        [JsonPropertyName("market")]
        public Market Market { get; set; }

        [JsonPropertyName("media")]
        public Media Media { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }
    }

    public class BroadcastType
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }
    }

    public class Market
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Media
    {
        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("darkLogo")]
        public string DarkLogo { get; set; }
    }

    public class Odds
    {
        [JsonPropertyName("provider")]
        public Provider Provider { get; set; }

        [JsonPropertyName("details")]
        public string Details { get; set; }

        [JsonPropertyName("overUnder")]
        public double OverUnder { get; set; }

        [JsonPropertyName("spread")]
        public double Spread { get; set; }

        [JsonPropertyName("awayTeamOdds")]
        public TeamOdds AwayTeamOdds { get; set; }

        [JsonPropertyName("homeTeamOdds")]
        public TeamOdds HomeTeamOdds { get; set; }

        [JsonPropertyName("open")]
        public OddsDetail Open { get; set; }

        [JsonPropertyName("current")]
        public OddsDetail Current { get; set; }
    }

    public class Provider
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }
    }

    public class TeamOdds
    {
        [JsonPropertyName("favorite")]
        public bool Favorite { get; set; }

        [JsonPropertyName("underdog")]
        public bool Underdog { get; set; }

        [JsonPropertyName("team")]
        public OddsTeam Team { get; set; }
    }

    public class OddsTeam
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }

    public class OddsDetail
    {
        [JsonPropertyName("over")]
        public OddsValue Over { get; set; }

        [JsonPropertyName("under")]
        public OddsValue Under { get; set; }

        [JsonPropertyName("total")]
        public OddsTotal Total { get; set; }
    }

    public class OddsValue
    {
        [JsonPropertyName("value")]
        public double Value { get; set; } // Ensure this is double

        [JsonPropertyName("displayValue")]
        public string DisplayValue { get; set; }

        [JsonPropertyName("alternateDisplayValue")]
        public string AlternateDisplayValue { get; set; }

        [JsonPropertyName("decimal")]
        public double Decimal { get; set; }

        [JsonPropertyName("fraction")]
        public string Fraction { get; set; }

        [JsonPropertyName("american")]
        public string American { get; set; }

        [JsonPropertyName("outcome")]
        public Outcome Outcome { get; set; }
    }

    public class Outcome
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class OddsTotal
    {
        [JsonPropertyName("alternateDisplayValue")]
        public string AlternateDisplayValue { get; set; }

        [JsonPropertyName("american")]
        public string American { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("displayValue")]
        public string DisplayValue { get; set; }

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }

        [JsonPropertyName("highTemperature")]
        public int HighTemperature { get; set; }

        [JsonPropertyName("conditionId")]
        public string ConditionId { get; set; }

        [JsonPropertyName("link")]
        public ScoresLink Link { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("clock")]
        public double Clock { get; set; }

        [JsonPropertyName("displayClock")]
        public string DisplayClock { get; set; }

        [JsonPropertyName("period")]
        public int Period { get; set; }

        [JsonPropertyName("type")]
        public StatusType Type { get; set; }
    }

    public class StatusType
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        [JsonPropertyName("shortDetail")]
        public string ShortDetail { get; set; }
    }
}

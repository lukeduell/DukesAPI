using static System.Net.Mime.MediaTypeNames;
using System.Text.Json.Serialization;

namespace DukesAPI.Models
{
    public class NewsResponse
    {
        [JsonPropertyName("header")]
        public string Header { get; set; }

        [JsonPropertyName("link")]
        public Link Link { get; set; }

        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }
    }
    public class Link
    {
        public string Language { get; set; }
        public List<string> Rel { get; set; }
        public string Href { get; set; }
        public string Text { get; set; }
        public string ShortText { get; set; }
        public bool IsExternal { get; set; }
        public bool IsPremium { get; set; }
    }
    public class Article
    {
        public string DataSourceIdentifier { get; set; }
        public string Type { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? Published { get; set; }
        public List<Image> Images { get; set; }
        public List<Category> Categories { get; set; }
        public bool Premium { get; set; }
        public ArticleLinks Links { get; set; }
        public string Byline { get; set; }
    }
    public class Image
    {
        public string DataSourceIdentifier { get; set; }
        public int? Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string Credit { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string Url { get; set; }
        public string Alt { get; set; }
    }
    public class Category
    {
        public int? Id { get; set; }
        public string Type { get; set; }
        public string Guid { get; set; }
        public string Description { get; set; }
        public int? SportId { get; set; }
        public int? TopicId { get; set; }
        public int? TeamId { get; set; }
        public int? AthleteId { get; set; }
        public int? LeagueId { get; set; }
        public string Slug { get; set; }
        public Team Team { get; set; }
        public Athlete Athlete { get; set; }
        public League League { get; set; }
        public Contributor Contributor { get; set; }
    }
    public class Team
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public TeamLinks Links { get; set; }
    }
    public class Athlete
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public AthleteLinks Links { get; set; }
    }
    public class League
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public Logos Logos { get; set; }
        public LeagueLinks Links { get; set; }
    }
    public class Contributor
    {
        public int? Id { get; set; }
        public string Description { get; set; }
        public ContributorLinks Links { get; set; }
        public Headshots Headshots { get; set; }
    }
    public class ArticleLinks
    {
        public WebLink Web { get; set; }
        public MobileLink Mobile { get; set; }
        public ApiLink Api { get; set; }
        public AppLink App { get; set; }
    }
    public class WebLink
    {
        public string Href { get; set; }
        public WebSelfLink Self { get; set; }
        public WebSeoLink Seo { get; set; }
    }

    public class MobileLink
    {
        public string Href { get; set; }
    }

    public class ApiLink
    {
        public ApiSelfLink Self { get; set; }
        public ApiArtworkLink Artwork { get; set; }
    }

    public class AppLink
    {
        public SportsCenterLink Sportscenter { get; set; }
    }
    public class WebSelfLink
    {
        public string Href { get; set; }
    }

    public class WebSeoLink
    {
        public string Href { get; set; }
    }

    public class ApiSelfLink
    {
        public string Href { get; set; }
    }

    public class ApiArtworkLink
    {
        public string Href { get; set; }
    }

    public class SportsCenterLink
    {
        public string Href { get; set; }
    }
    public class TeamLinks
    {
        public WebTeamLinks Web { get; set; }
        public MobileTeamLinks Mobile { get; set; }
    }

    public class WebTeamLinks
    {
        public TeamsLink Teams { get; set; }
    }

    public class MobileTeamLinks
    {
        public TeamsLink Teams { get; set; }
    }

    public class TeamsLink
    {
        public string Href { get; set; }
    }
    public class AthleteLinks
    {
        public WebAthleteLinks Web { get; set; }
        public MobileAthleteLinks Mobile { get; set; }
    }

    public class WebAthleteLinks
    {
        public AthletesLink Athletes { get; set; }
    }

    public class MobileAthleteLinks
    {
        public AthletesLink Athletes { get; set; }
    }

    public class AthletesLink
    {
        public string Href { get; set; }
    }
    public class LeagueLinks
    {
        public WebLeagueLinks Web { get; set; }
        public MobileLeagueLinks Mobile { get; set; }
    }

    public class WebLeagueLinks
    {
        public LeaguesLink Leagues { get; set; }
    }

    public class MobileLeagueLinks
    {
        public LeaguesLink Leagues { get; set; }
    }

    public class LeaguesLink
    {
        public string Href { get; set; }
    }
    public class ContributorLinks
    {
        public WebContributorLinks Web { get; set; }
        public MobileContributorLinks Mobile { get; set; }
    }

    public class WebContributorLinks
    {
        public ContributorsLink Contributors { get; set; }
    }

    public class MobileContributorLinks
    {
        public ContributorsLink Contributors { get; set; }
    }

    public class ContributorsLink
    {
        public string Href { get; set; }
    }
    public class Headshots
    {
        public FullHeadshot Full { get; set; }
    }

    public class FullHeadshot
    {
        public string Href { get; set; }
    }
    public class Logos
    {
        public LogoHref Full { get; set; }
        public LogoHref Large { get; set; }
        public LogoHref Medium { get; set; }
        public LogoHref Small { get; set; }
        public LogoHref XSmall { get; set; }
        public LogoHref XXSmall { get; set; }
    }

    public class LogoHref
    {
        public string Href { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public DarkLogo Dark { get; set; }
    }

    public class DarkLogo
    {
        public string Href { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
    }
    public class GuidCategory
    {
        public string Type { get; set; }
        public string Guid { get; set; }
    }


}

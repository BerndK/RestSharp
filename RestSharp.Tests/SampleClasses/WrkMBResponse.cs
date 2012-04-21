using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using RestSharp.Deserializers;

namespace MTB.Worker.MB
{
    public class MBResponseRelease
    {
        public Release release { get; set; }

    }

    public class Release
    {
        public string title { get; set; }
        public string id { get; set; }
        public string status { get; set; }
        public string quality { get; set; }
        public string date { get; set; }
        public string country { get; set; }
        public string asin { get; set; }
        [DeserializeAs(Name = "text-representation")]
        public Text_Representation text_representation { get; set; }
        [DeserializeAs(Name = "artist-credit")]
        public Artist_credit artist_credit { get; set; }
        [DeserializeAs(Name = "release-group")]
        public Release_group release_group { get; set; }
        [DeserializeAs(Name = "label-info-list")]
        public Label_info_list label_info_list { get; set; }
        [DeserializeAs(Name = "medium-list")]
        public Medium_list medium_list { get; set; }
        [DeserializeAs(Name = "relation-list")]
        public Relation_list relation_list { get; set; }
    }

    public class Text_Representation
    {
        public string language { get; set; }
        public string script { get; set; }
    }

    /// <summary>
    /// SubObject, das die Liste der name-credits hält
    /// </summary>
    public class Artist_credit
    {
        [DeserializeAs(Name = "name-credit")]
        public List<Name_credit> name_credits { get; set; }
    }

    /// <summary>
    /// Hält genau einen Verweis auf einen Artist
    /// </summary>
    public class Name_credit
    {
        public string joinphrase { get; set; }
        public Artist artist { get; set; }
    }

    public class Artist
    {
        public string id { get; set; }
        public string name { get; set; }
        [DeserializeAs(Name = "sort-name")]
        public string sort_name { get; set; }
        public string ipi { get; set; }
    }

    public class Release_group
    {
        public string type { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        [DeserializeAs(Name = "first-release-date")]
        public string first_release_date { get; set; }
    }

    public class Label_info_list
    {
        public int count { get; set; }
        [DeserializeAs(Name = "label-info")]
        public List<Label_info> label_infos { get; set; }
    }

    public class Label_info
    {
        [DeserializeAs(Name = "catalog-number")]
        public string catalog_number { get; set; }
        public Label label { get; set; }
    }

    public class Label
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sort_name { get; set; }
        [DeserializeAs(Name = "label-code")]
        public string label_code { get; set; }
    }

    public class Medium_list
    {
        public int count { get; set; }
        [DeserializeAs(Name = "medium")]
        public List<Medium> mediums { get; set; }
    }

    public class Medium
    {
        public int position { get; set; }
        [DeserializeAs(Name = "track-list")]
        public Track_list track_list { get; set; }
    }

    public class Track_list
    {
        public int count { get; set; }
        public int offset { get; set; }
        [DeserializeAs(Name = "track")]
        public List<Track> tracks { get; set; }
    }

    public class Track
    {
        public int position { get; set; }
        public int length { get; set; }
        public Recording recording { get; set; }
    }

    public class Recording
    {
        public string id { get; set; }
        public string title { get; set; }
        public int length { get; set; }
    }

    public class Relation_list
    {
        public string target_type { get; set; }
        [DeserializeAs(Name = "relation")]
        public List<Relation> relations { get; set; }

    }

    public class Relation
    {
        public string type { get; set; }
        public string target { get; set; }
    }
}

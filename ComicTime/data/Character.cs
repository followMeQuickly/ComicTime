
using System;
using System.Collections.Generic;
using Java.Lang;

public class Thumbnail
{
	public string path { get; set; }
	public string extension { get; set; }
}

public class Comics
{
	public int available { get; set; }
	public string collectionURI { get; set; }
	public List<object> items { get; set; }
	public int returned { get; set; }
}

public class Series
{
	public int available { get; set; }
	public string collectionURI { get; set; }
	public List<object> items { get; set; }
	public int returned { get; set; }
}

public class Stories
{
	public int available { get; set; }
	public string collectionURI { get; set; }
	public List<object> items { get; set; }
	public int returned { get; set; }
}

public class Events
{
	public int available { get; set; }
	public string collectionURI { get; set; }
	public System.Collections.Generic.List<object> items { get; set; }
	public int returned { get; set; }
}

public class Url
{
	public string type { get; set; }
	public string url { get; set; }
}

public class Character
{
	public int id { get; set; }
	public string name { get; set; }
	public string description { get; set; }
	public string modified { get; set; }
	public Thumbnail thumbnail { get; set; }
	public string resourceURI { get; set; }
	public Comics comics { get; set; }
	public Series series { get; set; }
	public Stories stories { get; set; }
	public Events events { get; set; }
	public List<Url> urls { get; set; }

    public static explicit operator Java.Lang.Object(Character v)
    {
        throw new NotImplementedException();
    }
}

public class Data
{
	public int offset { get; set; }
	public int limit { get; set; }
	public int total { get; set; }
	public int count { get; set; }
    public List<Character> results { get; set; }
}

public class RootObject
{
	public int code { get; set; }
	public string status { get; set; }
	public string copyright { get; set; }
	public string attributionText { get; set; }
	public string attributionHTML { get; set; }
	public string etag { get; set; }
	public Data data { get; set; }
}

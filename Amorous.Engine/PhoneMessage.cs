using System;
using Newtonsoft.Json;

public class PhoneMessage
{
	[JsonProperty("Icon")]
	public string Icon { get; set; }

	[JsonProperty("Title")]
	public string Title { get; set; }

	[JsonProperty("Message")]
	public string Message { get; set; }

	[JsonProperty("Date")]
	public DateTime Date { get; set; }
}

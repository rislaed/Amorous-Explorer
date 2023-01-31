using System;
using Newtonsoft.Json;

public class PhoneMessage
{ // _iDN1IKOu3e1uADYzeMEUon5D9fg
	[JsonProperty("Icon")]
	public string Icon { get; set; }

	[JsonProperty("Title")]
	public string Title { get; set; }

	[JsonProperty("Message")]
	public string Message { get; set; }

	[JsonProperty("Date")]
	public DateTime Date { get; set; }
}

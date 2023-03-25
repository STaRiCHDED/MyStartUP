using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class BusinessData
{
    [JsonProperty("endTime")] 
    [JsonConverter(typeof(CustomDateTimeConverter))]
    public DateTime EndTime { get; set;}
    [JsonProperty("balance")] 
    public int Balance { get; set;}
    [JsonProperty("businesses")] 
    public List<Business> Businesses { get; set;}
}
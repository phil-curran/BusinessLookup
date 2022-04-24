using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BusinessClient.Models
{
  public class Business
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public string Category { get; set; }
    public string Subcategory { get; set; }

    public static List<Business> GetBusinesses()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      var jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      var businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

      return businessList;
    }

    public static Business GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var business = JsonConvert.DeserializeObject<Business>(jsonResponse.ToString());

      return business;
    }

    public static void Post(Business business)
    {
      var jsonBusiness = JsonConvert.SerializeObject(business);
      var apiCallTask = ApiHelper.Post(jsonBusiness);
    }

    public static void Put(Business business)
    {
      var jsonBusiness = JsonConvert.SerializeObject(business);
      var apiCallTask = ApiHelper.Put(business.Id, jsonBusiness);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}




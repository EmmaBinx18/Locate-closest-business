using System.Collections.Generic; 

namespace Locate_closest_business.Models
{
    public class SearchModel
    {
        public Dictionary<string, Dictionary<string, string[]>> serviceDictionary;

        public SearchModel(){
            serviceDictionary = new Dictionary<string, Dictionary<string, string[]>>();
            serviceDictionary.Add("Agriculture, hunting, forestry, fishing", new Dictionary<string, string[]>{
                {"businessList", new string[]{"hardware_store", "campground"}},
                {"keywordList", new string[]{"Gun shop"}}}
            );
            serviceDictionary.Add("Electricity, Gas, Water supply", new Dictionary<string, string[]>{
                {"businessList", new string[]{"gas_station", "electrician"}},
                {"keywordList", new string[]{"Water"}}}
            );
            serviceDictionary.Add("Manufacturing", new Dictionary<string, string[]>{
                {"businessList", new string[]{}},
                {"keywordList", new string[]{"Manufacturing"}}}
            );
            serviceDictionary.Add("Construction and related services", new Dictionary<string, string[]>{
                {"businessList", new string[]{"roofing_contractor", "painter"}},
                {"keywordList", new string[]{"Construction"}}}
            );
            serviceDictionary.Add("Wholesale, Retail trade, Spaza shops", new Dictionary<string, string[]>{
                {"businessList", new string[]{"clothing_store", "convenience_store", "department_store", "electronics_store", "furniture_store", "hardware_store", "home_goods_store", "jewelry_store", "shoe_store", "shopping_mall", "supermarket"}},
                {"keywordList", new string[]{}}}
            );
            serviceDictionary.Add("Information and Communication services", new Dictionary<string, string[]>{
                {"businessList", new string[]{}},
                {"keywordList", new string[]{"Service Provider", "Information and Communication services"}}}
            );
            serviceDictionary.Add("Media and Entertainment", new Dictionary<string, string[]>{
                {"businessList", new string[]{}},
                {"keywordList", new string[]{"broadcast", "tv production"}}}
            );
            serviceDictionary.Add("Financial and Business services", new Dictionary<string, string[]>{
                {"businessList", new string[]{"accounting"}},
                {"keywordList", new string[]{"Private security", "financial", "machine rental"}}}
            );
            serviceDictionary.Add("Accommodation for quarantine, essential services", new Dictionary<string, string[]>{
                {"businessList", new string[]{}},
                {"keywordList", new string[]{"quarantine accommodation"}}}
            );
            serviceDictionary.Add("Food services (Deliveries)", new Dictionary<string, string[]>{
                {"businessList", new string[]{"meal_delivery", "meal_takeaway"}},
                {"keywordList", new string[]{}}}
            );
            serviceDictionary.Add("Transport, Storage, Communication services", new Dictionary<string, string[]>{
                {"businessList", new string[]{"airport", "bus_station", "transit_station", "train_station", "taxi_stand", }},
                {"keywordList", new string[]{"Communication Service"}}}
            );
            serviceDictionary.Add("Mining and Quarrying", new Dictionary<string, string[]>{
                {"businessList", new string[]{}},
                {"keywordList", new string[]{"mining and quarrying"}}}
            );
            serviceDictionary.Add("Repair and Related Emergency services", new Dictionary<string, string[]>{
                {"businessList", new string[]{"electrician", "plumber", "locksmith", "car_repair", "roofing_contractor", "police"}},
                {"keywordList", new string[]{"towing", "Private security"}}}
            );
            serviceDictionary.Add("Supply Chain", new Dictionary<string, string[]>{
                {"businessList", new string[]{}},
                {"keywordList", new string[]{"logistic", "industrial production"}}}
                
            );
            serviceDictionary.Add("Health, Social and Personal services", new Dictionary<string, string[]>{
                {"businessList", new string[]{"dentist", "doctor", "drugstore", "pharmacy", "pet_store", "hospital"}},
                {"keywordList", new string[]{"pest control", "counselling", "old age home"}}}
            );
        }
    }
}
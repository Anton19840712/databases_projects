
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using FireBaseNotification.Models;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FireBaseNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly FirebaseClient _fireBaseClient;

        public DeveloperController(IFirebaseConfig fireBaseConfig)
        {
            var fireBaseConfigData = new FirebaseConfig()
            {
                //AuthSecret = "AIzaSyCYY93TAc47XlS5tZnxdeHtzWND591tZNE",//Web API Key
                AuthSecret = "9M3Lnl5x8XpYFsao9SZRiteSWGa31ZNu66DaIhC7",//Secret Key //project settings, service account, dataBase secrets - secret
                BasePath = "https://notificationsample-fac93-default-rtdb.firebaseio.com/"
            };

            _fireBaseClient = new FirebaseClient(fireBaseConfigData); //1 create database client
        }

        [HttpGet]
        [Route("all")]
        public List<Developer> GetAllDevelopers()
        {
            var responseFromFireBase = _fireBaseClient.Get("Developer");

            dynamic jResult = JsonConvert.DeserializeObject(responseFromFireBase.Body);

            var list = new List<Developer>();

            foreach (var item in jResult)
            {
                list.Add(JsonConvert.DeserializeObject<Developer>(((JProperty)item).Value.ToString()));
            }

            return list;
        }

        [HttpPost]
        [Route("create")]
        public Developer CreateDeveloper(Developer developer)
        {
            _fireBaseClient.Push("Developer/", developer);//this api could return object back

            return developer;
        }

        [HttpGet]
        [Route("getById")]
        public Developer GetById(string id)
        {
            var response = _fireBaseClient.Get("Developer/" + id);

            var result = JsonConvert.DeserializeObject<Developer>(response.Body);

            return result;
        }


        [HttpPost]
        [Route("editById")]
        public string EditById(Developer developer, string objectId)
        {
           var data =_fireBaseClient.Set("Developer/" + objectId, developer);

           return data.Body;
        }

        [HttpPost]// do not understand http delete
        [Route("deleteById")]
        public FirebaseResponse CreateDeveloper(string id)//sample: "-MwHMEtNSNeqJUU7wfXn"
        {
            var deletedDeveloper = _fireBaseClient.Delete("Developer/" + id);//this api could return object back

            return deletedDeveloper;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Net;
using Square.OkHttp;
using System.Security.Cryptography;

namespace ComicTime.data.Source.remote
{
    public class CharacterRemoteRepo : CharacterDataSource
    {
       
      

       

        public void getCharacters(Action<List<Character>> characters)
        {
            //todo: add variables to build this.  
            //
            System.Threading.Tasks.Task.Run(() => doTheThing(characters)).Wait();

           
        }

        public void refreshCharacters()
        {
            throw new NotImplementedException();
        }

        public void doTheThing(Action<List<Character>> characters)
        {
            try{
                
				MD5 md5 = System.Security.Cryptography.MD5.Create();
				DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                var timeStamp = (long)((DateTime.UtcNow - Jan1st1970).TotalMilliseconds);
                string api_key = "insert public key hear";
                string private_key = "insert private key here";
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(timeStamp
                                                                        + private_key
                                                                        + api_key);
                

				byte[] hash = md5.ComputeHash(inputBytes);

				// step 2, convert byte array to hex string

				StringBuilder sb = new StringBuilder();

				for (int i = 0; i < hash.Length; i++)

				{

					sb.Append(hash[i].ToString("X2"));

				}
                var thing = sb.ToString().ToLower();
;
                var url = 
                    new URL("https://gateway.marvel.com:443/v1/public/characters?apikey=550bdabffb29d3cc2bf6813a68021ee4&hash=" + thing + "&ts=" + timeStamp + "&limit=10");//+ "&format=json");
								  //var uriBuilder = new UriBuilder();
								  //uriBuilder.Scheme = "https";
								  //uriBuilder.Host = "gateway.marvel.com";
								  //uriBuilder.Path = "v1/public/characters";
								  //uriBuilder.Query = "apikey=550bdabffb29d3cc2bf6813a68021ee4";
								  //uriBuilder.
				OkHttpClient client = new OkHttpClient();
				Request request =
					new Request
						.Builder()
						.Url(url)
						.Build();
				Response response = client.NewCall(request).Execute();
               
                var body = response.Body().String().Replace('\"', '"');

                var x = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(body);
                var things = x.data.results;
                characters(things);


            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

       

    }
}
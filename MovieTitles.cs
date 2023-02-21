using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class MovieSolution {

    /*
     * Complete the function below. 
     * Base url: https://jsonmock.hackerrank.com/api/moviesdata/search/?Title=
    //  */
    // static string[] getMovieTitles(string substr) {
    //     var titles = new List<string>();
    //     var baseUrl = "https://jsonmock.hackerrank.com/api/moviesdata/search/?Title=";
    //     var client = new WebClient();
    //     var response = client.DownloadString(baseUrl + substr);
    //     var json = JObject.Parse(response);
    //     var pagesTotal = (int)json["total_pages"];
    //     for (int x = 1; x <= pagesTotal; x++)
    //     {
    //         var pageResponse = client.DownloadString(baseUrl + substr + "&page=" + x);
    //         var pageJson = JObject.Parse(pageResponse);
    //         var movies = pageJson["data"];
    //         foreach (var movie in movies)
    //         {
    //             titles.Add((string)movie["Title"]);
    //         }
    //     }
    //     titles.Sort();
    //     return titles.ToArray();
        
        
    // }
/// THis is the same as the above solution
/// But more optimized by using a HashSet to store the movie titles <summary>
/// THis is the same as the above solution
/// </summary>
/// <param name="args"></param>    //  static string[] getMovieTitles(string substr) {
    //     var movieTitles = new HashSet<string>();
    //     var url = "https://jsonmock.hackerrank.com/api/moviesdata/search/?Title=";
    //     var client = new WebClient();
    //     var response = client.DownloadString(url + substr);
    //     var json = JObject.Parse(response);
    //     var totalPages = (int)json["total_pages"];
    //     for (int i = 1; i <= totalPages; i++)
    //     {
    //         var pageResponse = client.DownloadString(url + substr + "&page=" + i);
    //         var pageJson = JObject.Parse(pageResponse);
    //         var movies = pageJson["data"];
    //         foreach (var movie in movies)
    //         {
    //             movieTitles.Add((string)movie["Title"]);
    //         }
    //     }
    //     var sortedMovieTitles = movieTitles.ToList();
    //     sortedMovieTitles.Sort();
    //     return sortedMovieTitles.ToArray();


       
        
        
     
    // }
    
    static void drawPyramid(int n) {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i + 1; k++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }



    static void MMain(String[] args) {
        // string s = Console.ReadLine();
        
        // string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
        // TextWriter fileOut = new StreamWriter(@fileName, true);
        
        // string[] res = getMovieTitles(s);
        // for(int res_i = 0; res_i < res.Length; res_i++) {
        //     fileOut.WriteLine(res[res_i]);
        // }
        
        // fileOut.Flush();
        // fileOut.Close();
        drawPyramid(5);
        
    }
}
using System;
using Octokit;

public class Program
{
    public static async System.Threading.Tasks.Task Main(string[] args)
    {
        var token = "api_token";
        var client = new GitHubClient(new ProductHeaderValue("GitHubCommitParser")); //Name of your app
        client.Credentials = new Credentials(token);
        var commits = await client.Repository.Commit.GetAll("Name", "Repos"); //Account Name / Name of your repository

        foreach (var commit in commits)
        {
            Console.WriteLine("SHA: " + commit.Sha);
            Console.WriteLine("Commit Message: " + commit.Commit.Message);
            Console.WriteLine("Author: " + commit.Commit.Author.Name);
            Console.WriteLine("Date: " + commit.Commit.Author.Date);
            Console.WriteLine("--------------------");
        }
    }
}

var builder = WebApplication.CreateBuilder(args);

//TODO: CHALLENGE #1 - Use coPilot help or Chat GPT help to run this API in the 5010 port

var app = builder.Build();

app.MapGet("/", () => "Hello Unicorn!");

//TODO: EXERCISE #8 - Using interactive prompt on the terminal Ask CoPilot to Install Bogus Library
//TODO: EXERCISE #9 - Using CoPilot help alter this endpoint to use Bogus Library to generate 50 names
app.MapGet("/list-names", () =>
{
    return new string[] { "Paul", "Matt", "Zack", "John" };
});


//TODO: EXERCISE #10 - Use CoPilot to create a new endpoint that validates a US phone number using REGEX

//TODO: EXERCISE #11 - Moving calculator to Backend Using one of the methods you had learn, craft a prompt to generate a calculator endpoint


//TODO: CHALLENGE #2 - Create tests for the calculator endpoint

//TODO: CHALLENGE #3 - Using CoPilot help create a new endpoint that returns the sum of columns A and B contained in a CSV file 

//TODO: CHALLENGE #4 - Create a React Component to show results of the CSV file Challange #3

//TODO: CHALLENGE #5 - Create a React Component to validate a US phone number using the endpoint created in Exercise #10

app.Run();

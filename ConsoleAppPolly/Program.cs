using Polly;

Console.WriteLine("Hello, Polly!");

// polisa
var retryPolicy = Policy
  .Handle<ArgumentNullException>()
  .WaitAndRetry(
    retryCount: 5,
    retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
    (exception, timeSpan, retryCount, context) => {
        Console.WriteLine($"Retry nr. {retryCount}");
    }
  );

retryPolicy.Execute(() => 
{
    int a = 1;
    int b = Math.Min(a, 2);

    throw new ArgumentNullException();
});
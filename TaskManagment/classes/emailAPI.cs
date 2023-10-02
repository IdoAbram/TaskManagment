using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class GmailEmailSender
{
    private const string ApplicationName = "YourApp";
    private const string FromEmailAddress = "abramovichido@gmail.com"; // Replace with your Gmail address

    public static async Task<bool> SendEmailAsync(string toEmail, string subject, string message)
    {
        try
        {
            // Create Gmail API service with OAuth2.0 authentication
            var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = "745703339160-oni5fq6vqtt6etvj6e35q98m140lapmo.apps.googleusercontent.com",
                    ClientSecret = "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"
                },
                new[] { GmailService.Scope.GmailSend },
                "user",
                CancellationToken.None
            );

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Create the email message
            var msg = new Google.Apis.Gmail.v1.Data.Message();
            var encodedEmail = Base64UrlEncode(CreateEmail(FromEmailAddress, toEmail, subject, message));
            msg.Raw = encodedEmail;

            // Send the email
            var sendMessageRequest = service.Users.Messages.Send(msg, "me");
            var sendResponse = await sendMessageRequest.ExecuteAsync();

            if (sendResponse != null && sendResponse.Id != null)
            {
                return true; // Email sent successfully
            }
            else
            {
                Console.WriteLine("Failed to send email.");
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return false; // Failed to send email
        }
    }

    private static string CreateEmail(string from, string to, string subject, string message)
    {
        var email = new StringWriter();
        email.WriteLine("From: " + from);
        email.WriteLine("To: " + to);
        email.WriteLine("Subject: " + subject);
        email.WriteLine("MIME-Version: 1.0");
        email.WriteLine("Content-Type: text/plain; charset=UTF-8");
        email.WriteLine();
        email.WriteLine(message);
        return email.ToString();
    }

    private static string Base64UrlEncode(string input)
    {
        var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
        return Convert.ToBase64String(inputBytes).Replace('+', '-').Replace('/', '_');
    }
}

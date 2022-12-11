using Microsoft.AspNetCore.Mvc.Filters;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace ECommerce.WebUI.EmailService
{
    public class EmailSender
    {
        private const string SendGridKey = "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";
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(SendGridKey, subject, htmlMessage, email);
        }

        private Task Execute(string sendGridKey, string subject, string message, string email)
        {
            var client = new SendGridClient(sendGridKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("info@ecommerce.com", "E-Commerce"),
                Subject=subject,
                PlainTextContent= message,
                HtmlContent= message
            };
            msg.AddTo(new EmailAddress(email));
            return client.SendEmailAsync(msg);
        }
    }
}

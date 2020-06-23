namespace GiftSystem.Models
{
    using Data.Models;
    using Ganss.XSS;

    public class SendCreditsViewModel
    {
        public ApplicationUser Sender { get; set; }
        public string ReceiverPhoneNumber { get; set; }
        public int Credits { get; set; }
        public string Message { get; set; }
        public string SanitizedMessage
            => new HtmlSanitizer().Sanitize(this.Message);
    }
}

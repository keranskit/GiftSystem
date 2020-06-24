namespace GiftSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Transfer
    {
        public string Id { get; set; }
        public int Credits { get; set; }
        public string Message { get; set; }
        public string SenderId { get; set; }
        public virtual ApplicationUser Sender { get; set; }
        public string ReceiverId { get; set; }
        public virtual ApplicationUser Receiver { get; set; }
    }
}

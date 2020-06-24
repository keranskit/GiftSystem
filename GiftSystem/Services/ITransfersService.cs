namespace GiftSystem.Services
{
    using System.Collections.Generic;
    using Data.Models;

    public interface ITransfersService
    {
        IEnumerable<Transfer> GetBySenderId(string id);
        IEnumerable<Transfer> GetByReceiverId(string id);
        IEnumerable<Transfer> GetAll();
    }
}

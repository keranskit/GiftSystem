namespace GiftSystem.Services
{
    using Data.Models;

    using System.Collections.Generic;

    public interface ITransfersService
    {
        IEnumerable<Transfer> GetBySenderId(string id);
        IEnumerable<Transfer> GetByReceiverId(string id);
        IEnumerable<Transfer> GetAll();
    }
}

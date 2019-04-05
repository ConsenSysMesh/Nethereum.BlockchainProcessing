﻿using System.Threading.Tasks;

namespace Nethereum.BlockchainProcessing.Processing.Logs.Handling
{
    public interface IEventHandlerHistoryDb
    {
        Task AddEventHandlerHistory(long eventHandlerId, string eventKey);
        Task<bool> ContainsEventHandlerHistory(long id, string eventKey);
    }
}

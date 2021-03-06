﻿using RiotSharp.StatusEndpoint;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RiotSharp
{
    public interface IStatusRiotApi
    {
        List<Shard> GetShards();
        Task<List<Shard>> GetShardsAsync();
        ShardStatus GetShardStatus(Region region);
        Task<ShardStatus> GetShardStatusAsync(Region region);
    }
}

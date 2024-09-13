using StackExchange.Redis;

public class RedisCacheService
{
    private readonly IDatabase _cache;

    public RedisCacheService(IConnectionMultiplexer redis)
    {
        _cache = redis.GetDatabase();
    }

    public async Task SetCacheValueAsync(string key, string value, TimeSpan? expiry = null)
    {
        await _cache.StringSetAsync(key, value, expiry);
    }

    public async Task<string> GetCacheValueAsync(string key)
    {
        return await _cache.StringGetAsync(key);
    }
}

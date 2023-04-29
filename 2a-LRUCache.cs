using Xunit;

namespace MidInterviewTest;

/**
    Implement the Least Recently Used (LRU) cache class:
    LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
    int get(int key) Return the value of the key if the key exists, otherwise return -1.
    void put(int key, int value) Update the value of the key if the key exists.
    Otherwise, add the key-value pair to the cache. If the number of keys exceeds
    the capacity from this operation, evict the least recently used key.
    
    Extra:
    The functions get and put must each run in O(1) average time complexity.
    
    LRUCache lRUCache = new LRUCache(2);
    lRUCache.put(1, 1); // cache is {1=1}
    lRUCache.put(2, 2); // cache is {1=1, 2=2}
    lRUCache.get(1);    // return 1
    lRUCache.put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
    lRUCache.get(2);    // returns -1 (not found)
    lRUCache.put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
    lRUCache.get(1);    // return -1 (not found)
    lRUCache.get(3);    // return 3
    lRUCache.get(4);    // return 4
 */
public class LRUCache
{
    public LRUCache(int capacity)
    {
        throw new NotImplementedException();
    }

    public int Get(int key)
    {
        throw new NotImplementedException();
    }

    public void Put(int key, int value)
    {
        throw new NotImplementedException();
    }
}

public class TestLruCache
{
    [Theory]
    [InlineData(2,
        1, 1, null,
        2, 2, null,
        1, null, 1,
        3, 3, null,
        2, null, -1,
        4, 4, null,
        1, null, -1,
        3, null, 3,
        4, null, 4
    )]
    public void Test(int capacity, params int?[] input)
    {
        var cache = new LRUCache(capacity);
        for (var i = 0; i < input.Length; i += 3)
        {
            var key = input[i]!.Value;
            var value = input[i + 1];
            var expected = input[i + 2];
            if (value.HasValue)
            {
                cache.Put(key, value.Value);
            }
            else if (expected.HasValue)
            {
                Assert.Equal(expected.Value, cache.Get(key));
            }
            else
            {
                throw new Exception("Invalid input");
            }
        }
    }
}
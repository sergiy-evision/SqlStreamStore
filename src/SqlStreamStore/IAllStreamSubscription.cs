﻿namespace SqlStreamStore
{
    using System;

    public interface IAllStreamSubscription : IDisposable
    {
        string Name { get; }

        long? LastPosition { get; }
    }
}
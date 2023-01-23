﻿namespace RCI.SharedMemory.Static.ACC;

public class AccSharedMemoryStaticConfig
{
  public AccSharedMemoryStaticConfig()
  {
    Graphics = new()
    {
      Enabled = true,
      UpdateInterval = 10
    };
    Physics = new()
    {
      Enabled = true,
      UpdateInterval = 1000
    };
    StaticInfo = new()
    {
      Enabled = true,
      UpdateInterval = 5000
    };
  }

  public int RetryTimerInterval { get; init; } = 2000;

  public AccSharedMemoryFileStaticConfig Graphics { get; init; }
  public AccSharedMemoryFileStaticConfig Physics { get; init; }
  public AccSharedMemoryFileStaticConfig StaticInfo { get; init; }
}

public class AccSharedMemoryFileStaticConfig
{
  public bool Enabled { get; init; }

  /// <summary>
  /// Update interval in ms
  /// </summary>
  public int UpdateInterval { get; init;}
}
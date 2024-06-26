﻿using ServerEntry.Shared.Service.Monitor;

namespace ServerEntry.Data.Hardware.Services;

public interface IMonitorService : IDisposable
{
    string Name { get; }

    MonitorStatus Status { get; }

    void Monitor();

    void StopMonitoring();

    bool GetValue(out object result, out Exception? exception);

    SortedDictionary<DateTime, object> GetValuesHistory(out Exception? exception);
}

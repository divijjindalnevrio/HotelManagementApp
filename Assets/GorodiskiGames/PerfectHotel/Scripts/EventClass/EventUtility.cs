
using System;

public static class EventUtility  
{
    public static Action<bool> OnPlayerWalkState;
    public static Action OnPlayerCollectCash;

    public static Action<bool> OnCashSpend;
}

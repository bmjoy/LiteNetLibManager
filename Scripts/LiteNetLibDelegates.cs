﻿namespace LiteNetLibHighLevel
{
    public delegate void MessageHandlerDelegate(LiteNetLibMessageHandler messageHandler);
    public delegate void NetFunctionDelegate();
    public delegate void NetFunctionDelegate<T1>(T1 param1) 
        where T1 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2>(T1 param1, T2 param2)
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3>(T1 param1, T2 param2, T3 param3) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3, T4>(T1 param1, T2 param2, T3 param3, T4 param4) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField
        where T4 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3, T4, T5>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField
        where T4 : LiteNetLibNetField
        where T5 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3, T4, T5, T6>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField
        where T4 : LiteNetLibNetField
        where T5 : LiteNetLibNetField
        where T6 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3, T4, T5, T6, T7>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField
        where T4 : LiteNetLibNetField
        where T5 : LiteNetLibNetField
        where T6 : LiteNetLibNetField
        where T7 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3, T4, T5, T6, T7, T8>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField
        where T4 : LiteNetLibNetField
        where T5 : LiteNetLibNetField
        where T6 : LiteNetLibNetField
        where T7 : LiteNetLibNetField
        where T8 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField
        where T4 : LiteNetLibNetField
        where T5 : LiteNetLibNetField
        where T6 : LiteNetLibNetField
        where T7 : LiteNetLibNetField
        where T8 : LiteNetLibNetField
        where T9 : LiteNetLibNetField;
    public delegate void NetFunctionDelegate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 param1, T2 param2, T3 param3, T4 param4, T5 param5, T6 param6, T7 param7, T8 param8, T9 param9, T10 param10) 
        where T1 : LiteNetLibNetField
        where T2 : LiteNetLibNetField
        where T3 : LiteNetLibNetField
        where T4 : LiteNetLibNetField
        where T5 : LiteNetLibNetField
        where T6 : LiteNetLibNetField
        where T7 : LiteNetLibNetField
        where T8 : LiteNetLibNetField
        where T9 : LiteNetLibNetField
        where T10 : LiteNetLibNetField;
}

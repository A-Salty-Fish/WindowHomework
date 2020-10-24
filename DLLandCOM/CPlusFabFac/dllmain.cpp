// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "pch.h"

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
 
_declspec(dllexport) long fab(long n)
{
    if (n < 0) return -1;
    if (n == 0) return 0;
    if (n == 1) return 1;
    int first = 0;
    int second = 1;
    int result = second;
    for (int i = 1; i < n; i++)
    {
        result = first + second;
        first = second;
        second = result;
    }
    return result;
}

_declspec(dllexport) long fac(long n)
{
    if (n < 0) return -1;
    long result = 1;
    for (int i = 1; i <= n; i++)
        result = result * i;
    return result;
}
using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazingPizza.Client
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jSRuntime, string message)
        {
            return jSRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}

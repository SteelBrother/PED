using GrupoBIOS_PEDWEB.DT.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces
{
    public interface IConexionRest
    {
        Task<HttpResponseWrapper<object>> Delete(string url);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T enviar);
    }
}

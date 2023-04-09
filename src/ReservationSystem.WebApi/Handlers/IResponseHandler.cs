using Microsoft.AspNetCore.Mvc;
using ReservationSystem.WebApi.ViewModels;
using System.Net;

namespace ReservationSystem.WebApi.Handlers
{
    public interface IResponseHandler
    {
        ActionResult<T> Handle<T>(T response, HttpStatusCode statusCode) where T : ResponseBase;
    }
}

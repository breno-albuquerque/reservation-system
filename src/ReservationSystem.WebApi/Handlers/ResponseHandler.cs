using Microsoft.AspNetCore.Mvc;
using ReservationSystem.WebApi.ViewModels;
using System.Net;

namespace ReservationSystem.WebApi.Handlers
{
    public class ResponseHandler : IResponseHandler
    {
        private ResponseBase? _response;

        public ActionResult<T> Handle<T>(T response, HttpStatusCode statusCode) where T : ResponseBase
        {
            _response = response;

            return statusCode switch
            {
                HttpStatusCode.Conflict => Conflict<T>(),
                HttpStatusCode.NotFound => NotFound<T>(),
                HttpStatusCode.Unauthorized => Unauthorized<T>(),
                _ => new ObjectResult(response)
                {
                    StatusCode = (int)statusCode
                }
            };
        }

        private ActionResult<T> Conflict<T>()
        {
            return new ConflictObjectResult(_response);
        }

        private ActionResult<T> Unauthorized<T>()
        {
            return new UnauthorizedObjectResult(_response);
        }

        private ActionResult<T> NotFound<T>()
        {
            return new NotFoundObjectResult(_response);
        }
    }
}

//namespace CarRentalSystem.Application.Common.Behaviours
//{
//    using System.Diagnostics;
//    using System.Threading;
//    using System.Threading.Tasks;
//    using CarRentalSystem.Application.Common.Contracts;
//    using MediatR;

//    public class RequestPerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
//    {
//        private readonly Stopwatch _timer;
//        private readonly ILogger<TRequest> _logger;
//        private readonly ICurrentUser _currentUserService;
//        private readonly IIdentityService _identityService;

//        public RequestPerformanceBehaviour(
//            ILogger<TRequest> logger,
//            ICurrentUser currentUserService,
//            IIdentityService identityService)
//        {
//            this._timer = new Stopwatch();

//            this._logger = logger;
//            this._currentUserService = currentUserService;
//            this._identityService = identityService;
//        }

//        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
//        {
//            this._timer.Start();

//            var response = await next();

//            this._timer.Stop();

//            var elapsedMilliseconds = this._timer.ElapsedMilliseconds;

//            if (elapsedMilliseconds > 500)
//            {
//                var requestName = typeof(TRequest).Name;
//                var userId = this._currentUserService.UserId;
//                var userName = await this._identityService.GetUserNameAsync(userId);

//                this._logger.LogWarning("DefaultTemplate Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@UserId} {@Request}",
//                    requestName, elapsedMilliseconds, userId, userName, request);
//            }

//            return response;
//        }
//    }
//}
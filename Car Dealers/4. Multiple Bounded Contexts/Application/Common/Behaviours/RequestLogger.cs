//namespace CarRentalSystem.Application.Common.Behaviours
//{
//    using System.Threading;
//    using System.Threading.Tasks;
//    using CarRentalSystem.Application.Common.Contracts;
//    using MediatR.Pipeline;

//    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
//    {
//        private readonly ILogger _logger;
//        private readonly ICurrentUser _currentUserService;
//        private readonly IIdentityService _identityService;

//        public RequestLogger(ILogger<TRequest> logger, ICurrentUser currentUserService, IIdentityService identityService)
//        {
//            this._logger = logger;
//            this._currentUserService = currentUserService;
//            this._identityService = identityService;
//        }

//        public async Task Process(TRequest request, CancellationToken cancellationToken)
//        {
//            var requestName = typeof(TRequest).Name;
//            var userId = this._currentUserService.UserId;
//            var userName = await this._identityService.GetUserNameAsync(userId);

//            this._logger.LogInformation("DefaultTemplate Request: {Name} {@UserId} {@UserName} {@Request}",
//                requestName, userId, userName ,request);
//        }
//    }
//}

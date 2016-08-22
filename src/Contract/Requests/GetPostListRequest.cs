using Contract.Responses;
using MediatR;

namespace Contract.Requests
{
    public class GetPostListRequest : IRequest<GetPostListResponse>
    {
        public int Take { get; set; }
        public int Skip { get; set; }
        public string Filter { get; set; }
        public string Order { get; set; }
    }
}

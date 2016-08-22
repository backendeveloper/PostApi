using Contract.Requests;
using Contract.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize, Route("api/posts")]
    public class Post : BaseApi
    {
        private readonly IMediator _mediator;

        public Post(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet, Route("")]
        public GetPostListResponse GetPostList(GetPostListRequest request)
        {
            return _mediator.Send(request);
        }


        #region Old Codes
        //[HttpGet]
        //[Route("autocomplete")]
        //public CampaignAutocompleteResponse GetCampaignAutocompleteList()
        //{
        //    return _mediator.Send(new CampaignAutocompleteRequest());
        //}

        //[HttpPost]
        //[Route("")]
        //[ValidateModelState]
        //public CampaignCreateResponse CreateCampaign(CampaignCreateRequest request)
        //{
        //    return _mediator.Send(request);
        //}

        //[HttpPut]
        //[Route("{campaignId:int}")]
        //[ValidateModelState]
        //public CampaignUpdateResponse UpdateCampaign(int campaignId, CampaignUpdateRequest request)
        //{
        //    request.Id = campaignId;
        //    return _mediator.Send(request);
        //}

        //[HttpDelete]
        //[Route("{campaignId:int}")]
        //public CampaignDeleteResponse DeleteCampaign(int campaignId)
        //{
        //    return _mediator.Send(new CampaignDeleteRequest(campaignId));
        //}

        //[HttpPost]
        //[Route("getallpaged")]
        //public DatatableResponse<CampaignDto> GetCampaignListPaged(CampaignDatatableRequest datatableRequest)
        //{
        //    return _mediator.Send(datatableRequest);
        //}

        //[HttpGet]
        //[Route("{campaignId:int}")]
        //public CampaignDetailResponse GetCampaignDetail(int campaignId)
        //{
        //    CampaignDetailRequest request = new CampaignDetailRequest()
        //    {
        //        CampaignId = campaignId
        //    };

        //    return _mediator.Send(request);
        //}

        //[HttpOptions]
        //[Route("")]
        //public IHttpActionResult Options()
        //{
        //    return Ok();
        //}

        //[HttpGet]
        //[Route("{campaignId:int}/products/sorted")]
        //public GetProductSortingListResponse GetProductList(int campaignId)
        //{
        //    return _mediator.Send(new GetProductSortingListRequest(campaignId));
        //}
        #endregion
    }
}
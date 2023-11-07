using MediatR;

namespace OnionArcApi.Application.Features.Products.Queries.GetAllProducts;

public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
{
}

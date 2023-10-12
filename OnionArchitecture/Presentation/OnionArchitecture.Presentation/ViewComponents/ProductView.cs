using Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class ProductView: ViewComponent
    {
        private readonly IMediator _mediator;

        public ProductView(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetAllProductQueryRequest());
            return View(value);
        }
    }
}

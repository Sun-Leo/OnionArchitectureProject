using Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class DinnerView: ViewComponent
    {
        private readonly IMediator _mediator;

        public DinnerView(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value= await _mediator.Send(new GetAllDinnerMenuQueryRequest());
            return View(value);
        }
    }
}

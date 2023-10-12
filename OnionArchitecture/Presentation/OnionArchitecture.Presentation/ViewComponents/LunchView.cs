using Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class LunchView: ViewComponent
    {
        private readonly IMediator _mediator;

        public LunchView(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetAllLunchMenuQueryRequest());
            return View(value);
        }
    }
}

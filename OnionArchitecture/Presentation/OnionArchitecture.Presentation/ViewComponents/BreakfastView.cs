using Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class BreakfastView: ViewComponent
    {
        private readonly IMediator _mediator;

        public BreakfastView(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value= await _mediator.Send(new GetAllBreakfastMenuQueryRequest());
            return View(value);
        }
    }
}

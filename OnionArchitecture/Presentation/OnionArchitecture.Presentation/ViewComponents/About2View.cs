using Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class About2View: ViewComponent
    {
        private readonly IMediator _mediator;

        public About2View(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value= await _mediator.Send(new GetAllAboutQueryRequest());
            return View(value);
        }
    }
}

using Application.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class OurSpecialsView: ViewComponent
    {
        private readonly IMediator _mediator;

        public OurSpecialsView(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value= await _mediator.Send(new GetAllCategoriQueryRequest());
            return View(value);
        }
    }
}

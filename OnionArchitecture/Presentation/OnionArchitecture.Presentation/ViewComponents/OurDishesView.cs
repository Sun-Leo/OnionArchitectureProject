using Application.CQRS.Queries;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture.Presentation.ViewComponents
{
    public class OurDishesView : ViewComponent
    {
       private readonly IMediator _mediator;

        public OurDishesView(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _mediator.Send(new GetAllOurDishesQueryRequest());
            return View(value);
        }
    }
}

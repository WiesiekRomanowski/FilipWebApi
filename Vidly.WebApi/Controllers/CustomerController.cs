using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vidly.Services.Interfaces;
using Vidly.WebApi.Models;

namespace Vidly.WebApi.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public CustomerController(
            IMapper mapper, 
            ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetCustomers();
            var viewModel = _mapper.Map<List<CustomerViewModel>>(customers);

            return View(viewModel);
        }
    }
}

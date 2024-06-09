using kolokwium_apbd.DTOs;
using kolokwium_apbd.Models;
using kolokwium_apbd.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium_apbd.Controllers;

[Route("/api/payment"), ApiController]
public class PaymentController
{
    private readonly IPaymentService _paymentService = new PaymentService();

    [HttpGet("{idPayment:int}, {id}")]
    public async Task<Payment> GetClientPaymentInfo(int clientId)
    {

        var payment = await _paymentService.GetClientPaymentInfo(clientId);
        var result = new PaymentDto()
        {
            IdPayment = payment.IdPayment,
            Date = payment.Date,
            IdClient = payment.IdClient,
            IdSubscription = payment.IdSubscription
        };

        return payment;
    }
}
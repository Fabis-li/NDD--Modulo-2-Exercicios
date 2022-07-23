using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace modulo2_semana6_api.Controllers;

[ApiController]
[Route("[controller]")]

public class ExercicioEmailController : ControllerBase
{
    [HttpGet("{email}")]
    public string Get(string email)
    {
        if(ValidarEmail(email))
            return "Email válido.";
        return "Email inválido!";
        throw new EmailInvalidoException(email);
    }

    private static bool ValidarEmail(string email)
    {
        var regexEmail = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

        var valido = Regex.IsMatch(email, regexEmail);
        if(valido)
            return true;

        return false;
    }
    
}
[Serializable]
public class EmailInvalidoException : Exception
{
    public EmailInvalidoException()
    {
        
    }
    public EmailInvalidoException(string email) : base (String.Format($"Email inválido: {email}"))
    {

    }
}


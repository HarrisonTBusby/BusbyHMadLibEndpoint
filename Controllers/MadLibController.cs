//Harrison Busby
//10/26/2022
//MadLibEndPoint
//Peer reviewed by:Peer Review By: Kenneth Fujimura — Everything works. 
//All of the variables were called in the correct ways, at the right time. 
//The API and the pulling inputs from the URL also worked. The story was cute. No real errors. Great job, Harrison!





using Microsoft.AspNetCore.Mvc;

namespace BusbyHMadLibEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
  [HttpGet]
  [Route("BigSchleem/{nounPlace}/{nounName}/{verbSingular}/{adj1}/{nounPlace2}/{nounName2}/{verbED}/{adj2}/{nounPlace3}/{nounPlace4}")]

public string MadLibTime(string nounPlace, string nounName, string verbSingular, string adj1, string nounPlace2, string nounName2, string verbED, string adj2, string nounPlace3, string nounPlace4){


string result = "";
result = $"A man once went to the {nounPlace}. When he went there he encountered a wild {nounName}. Once he saw the {nounName} he {verbSingular} it as brutally as he could. Once the man {verbSingular} it, he became {adj1}. Once the man became {adj1}, he went on to befriend the wild {nounName}. Once they became good friends, they came to an {nounPlace2}. While in the {nounPlace2}, they met another. Their name was {nounName2}. Once {nounName} and {nounName2} met eachother, they {verbED} eachother.. They two continued to {verbED} until they eventually became {adj2}. After a while, they stopped and started going toward the {nounPlace3}. When they got there they saw the {nounPlace4} and they couldn't be any happier. THE END";

return result;
    
}


}

//Chris Martinez
//10/25/22
//Asking a Question
//Peer Review Carlos Felipe: This program works well to print out my name and time I woke up. Good job. Muy bueno.
///https://localhost:***/askquestion/askme/{name}/{time}

using Microsoft.AspNetCore.Mvc;

namespace MartinezCAskQEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskQuestionController : ControllerBase
{
[HttpGet]
[Route("AskMe/{name}/{time}")]

 public string TellMeYourName(string name, string time)

 {
  return name + " woke up at " + time;

 }


}

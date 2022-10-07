using Microsoft.AspNetCore.Mvc;

namespace WD.Botifier.Examples.Webhooks.Controllers;

[ApiController]
[Route("[controller]")]
public class ReplyToMentionController : ControllerBase
{
    private readonly ILogger<ReplyToMentionController> _logger;

    public ReplyToMentionController(ILogger<ReplyToMentionController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public WebhookResponse Post([FromBody] UserNameMentionInCommentWebhookRequest request)
    {
        return new WebhookResponse(
            new [] 
            {
                new ReplyToCommentIntent()
                {
                    Reply = "Hello " + request.CommentAuthor,
                    CommentId = request.CommentId
                }
            }, 
            new List<ReplyToPostIntent>());
    }
}
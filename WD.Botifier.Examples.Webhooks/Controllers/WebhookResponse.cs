namespace WD.Botifier.Examples.Webhooks.Controllers;

public class WebhookResponse
{
    public WebhookResponse(IEnumerable<ReplyToCommentIntent> replyToCommentIntents, IEnumerable<ReplyToPostIntent> replyToPostIntents)
    {
        ReplyToCommentIntents = replyToCommentIntents;
        ReplyToPostIntents = replyToPostIntents;
    }
    
    public IEnumerable<ReplyToCommentIntent> ReplyToCommentIntents { get; }
    
    public IEnumerable<ReplyToPostIntent> ReplyToPostIntents { get; }
}

public class ReplyToCommentIntent
{
    public string CommentId { get; set; }
    public string Reply { get; set; }
}

public class ReplyToPostIntent
{
    public string PostId { get; set; }
    public string Reply { get; set; }
}
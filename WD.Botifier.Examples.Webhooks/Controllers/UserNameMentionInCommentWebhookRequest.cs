namespace WD.Botifier.Examples.Webhooks.Controllers;

public class UserNameMentionInCommentWebhookRequest
{
    public string TriggerType { get; set; }
    public DateTime TriggeredOn { get; set; }
    public string CommentAuthor { get; set; }
    public string CommentContent { get; set; }
    public string CommentId { get; set; }
}
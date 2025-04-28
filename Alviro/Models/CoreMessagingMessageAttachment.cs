using System;
using System.Collections.Generic;

namespace Alviro.Models;

public partial class CoreMessagingMessageAttachment
{
    public int MessageAttachmentId { get; set; }

    public int MessageId { get; set; }

    public int? FileId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual CoreMessagingMessage Message { get; set; } = null!;
}

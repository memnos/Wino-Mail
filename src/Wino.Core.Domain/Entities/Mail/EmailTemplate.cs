using System;
using SQLite;

namespace Wino.Core.Domain.Entities.Mail;

public class EmailTemplate
{
    [PrimaryKey]
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    /// <summary>Optional subject applied when the template is inserted into a message.</summary>
    public string Subject { get; set; } = string.Empty;

    /// <summary>Optional recipients, separated by comma or semicolon, applied to the To field.</summary>
    public string ToAddresses { get; set; } = string.Empty;

    public string HtmlContent { get; set; } = string.Empty;
}

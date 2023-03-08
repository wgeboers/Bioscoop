using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Models.Models
{
    public class MailDataWithAttachments
    {
        // Receiver
#pragma warning disable CS8618 // Non-nullable property 'To' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<string> To { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'To' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public List<string>? Bcc { get; set; }

        public List<string>? Cc { get; set; }

        // Sender
        public string? From { get; set; }
        public string? DisplayName { get; set; }
        public string? ReplyTo { get; set; }
        public string? ReplyToName { get; set; }

        // Content
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public IFormFileCollection? Attachments { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Attachment' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public byte[] Attachment { get; set; }  
#pragma warning restore CS8618 // Non-nullable property 'Attachment' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.


    }
}

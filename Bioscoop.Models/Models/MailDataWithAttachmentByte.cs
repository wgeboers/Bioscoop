using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioscoop.Models.Models
{
    public class MailDataWithAttachmentByte
    {
        // Receiver
        public List<string> To { get; set; }
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
       // public IFormFileCollection? Attachments { get; set; }
       public byte[] Attachment { get; set; }

        public MailDataWithAttachmentByte(List<string> to, 
            string subject, byte[] attachment, string? body = null, string? from = null, 
            string? displayName = null, string? replyTo = null, string? replyToName = null, 
            List<string>? bcc = null, List<string>? cc = null)
        {
            // Receiver            
            To = to;
            Bcc = bcc ?? new List<string>();
            Cc = cc ?? new List<string>();

            // Sender
            From = from;
            DisplayName = displayName;
            ReplyTo = replyTo;
            ReplyToName = replyToName;

            // Content
            Subject = subject;
            Body = body;

            Attachment = attachment;
        }
    }
}
